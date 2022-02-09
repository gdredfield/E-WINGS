<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseOrderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrderForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.sortcb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.searchbox = New System.Windows.Forms.TextBox()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.btnAddtoInv = New FontAwesome.Sharp.IconButton()
        Me.btnRestock = New FontAwesome.Sharp.IconButton()
        Me.btnHistory = New FontAwesome.Sharp.IconButton()
        Me.searchcb = New System.Windows.Forms.ComboBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtgporder = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New FontAwesome.Sharp.IconPictureBox()
        Me.btnEdit = New FontAwesome.Sharp.IconPictureBox()
        Me.btnDelete = New FontAwesome.Sharp.IconPictureBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel13.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgporder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sortcb
        '
        Me.sortcb.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.sortcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sortcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sortcb.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sortcb.ForeColor = System.Drawing.Color.Gainsboro
        Me.sortcb.FormattingEnabled = True
        Me.sortcb.Items.AddRange(New Object() {"Default", "Name", "Price", "Stock", "RecDate", "ExDate", "Supplier"})
        Me.sortcb.Location = New System.Drawing.Point(203, 66)
        Me.sortcb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sortcb.Name = "sortcb"
        Me.sortcb.Size = New System.Drawing.Size(192, 35)
        Me.sortcb.TabIndex = 113
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(143, 67)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 25)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Sort:"
        '
        'searchbox
        '
        Me.searchbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.searchbox.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox.ForeColor = System.Drawing.Color.White
        Me.searchbox.Location = New System.Drawing.Point(1023, 66)
        Me.searchbox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(160, 33)
        Me.searchbox.TabIndex = 112
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel13.Controls.Add(Me.btnAddtoInv)
        Me.Panel13.Controls.Add(Me.btnRestock)
        Me.Panel13.Controls.Add(Me.btnHistory)
        Me.Panel13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(0, 694)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1242, 68)
        Me.Panel13.TabIndex = 185
        '
        'btnAddtoInv
        '
        Me.btnAddtoInv.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAddtoInv.FlatAppearance.BorderSize = 0
        Me.btnAddtoInv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddtoInv.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoInv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAddtoInv.IconChar = FontAwesome.Sharp.IconChar.Dolly
        Me.btnAddtoInv.IconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAddtoInv.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAddtoInv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddtoInv.Location = New System.Drawing.Point(986, 9)
        Me.btnAddtoInv.Name = "btnAddtoInv"
        Me.btnAddtoInv.Size = New System.Drawing.Size(244, 49)
        Me.btnAddtoInv.TabIndex = 137
        Me.btnAddtoInv.Text = "Add to Inventory"
        Me.btnAddtoInv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddtoInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddtoInv.UseVisualStyleBackColor = False
        '
        'btnRestock
        '
        Me.btnRestock.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRestock.FlatAppearance.BorderSize = 0
        Me.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRestock.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnRestock.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown
        Me.btnRestock.IconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnRestock.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRestock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestock.Location = New System.Drawing.Point(833, 9)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(145, 49)
        Me.btnRestock.TabIndex = 136
        Me.btnRestock.Text = "Restock"
        Me.btnRestock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRestock.UseVisualStyleBackColor = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnHistory.IconChar = FontAwesome.Sharp.IconChar.History
        Me.btnHistory.IconColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnHistory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.Location = New System.Drawing.Point(11, 9)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(145, 49)
        Me.btnHistory.TabIndex = 135
        Me.btnHistory.Text = "History"
        Me.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'searchcb
        '
        Me.searchcb.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.searchcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchcb.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchcb.ForeColor = System.Drawing.Color.Gainsboro
        Me.searchcb.FormattingEnabled = True
        Me.searchcb.Items.AddRange(New Object() {"ID", "Name", "Price", "Stocks", "RecDate", "ExDate", "Supplier"})
        Me.searchcb.Location = New System.Drawing.Point(916, 66)
        Me.searchcb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.searchcb.Name = "searchcb"
        Me.searchcb.Size = New System.Drawing.Size(99, 35)
        Me.searchcb.TabIndex = 188
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel12.Controls.Add(Me.Label21)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(1242, 55)
        Me.Panel12.TabIndex = 189
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(2, 15)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(1236, 30)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "Orders"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1183, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 190
        Me.PictureBox1.TabStop = False
        '
        'dtgporder
        '
        Me.dtgporder.AllowUserToAddRows = False
        Me.dtgporder.AllowUserToDeleteRows = False
        Me.dtgporder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtgporder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dtgporder.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.dtgporder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgporder.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgporder.ColumnHeadersHeight = 42
        Me.dtgporder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgporder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgporder.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgporder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtgporder.EnableHeadersVisualStyles = False
        Me.dtgporder.GridColor = System.Drawing.Color.DimGray
        Me.dtgporder.Location = New System.Drawing.Point(0, 104)
        Me.dtgporder.MultiSelect = False
        Me.dtgporder.Name = "dtgporder"
        Me.dtgporder.ReadOnly = True
        Me.dtgporder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgporder.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dtgporder.RowHeadersVisible = False
        Me.dtgporder.RowHeadersWidth = 55
        Me.dtgporder.RowTemplate.Height = 24
        Me.dtgporder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtgporder.Size = New System.Drawing.Size(1242, 590)
        Me.dtgporder.TabIndex = 191
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.ForeColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare
        Me.btnAdd.IconColor = System.Drawing.Color.LimeGreen
        Me.btnAdd.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnAdd.IconSize = 39
        Me.btnAdd.Location = New System.Drawing.Point(4, 63)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(41, 39)
        Me.btnAdd.TabIndex = 192
        Me.btnAdd.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.ForeColor = System.Drawing.Color.Teal
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEdit.IconColor = System.Drawing.Color.Teal
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 39
        Me.btnEdit.Location = New System.Drawing.Point(51, 60)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(41, 39)
        Me.btnEdit.TabIndex = 193
        Me.btnEdit.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.btnDelete.IconColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDelete.IconSize = 39
        Me.btnDelete.Location = New System.Drawing.Point(98, 61)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(41, 39)
        Me.btnDelete.TabIndex = 194
        Me.btnDelete.TabStop = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "or_id"
        Me.Column1.HeaderText = "ItemID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 101
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "or_name"
        Me.Column2.HeaderText = "ItemName"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 132
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "or_desc"
        Me.Column3.HeaderText = "ItemDescription"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 177
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "or_price"
        Me.Column4.HeaderText = "ItemPrice"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 123
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "or_status"
        Me.Column5.HeaderText = "Status"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 95
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "or_unit"
        Me.Column6.HeaderText = "Unit"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "or_stock"
        Me.Column7.HeaderText = "Quantity"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 115
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "or_rate"
        Me.Column8.HeaderText = "Servings"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 115
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "or_recdate"
        Me.Column9.HeaderText = "RecDate"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 114
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "or_exdate"
        Me.Column10.HeaderText = "ExDate"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 102
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "supplier"
        Me.Column11.HeaderText = "Supplier"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 114
        '
        'PurchaseOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1242, 762)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.dtgporder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.searchcb)
        Me.Controls.Add(Me.sortcb)
        Me.Controls.Add(Me.searchbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PurchaseOrderForm"
        Me.Text = "Purchase Order"
        Me.Panel13.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgporder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sortcb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents searchbox As TextBox
    Friend WithEvents Panel13 As Panel
    Friend WithEvents searchcb As ComboBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtgporder As DataGridView
    Friend WithEvents btnHistory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRestock As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAddtoInv As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAdd As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnEdit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnDelete As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
End Class
