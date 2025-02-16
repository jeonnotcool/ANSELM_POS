<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClearQuery = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblStatusText = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.btnGCash = New System.Windows.Forms.Button()
        Me.btnCompleteTransaction = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTrans = New System.Windows.Forms.Label()
        Me.btnVoidItem = New System.Windows.Forms.Button()
        Me.btnNewTransaction = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvTransaction = New System.Windows.Forms.DataGridView()
        Me.colProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTransID = New System.Windows.Forms.Label()
        Me.lblRoleText = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblLoginAsText = New System.Windows.Forms.Label()
        Me.lblLoginText = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.GroupBox1, 0, 1)
        Me.tlpMain.Controls.Add(Me.GroupBox2, 0, 0)
        Me.tlpMain.Controls.Add(Me.GroupBox3, 1, 1)
        Me.tlpMain.Controls.Add(Me.GroupBox4, 1, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(1996, 1102)
        Me.tlpMain.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnClearQuery)
        Me.GroupBox1.Controls.Add(Me.btnLogout)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvProduct)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 809)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(46, 695)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(187, 49)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "CLOSE [F11]"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.Label8.Location = New System.Drawing.Point(26, 545)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(461, 39)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "PRESS F3 TO FOCUS ON THE TRANSACTION"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.Label7.Location = New System.Drawing.Point(26, 497)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(428, 39)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "PRESS F2 TO FOCUS ON THE PRODUCTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.Label2.Location = New System.Drawing.Point(17, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(485, 39)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Products [PRESS F6 TO FOCUS SEARCH BOX]"
        '
        'btnClearQuery
        '
        Me.btnClearQuery.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearQuery.Location = New System.Drawing.Point(465, 74)
        Me.btnClearQuery.Name = "btnClearQuery"
        Me.btnClearQuery.Size = New System.Drawing.Size(187, 49)
        Me.btnClearQuery.TabIndex = 21
        Me.btnClearQuery.Text = "CLEAR [F5]"
        Me.btnClearQuery.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(285, 695)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(187, 49)
        Me.btnLogout.TabIndex = 21
        Me.btnLogout.Text = "LOGOUT [F12]"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 39)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Search:"
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductID, Me.ProductName, Me.Price, Me.Category, Me.StockQuantity})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Poppins", 7.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProduct.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProduct.Location = New System.Drawing.Point(24, 145)
        Me.dgvProduct.MultiSelect = False
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersWidth = 51
        Me.dgvProduct.RowTemplate.Height = 24
        Me.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduct.Size = New System.Drawing.Size(614, 300)
        Me.dgvProduct.TabIndex = 16
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "Product ID"
        Me.ProductID.MinimumWidth = 6
        Me.ProductID.Name = "ProductID"
        Me.ProductID.ReadOnly = True
        Me.ProductID.Visible = False
        Me.ProductID.Width = 125
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Name"
        Me.ProductName.MinimumWidth = 6
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        Me.ProductName.Width = 125
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 125
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.MinimumWidth = 6
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        Me.Category.Width = 125
        '
        'StockQuantity
        '
        Me.StockQuantity.HeaderText = "Stock"
        Me.StockQuantity.MinimumWidth = 6
        Me.StockQuantity.Name = "StockQuantity"
        Me.StockQuantity.ReadOnly = True
        Me.StockQuantity.Width = 125
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI Variable Display", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(134, 77)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(303, 41)
        Me.txtSearch.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Poppins", 1.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(677, 132)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ANSELM_POS_FINAL.My.Resources.Resources.Black_And_White_Aesthetic_Minimalist_Modern_Simple_Typography_Coconut_Cosmetics_Logo__350_x_100_px_
        Me.PictureBox1.Location = New System.Drawing.Point(24, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(281, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblStatusText)
        Me.GroupBox3.Controls.Add(Me.lblStatus)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.dgvTransaction)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Poppins", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(686, 141)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1307, 958)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'lblStatusText
        '
        Me.lblStatusText.AutoSize = True
        Me.lblStatusText.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.lblStatusText.Location = New System.Drawing.Point(130, 455)
        Me.lblStatusText.Name = "lblStatusText"
        Me.lblStatusText.Size = New System.Drawing.Size(116, 39)
        Me.lblStatusText.TabIndex = 27
        Me.lblStatusText.Text = "NOT PAID"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.lblStatus.Location = New System.Drawing.Point(33, 455)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(91, 39)
        Me.lblStatus.TabIndex = 26
        Me.lblStatus.Text = "Status:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.Label9.Location = New System.Drawing.Point(33, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(377, 39)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Transaction [PRESS F3 TO FOCUS]"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblPayment)
        Me.Panel2.Controls.Add(Me.btnGCash)
        Me.Panel2.Controls.Add(Me.btnCompleteTransaction)
        Me.Panel2.Location = New System.Drawing.Point(879, 423)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(287, 386)
        Me.Panel2.TabIndex = 19
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.lblPayment.Location = New System.Drawing.Point(24, 23)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(120, 39)
        Me.lblPayment.TabIndex = 21
        Me.lblPayment.Text = "PAYMENT:"
        '
        'btnGCash
        '
        Me.btnGCash.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGCash.Location = New System.Drawing.Point(31, 221)
        Me.btnGCash.Name = "btnGCash"
        Me.btnGCash.Size = New System.Drawing.Size(217, 127)
        Me.btnGCash.TabIndex = 6
        Me.btnGCash.Text = "GCASH [F9]"
        Me.btnGCash.UseVisualStyleBackColor = True
        '
        'btnCompleteTransaction
        '
        Me.btnCompleteTransaction.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteTransaction.Location = New System.Drawing.Point(31, 74)
        Me.btnCompleteTransaction.Name = "btnCompleteTransaction"
        Me.btnCompleteTransaction.Size = New System.Drawing.Size(217, 129)
        Me.btnCompleteTransaction.TabIndex = 5
        Me.btnCompleteTransaction.Text = "CASH [F8]"
        Me.btnCompleteTransaction.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblTrans)
        Me.Panel1.Controls.Add(Me.btnVoidItem)
        Me.Panel1.Controls.Add(Me.btnNewTransaction)
        Me.Panel1.Location = New System.Drawing.Point(40, 536)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 273)
        Me.Panel1.TabIndex = 18
        '
        'lblTrans
        '
        Me.lblTrans.AutoSize = True
        Me.lblTrans.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.lblTrans.Location = New System.Drawing.Point(24, 19)
        Me.lblTrans.Name = "lblTrans"
        Me.lblTrans.Size = New System.Drawing.Size(275, 39)
        Me.lblTrans.TabIndex = 20
        Me.lblTrans.Text = "TRANSACTION SETTINGS:"
        '
        'btnVoidItem
        '
        Me.btnVoidItem.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoidItem.Location = New System.Drawing.Point(245, 122)
        Me.btnVoidItem.Name = "btnVoidItem"
        Me.btnVoidItem.Size = New System.Drawing.Size(160, 49)
        Me.btnVoidItem.TabIndex = 4
        Me.btnVoidItem.Text = "VOID [F4]"
        Me.btnVoidItem.UseVisualStyleBackColor = True
        '
        'btnNewTransaction
        '
        Me.btnNewTransaction.Font = New System.Drawing.Font("Segoe UI Variable Display", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewTransaction.Location = New System.Drawing.Point(31, 122)
        Me.btnNewTransaction.Name = "btnNewTransaction"
        Me.btnNewTransaction.Size = New System.Drawing.Size(187, 49)
        Me.btnNewTransaction.TabIndex = 3
        Me.btnNewTransaction.Text = "NEW TXN [F1]"
        Me.btnNewTransaction.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 39)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Poppins", 13.0!)
        Me.lblTotal.Location = New System.Drawing.Point(124, 406)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 39)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.Text = "₱0.00"
        '
        'dgvTransaction
        '
        Me.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaction.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colProductName, Me.colQuantity, Me.colPrice, Me.colSubtotal})
        Me.dgvTransaction.Location = New System.Drawing.Point(120, 95)
        Me.dgvTransaction.Name = "dgvTransaction"
        Me.dgvTransaction.RowHeadersWidth = 80
        Me.dgvTransaction.RowTemplate.Height = 24
        Me.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransaction.Size = New System.Drawing.Size(746, 276)
        Me.dgvTransaction.TabIndex = 13
        '
        'colProductName
        '
        Me.colProductName.HeaderText = "Item"
        Me.colProductName.MinimumWidth = 6
        Me.colProductName.Name = "colProductName"
        Me.colProductName.ReadOnly = True
        Me.colProductName.Width = 125
        '
        'colQuantity
        '
        Me.colQuantity.HeaderText = "Qty"
        Me.colQuantity.MinimumWidth = 6
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.ReadOnly = True
        Me.colQuantity.Width = 125
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.MinimumWidth = 6
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        Me.colPrice.Width = 125
        '
        'colSubtotal
        '
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.MinimumWidth = 6
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.ReadOnly = True
        Me.colSubtotal.Width = 125
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTransID)
        Me.GroupBox4.Controls.Add(Me.lblRoleText)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lblLoginAsText)
        Me.GroupBox4.Controls.Add(Me.lblLoginText)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 1.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(686, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1307, 132)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        '
        'lblTransID
        '
        Me.lblTransID.AutoSize = True
        Me.lblTransID.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.lblTransID.Location = New System.Drawing.Point(215, 16)
        Me.lblTransID.Name = "lblTransID"
        Me.lblTransID.Size = New System.Drawing.Size(122, 44)
        Me.lblTransID.TabIndex = 20
        Me.lblTransID.Text = "TRANSID"
        '
        'lblRoleText
        '
        Me.lblRoleText.AutoSize = True
        Me.lblRoleText.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.lblRoleText.Location = New System.Drawing.Point(727, 66)
        Me.lblRoleText.Name = "lblRoleText"
        Me.lblRoleText.Size = New System.Drawing.Size(65, 44)
        Me.lblRoleText.TabIndex = 23
        Me.lblRoleText.Text = "role"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(511, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 44)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "ROLE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 44)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Transaction ID:"
        '
        'lblLoginAsText
        '
        Me.lblLoginAsText.AutoSize = True
        Me.lblLoginAsText.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.lblLoginAsText.Location = New System.Drawing.Point(727, 16)
        Me.lblLoginAsText.Name = "lblLoginAsText"
        Me.lblLoginAsText.Size = New System.Drawing.Size(72, 44)
        Me.lblLoginAsText.TabIndex = 21
        Me.lblLoginAsText.Text = "user"
        '
        'lblLoginText
        '
        Me.lblLoginText.AutoSize = True
        Me.lblLoginText.Font = New System.Drawing.Font("Poppins", 15.0!)
        Me.lblLoginText.Location = New System.Drawing.Point(511, 16)
        Me.lblLoginText.Name = "lblLoginText"
        Me.lblLoginText.Size = New System.Drawing.Size(194, 44)
        Me.lblLoginText.TabIndex = 20
        Me.lblLoginText.Text = "LOGGED IN AS:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1996, 1102)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tlpMain.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvTransaction As DataGridView
    Friend WithEvents colProductName As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvProduct As DataGridView
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents StockQuantity As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCompleteTransaction As Button
    Friend WithEvents btnVoidItem As Button
    Friend WithEvents btnNewTransaction As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblTransID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblPayment As Label
    Friend WithEvents btnGCash As Button
    Friend WithEvents lblTrans As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblRoleText As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblLoginAsText As Label
    Friend WithEvents lblLoginText As Label
    Friend WithEvents btnClearQuery As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblStatusText As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnClose As Button
End Class
