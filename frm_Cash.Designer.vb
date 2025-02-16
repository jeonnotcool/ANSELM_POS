<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Cash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.lblTotalDueText = New System.Windows.Forms.Label()
        Me.lblAmountReceivedText = New System.Windows.Forms.Label()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.lblChangeDueText = New System.Windows.Forms.Label()
        Me.txtAmountReceived = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTotalDue
        '
        Me.lblTotalDue.AutoSize = True
        Me.lblTotalDue.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.lblTotalDue.Location = New System.Drawing.Point(287, 60)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(92, 44)
        Me.lblTotalDue.TabIndex = 3
        Me.lblTotalDue.Text = "₱0.00"
        '
        'lblTotalDueText
        '
        Me.lblTotalDueText.AutoSize = True
        Me.lblTotalDueText.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalDueText.Location = New System.Drawing.Point(28, 60)
        Me.lblTotalDueText.Name = "lblTotalDueText"
        Me.lblTotalDueText.Size = New System.Drawing.Size(153, 44)
        Me.lblTotalDueText.TabIndex = 2
        Me.lblTotalDueText.Text = "Total Due:"
        '
        'lblAmountReceivedText
        '
        Me.lblAmountReceivedText.AutoSize = True
        Me.lblAmountReceivedText.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblAmountReceivedText.Location = New System.Drawing.Point(28, 135)
        Me.lblAmountReceivedText.Name = "lblAmountReceivedText"
        Me.lblAmountReceivedText.Size = New System.Drawing.Size(261, 44)
        Me.lblAmountReceivedText.TabIndex = 4
        Me.lblAmountReceivedText.Text = "Amount Received:"
        '
        'lblChangeDue
        '
        Me.lblChangeDue.AutoSize = True
        Me.lblChangeDue.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.lblChangeDue.Location = New System.Drawing.Point(287, 210)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(92, 44)
        Me.lblChangeDue.TabIndex = 7
        Me.lblChangeDue.Text = "₱0.00"
        '
        'lblChangeDueText
        '
        Me.lblChangeDueText.AutoSize = True
        Me.lblChangeDueText.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblChangeDueText.Location = New System.Drawing.Point(28, 210)
        Me.lblChangeDueText.Name = "lblChangeDueText"
        Me.lblChangeDueText.Size = New System.Drawing.Size(132, 44)
        Me.lblChangeDueText.TabIndex = 6
        Me.lblChangeDueText.Text = "Change:"
        '
        'txtAmountReceived
        '
        Me.txtAmountReceived.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.txtAmountReceived.Location = New System.Drawing.Point(332, 132)
        Me.txtAmountReceived.Name = "txtAmountReceived"
        Me.txtAmountReceived.Size = New System.Drawing.Size(88, 45)
        Me.txtAmountReceived.TabIndex = 8
        Me.txtAmountReceived.Text = "0.00"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(315, 306)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(182, 52)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL [Esc]"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(116, 306)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(164, 52)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "PAY [ENTER]"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(287, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 44)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "₱"
        '
        'frm_Payment
        '
        Me.AcceptButton = Me.btnPay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(633, 412)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtAmountReceived)
        Me.Controls.Add(Me.lblChangeDue)
        Me.Controls.Add(Me.lblChangeDueText)
        Me.Controls.Add(Me.lblAmountReceivedText)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblTotalDueText)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Display", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enter Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblTotalDueText As Label
    Friend WithEvents lblAmountReceivedText As Label
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents lblChangeDueText As Label
    Friend WithEvents txtAmountReceived As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents Label1 As Label
End Class
