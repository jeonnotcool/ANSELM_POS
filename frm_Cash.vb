Imports System.Globalization ' Import the Globalization namespace at the top

Public Class frm_Cash

    Private totalAmount As Decimal
    Public Property AmountReceived As Decimal
    Public Property ChangeAmount As Decimal
    Private phCulture As New CultureInfo("en-PH")
    Private phNumberFormat As NumberFormatInfo
    Public Sub New(ByVal total As Decimal)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        phNumberFormat = CType(phCulture.NumberFormat.Clone(), NumberFormatInfo)
        phNumberFormat.CurrencySymbol = "₱"

        totalAmount = total
        lblTotalDue.Text = totalAmount.ToString("C", phNumberFormat)
        lblChangeDue.Text = "₱0.00"
        txtAmountReceived.Focus() ' Set focus to the amount received textbox
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim amountReceivedStr As String = txtAmountReceived.Text.Trim()

        If Decimal.TryParse(amountReceivedStr, NumberStyles.Currency, phNumberFormat, AmountReceived) Then
            If AmountReceived >= totalAmount Then
                ChangeAmount = AmountReceived - totalAmount
                MessageBox.Show($"Payment successful! Change: {ChangeAmount.ToString("C", phNumberFormat)}", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Insufficient amount received.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Invalid amount received.  Please enter a valid currency amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAmountReceived.Focus() ' Put the focus back on the textbox
            txtAmountReceived.SelectAll() ' Select all text for easy correction
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub txtAmountReceived_TextChanged(sender As Object, e As EventArgs) Handles txtAmountReceived.TextChanged
        Dim amountReceived As Decimal
        If Decimal.TryParse(txtAmountReceived.Text, NumberStyles.Currency, phNumberFormat, amountReceived) Then
            If amountReceived >= totalAmount Then
                Dim change_Renamed As Decimal = amountReceived - totalAmount
                lblChangeDue.Text = change_Renamed.ToString("C", phNumberFormat)
            Else
                lblChangeDue.Text = "₱0.00" ' Reset if insufficient
            End If

        Else
            lblChangeDue.Text = "₱0.00" ' Reset if invalid input
        End If
    End Sub
End Class