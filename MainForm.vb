Imports System.Data.OleDb
Imports System.Globalization

Public Class MainForm

    ' --- Currency Formatting ---
    Private phCulture As New CultureInfo("en-PH")  ' Or "fil-PH" if it displays ₱ correctly
    Private phNumberFormat As NumberFormatInfo




    ' --- Store Total Amount ---
    Private totalAmount As Decimal = 0D
    Private transactionID As String

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        phNumberFormat = CType(phCulture.NumberFormat.Clone(), NumberFormatInfo)
        phNumberFormat.CurrencySymbol = "₱"

        ' Add Resize event handler
        AddHandler Me.Resize, AddressOf MainForm_Resize
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs)
        Console.WriteLine($"Form resized to: {Me.Size}")
    End Sub

    Public Property LoggedInUser As String
    Public Property UserRole As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load user role
        lblLoginAsText.Text = LoggedInUser
        lblRoleText.Text = UserRole

        ' Load Products into dgvProduct *ONCE*
        LoadProducts() ' Use a separate, dedicated function

        ' --- dgvTransaction Formatting ---
        '  (You've already set up columns in the Designer, so we only format here)
        If dgvTransaction.Columns.Contains("colPrice") Then
            dgvTransaction.Columns("colPrice").DefaultCellStyle.Format = "C"
            dgvTransaction.Columns("colPrice").DefaultCellStyle.FormatProvider = phNumberFormat
        End If
        If dgvTransaction.Columns.Contains("colSubtotal") Then
            dgvTransaction.Columns("colSubtotal").DefaultCellStyle.Format = "C"
            dgvTransaction.Columns("colSubtotal").DefaultCellStyle.FormatProvider = phNumberFormat
        End If
        If dgvTransaction.Columns.Contains("colProductName") Then
            dgvTransaction.Columns("colProductName").HeaderText = "Item"
        End If
        If dgvTransaction.Columns.Contains("colQuantity") Then
            dgvTransaction.Columns("colQuantity").HeaderText = "Qty"
        End If

        ' --- Align Total ---
        lblTotal.TextAlign = ContentAlignment.MiddleRight

        transactionID = DBAccess.GenerateTransactionID() ' Generate and STORE the ID
        lblTransID.Text = transactionID

        UpdateTotal() ' Initialize to 0
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LoadProducts()
        Try
            dgvProduct.AutoGenerateColumns = False ' Prevent automatic column generation

            ' Clear existing columns
            dgvProduct.Columns.Clear()

            ' Define columns manually
            Dim colProductID As New DataGridViewTextBoxColumn()
            colProductID.Name = "ProductIDColumn"
            colProductID.DataPropertyName = "ProductID"
            colProductID.Visible = False ' Hide ProductID

            Dim colProductName As New DataGridViewTextBoxColumn()
            colProductName.Name = "ProductNameColumn"
            colProductName.DataPropertyName = "ProductName"
            colProductName.HeaderText = "Name"

            Dim colPrice As New DataGridViewTextBoxColumn()
            colPrice.Name = "PriceColumn"
            colPrice.DataPropertyName = "Price"
            colPrice.HeaderText = "Price"
            colPrice.DefaultCellStyle.Format = "C"
            colPrice.DefaultCellStyle.FormatProvider = phNumberFormat

            Dim colCategory As New DataGridViewTextBoxColumn()
            colCategory.Name = "CategoryColumn"
            colCategory.DataPropertyName = "Category"
            colCategory.HeaderText = "Category"

            Dim colStock As New DataGridViewTextBoxColumn()
            colStock.Name = "StockColumn"
            colStock.DataPropertyName = "StockQuantity"
            colStock.HeaderText = "Stock"

            ' Add columns to DataGridView
            dgvProduct.Columns.AddRange(New DataGridViewColumn() {colProductID, colProductName, colPrice, colCategory, colStock})

            ' Bind data to DataGridView
            dgvProduct.DataSource = DBAccess.GetProducts()

        Catch ex As Exception
            MessageBox.Show("Error initializing product grid: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub dgvProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvProduct.Rows(e.RowIndex)
            Dim productName As String = selectedRow.Cells("ProductNameColumn").Value.ToString()
            Dim price As Decimal = CDec(selectedRow.Cells("PriceColumn").Value)
            Dim stockQuantity As Integer = CInt(selectedRow.Cells("StockColumn").Value) ' Get stock quantity
            Dim quantity As Integer = 1

            ' --- Quantity Input (with loop for validation) ---
            Do
                Dim quantityInput As New InputBox("Enter Quantity:", "Quantity", quantity.ToString())
                Dim result As DialogResult = quantityInput.ShowDialog()

                If result = DialogResult.OK Then
                    If Integer.TryParse(quantityInput.Result, quantity) AndAlso quantity > 0 AndAlso quantity <= stockQuantity Then ' Check if quantity is within stock limits
                        Exit Do ' Valid input
                    ElseIf quantity > stockQuantity Then
                        MessageBox.Show("Insufficient stock. Available quantity: " & stockQuantity, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Invalid quantity. Please enter a positive whole number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    Return ' User cancelled
                End If
            Loop

            ' --- Add to Transaction ---
            Dim subtotal As Decimal = price * quantity
            dgvTransaction.Rows.Add(productName, quantity, price.ToString("C", phNumberFormat), subtotal.ToString("C", phNumberFormat))
            UpdateTotal()
        End If
    End Sub

    'Create an InputBox class
    Public Class InputBox
        Private prompt As String
        Private title As String
        Private defaultValue As String
        Private form As Form
        Private textBox As TextBox

        Public Sub New(prompt As String, title As String, Optional defaultValue As String = "")
            Me.prompt = prompt
            Me.title = title
            Me.defaultValue = defaultValue
        End Sub

        Public ReadOnly Property Result As String
            Get
                Return textBox.Text
            End Get
        End Property

        Public Function ShowDialog() As DialogResult
            form = New Form() With {
                .FormBorderStyle = FormBorderStyle.FixedDialog,
                .MinimizeBox = False,
                .MaximizeBox = False,
                .StartPosition = FormStartPosition.CenterParent,
                .Size = New Size(300, 150),
                .Text = title
            }

            Dim promptLabel As New Label() With {
                .Text = prompt,
                .Location = New Point(10, 10)
            }

            textBox = New TextBox() With {
                .Text = defaultValue,
                .Location = New Point(10, 40),
                .Size = New Size(260, 20)
            }

            Dim okButton As New Button() With {
                .Text = "OK",
                .DialogResult = DialogResult.OK,
                .Location = New Point(100, 70)
            }

            Dim cancelButton As New Button() With {
                .Text = "Cancel",
                .DialogResult = DialogResult.Cancel,
                .Location = New Point(190, 70)
            }

            form.Controls.AddRange({promptLabel, textBox, okButton, cancelButton})
            form.AcceptButton = okButton
            form.CancelButton = cancelButton

            Return form.ShowDialog()
        End Function
    End Class

    Private Sub UpdateTotal()
        totalAmount = 0D ' Use the form-level variable
        If dgvTransaction.Rows.Count > 0 Then
            totalAmount = dgvTransaction.Rows.Cast(Of DataGridViewRow)().
                Where(Function(row) row.Cells("colSubtotal").Value IsNot Nothing).
                Sum(Function(row) Decimal.Parse(row.Cells("colSubtotal").Value.ToString(), NumberStyles.Currency, phNumberFormat))
        End If
        lblTotal.Text = totalAmount.ToString("C2", phNumberFormat) ' Format as currency
    End Sub


    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Alt AndAlso e.KeyCode = Keys.F4 Then
            MessageBox.Show("Press F11 or Close Button to exit the application or F12 to Logout.", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            e.Handled = True

        ElseIf e.KeyCode = Keys.F1 Then
            btnNewTransaction_Click(sender, New EventArgs()) ' Simulate a click on btnNewTransaction
            e.Handled = True ' Prevent further processing of the key press
        ElseIf e.KeyCode = Keys.F4 Then
            btnVoidItem_Click(sender, New EventArgs()) ' Simulate a click on btnVoidItem
            e.Handled = True
        ElseIf e.KeyCode = Keys.F5 Then
            btnClearQuery_Click(sender, New EventArgs()) ' Simulate a click on btnVoidItem
            e.Handled = True
        ElseIf e.KeyCode = Keys.F6 Then
            txtSearch.Focus() ' Set focus to the search textbox
            e.Handled = True
        ElseIf e.KeyCode = Keys.F8 Then
            btnCompleteTransaction_Click(sender, New EventArgs()) ' Simulate a click on btnCompleteTransaction
            e.Handled = True
        ElseIf e.KeyCode = Keys.F9 Then
            btnGCash_Click(sender, New EventArgs()) ' Simulate a click on btnGCash
            e.Handled = True
        ElseIf e.KeyCode = Keys.F11 Then
            btnClose_Click(sender, New EventArgs()) ' Simulate a click on btnClose
            e.Handled = True
        ElseIf e.KeyCode = Keys.F12 Then
            btnLogout_Click(sender, New EventArgs()) ' Simulate a click on btnLogout
            e.Handled = True
        End If
    End Sub

    Private Sub btnNewTransaction_Click(sender As Object, e As EventArgs) Handles btnNewTransaction.Click
        transactionID = DBAccess.GenerateTransactionID() ' Generate and STORE the ID
        lblTransID.Text = transactionID

        dgvTransaction.Rows.Clear()
        UpdateTotal()
        LoadProducts() ' Refresh the product list to reflect the updated stock
        lblStatusText.Text = "NOT PAID | NEW TRANS"
    End Sub

    Private Sub btnVoidItem_Click(sender As Object, e As EventArgs) Handles btnVoidItem.Click
        If dgvTransaction.SelectedRows.Count > 0 Then
            dgvTransaction.Rows.RemoveAt(dgvTransaction.SelectedRows(0).Index)
            UpdateTotal() ' Just update the total display
        Else
            MessageBox.Show("Please select an item to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCompleteTransaction_Click(sender As Object, e As EventArgs) Handles btnCompleteTransaction.Click
        If dgvTransaction.Rows.Count = 0 Then
            MessageBox.Show("No items in the transaction.", "Empty Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Use the stored totalAmount ---
        Dim paymentForm As New frm_Cash(totalAmount)  'Pass the stored value
        Dim result As DialogResult = paymentForm.ShowDialog()

        If result = DialogResult.OK Then
            ' --- Get values BEFORE closing the form ---
            Dim amountReceived As Decimal = paymentForm.AmountReceived '<-- Get BEFORE closing
            Dim changeAmount As Decimal = paymentForm.ChangeAmount     '<-- Get BEFORE closing

            ' --- Prepare Transaction Data ---
            Dim transactionData As New DataTable()
            With transactionData.Columns
                .Add("colProductName", GetType(String))
                .Add("colQuantity", GetType(Integer))
                .Add("colPrice", GetType(Decimal))
                .Add("colSubtotal", GetType(Decimal))
            End With

            For Each row As DataGridViewRow In dgvTransaction.Rows
                If row.Cells("colProductName").Value IsNot Nothing AndAlso
            row.Cells("colQuantity").Value IsNot Nothing AndAlso
            row.Cells("colPrice").Value IsNot Nothing AndAlso
            row.Cells("colSubtotal").Value IsNot Nothing Then

                    Dim productName As String = row.Cells("colProductName").Value.ToString()
                    Dim quantity As Integer = CInt(row.Cells("colQuantity").Value)
                    Dim price As Decimal = Decimal.Parse(row.Cells("colPrice").Value.ToString(), NumberStyles.Currency, phNumberFormat)
                    Dim subtotal As Decimal = Decimal.Parse(row.Cells("colSubtotal").Value.ToString(), NumberStyles.Currency, phNumberFormat)
                    transactionData.Rows.Add(productName, quantity, price, subtotal)

                End If
            Next

            ' --- Save Transaction ---

            Dim transactionDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Current date and time

            If DBAccess.SaveTransaction(transactionData, totalAmount, amountReceived, changeAmount, LoggedInUser, transactionID) Then 'pass the transactionID

                ' --- Log Payment in Payments Sheet ---
                Dim paymentDetails As New Dictionary(Of String, Object) From {
                {"TransactionID", transactionID},
                {"PaymentMethod", "Cash"},
                {"ReferenceNo", "Cash"},
                {"CustomerNumber", "Cash"},
                {"Date", transactionDate},
                {"User", LoggedInUser}
            }

                If DBAccess.LogPayment(paymentDetails) Then
                    ' --- Set Last Transaction ID ---
                    DBAccess.SetLastTransactionID(transactionID)

                    ' --- Update Stock AFTER saving the transaction ---
                    For Each row As DataRow In transactionData.Rows
                        Dim productName As String = row("colProductName").ToString()
                        Dim quantity As Integer = CInt(row("colQuantity"))
                        DBAccess.UpdateStock(productName, quantity) ' Update stock after successful transaction save
                    Next

                    MessageBox.Show("Transaction completed! Please press F1 or click New TXN.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblStatusText.Text = "PAID through Cash! PRESS F1 FOR NEW TXN"
                Else
                    MessageBox.Show("Transaction completed, but payment log failed.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("Transaction Completed, but there was an Error saving To the database.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            ' Payment was cancelled - do nothing (or show a message)
        End If
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchText As String = txtSearch.Text.Trim().ToLower()
        Dim dt As DataTable

        If TypeOf dgvProduct.DataSource Is DataView Then
            dt = CType(dgvProduct.DataSource, DataView).Table
        ElseIf TypeOf dgvProduct.DataSource Is DataTable Then
            dt = CType(dgvProduct.DataSource, DataTable)
        Else
            Return ' DataSource is not a DataTable or DataView, exit the method
        End If

        If dt IsNot Nothing Then ' Important: Check if DataSource is actually a DataTable
            Dim dv As New DataView(dt)
            dv.RowFilter = $"CONVERT(ProductName, 'System.String') LIKE '%{searchText}%'"
            dgvProduct.DataSource = dv
        End If
    End Sub

    Private Sub btnGCash_Click(sender As Object, e As EventArgs) Handles btnGCash.Click
        If dgvTransaction.Rows.Count = 0 Then
            MessageBox.Show("No items in the transaction.", "Empty Transaction", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- Open the GCash Payment Form ---
        Dim paymentForm As New frm_GCash(totalAmount)
        Dim result As DialogResult = paymentForm.ShowDialog()

        If result = DialogResult.OK Then
            Dim amountReceived As Decimal = paymentForm.AmountReceived
            Dim changeAmount As Decimal = paymentForm.ChangeAmount
            Dim referenceNumber As String = paymentForm.ReferenceNumber
            Dim customerNumber As String = paymentForm.CustomerNumber

            ' --- Prepare Transaction Data ---
            Dim transactionData As New DataTable()
            With transactionData.Columns
                .Add("colProductName", GetType(String))
                .Add("colQuantity", GetType(Integer))
                .Add("colPrice", GetType(Decimal))
                .Add("colSubtotal", GetType(Decimal))
            End With

            For Each row As DataGridViewRow In dgvTransaction.Rows
                If row.Cells("colProductName").Value IsNot Nothing AndAlso
                   row.Cells("colQuantity").Value IsNot Nothing AndAlso
                   row.Cells("colPrice").Value IsNot Nothing AndAlso
                   row.Cells("colSubtotal").Value IsNot Nothing Then

                    Dim productName As String = row.Cells("colProductName").Value.ToString()
                    Dim quantity As Integer = CInt(row.Cells("colQuantity").Value)
                    Dim price As Decimal = Decimal.Parse(row.Cells("colPrice").Value.ToString(), NumberStyles.Currency, phNumberFormat)
                    Dim subtotal As Decimal = Decimal.Parse(row.Cells("colSubtotal").Value.ToString(), NumberStyles.Currency, phNumberFormat)
                    transactionData.Rows.Add(productName, quantity, price, subtotal)
                End If
            Next

            ' --- Save Transaction ---

            Dim transactionDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") ' Current date and time

            If DBAccess.SaveTransaction(transactionData, totalAmount, amountReceived, changeAmount, LoggedInUser, transactionID) Then ' Pass transactionID

                ' --- Log Payment in Payments Sheet ---
                Dim paymentDetails As New Dictionary(Of String, Object) From {
                    {"TransactionID", transactionID},
                    {"PaymentMethod", "GCash"},
                    {"ReferenceNo", referenceNumber},
                    {"CustomerNumber", customerNumber}, ' <-- Now storing the actual number
                    {"Date", transactionDate},
                    {"User", LoggedInUser}
                }

                If DBAccess.LogPayment(paymentDetails) Then
                    ' --- Set Last Transaction ID ---
                    DBAccess.SetLastTransactionID(transactionID)

                    ' --- Update Stock AFTER saving the transaction ---
                    For Each row As DataRow In transactionData.Rows
                        Dim productName As String = row("colProductName").ToString()
                        Dim quantity As Integer = CInt(row("colQuantity"))
                        DBAccess.UpdateStock(productName, quantity) ' Update stock after successful transaction save
                    Next

                    MessageBox.Show("Transaction completed! Please press F1 or click New TXN.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    lblStatusText.Text = "PAID through GCash! PRESS F1 FOR NEW TXN"
                Else
                    MessageBox.Show("Transaction completed, but payment log failed.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

            Else
                MessageBox.Show("Transaction Completed, but there was an Error saving To the database.", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            ' Payment was cancelled - do nothing (or show a message)
        End If
    End Sub

    Private Sub btnClearQuery_Click(sender As Object, e As EventArgs) Handles btnClearQuery.Click
        txtSearch.Clear()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        ' Prevent the app from closing

        RemoveHandler Me.FormClosed, AddressOf MainForm_FormClosed

        ' Optionally, clear the labels before hiding the form (security purpose)
        lblLoginAsText.Text = ""
        lblRoleText.Text = ""

        ' Show the Login form again
        Dim loginForm As New frm_Login()
        loginForm.Show()

        Me.Close() ' close the main form
        AddHandler Me.FormClosed, AddressOf MainForm_FormClosed
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class