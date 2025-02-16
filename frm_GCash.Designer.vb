<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GCash
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
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.txtGCashNo = New System.Windows.Forms.TextBox()
        Me.lblGCashNo = New System.Windows.Forms.Label()
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
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblRefNo.Location = New System.Drawing.Point(28, 126)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(203, 44)
        Me.lblRefNo.TabIndex = 4
        Me.lblRefNo.Text = "Reference No:"
        '
        'txtRefNo
        '
        Me.txtRefNo.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.txtRefNo.Location = New System.Drawing.Point(295, 126)
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(296, 45)
        Me.txtRefNo.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(350, 328)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(182, 52)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "CANCEL [Esc]"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(151, 328)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(164, 52)
        Me.btnPay.TabIndex = 9
        Me.btnPay.Text = "PAY [ENTER]"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'txtGCashNo
        '
        Me.txtGCashNo.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.txtGCashNo.Location = New System.Drawing.Point(295, 194)
        Me.txtGCashNo.Name = "txtGCashNo"
        Me.txtGCashNo.Size = New System.Drawing.Size(296, 45)
        Me.txtGCashNo.TabIndex = 12
        '
        'lblGCashNo
        '
        Me.lblGCashNo.AutoSize = True
        Me.lblGCashNo.Font = New System.Drawing.Font("Poppins Medium", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblGCashNo.Location = New System.Drawing.Point(28, 194)
        Me.lblGCashNo.Name = "lblGCashNo"
        Me.lblGCashNo.Size = New System.Drawing.Size(217, 44)
        Me.lblGCashNo.TabIndex = 11
        Me.lblGCashNo.Text = "GCash # used:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins Medium", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(30, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(654, 36)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "MAKE SURE THE TOTAL AMT AND CONFIRMATION IS THE SAME"
        '
        'frm_GCash
        '
        Me.AcceptButton = Me.btnPay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(712, 412)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGCashNo)
        Me.Controls.Add(Me.lblGCashNo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtRefNo)
        Me.Controls.Add(Me.lblRefNo)
        Me.Controls.Add(Me.lblTotalDue)
        Me.Controls.Add(Me.lblTotalDueText)
        Me.Font = New System.Drawing.Font("Segoe UI Variable Display", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_GCash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GCASH PAYMENT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotalDue As Label
    Friend WithEvents lblTotalDueText As Label
    Friend WithEvents lblRefNo As Label
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents txtGCashNo As TextBox
    Friend WithEvents lblGCashNo As Label
    Friend WithEvents Label1 As Label
End Class
