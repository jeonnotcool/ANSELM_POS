Imports System.Globalization ' Import the Globalization namespace at the top

Public Class frm_GCash
    Private totalAmount As Decimal
    Public Property AmountReceived As Decimal
    Public Property ChangeAmount As Decimal
    Public Property ReferenceNumber As String ' Store the Reference Number
    Public Property CustomerNumber As String ' Store the Customer Number

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
        txtRefNo.Focus() ' Set focus to the reference number textbox
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If String.IsNullOrWhiteSpace(txtRefNo.Text) Then
            MessageBox.Show("Please enter a valid GCash Reference Number.", "Invalid Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtGCashNo.Text) Then
            MessageBox.Show("Please enter the customer's GCash number.", "Missing Customer Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ReferenceNumber = txtRefNo.Text.Trim()
        CustomerNumber = txtGCashNo.Text.Trim()
        AmountReceived = totalAmount ' GCash payments are exact (no change)
        ChangeAmount = 0

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
