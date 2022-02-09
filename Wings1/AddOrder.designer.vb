<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrder
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
        Me.supplier = New System.Windows.Forms.ComboBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.exdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rate = New System.Windows.Forms.TextBox()
        Me.recdate = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nametb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pricetb = New System.Windows.Forms.TextBox()
        Me.idtb = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stocktb = New System.Windows.Forms.TextBox()
        Me.btnQuit = New FontAwesome.Sharp.IconPictureBox()
        Me.desctb = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.weightN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.unittb = New System.Windows.Forms.ComboBox()
        Me.weightAbv = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'supplier
        '
        Me.supplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supplier.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.supplier.ForeColor = System.Drawing.Color.White
        Me.supplier.FormattingEnabled = True
        Me.supplier.Location = New System.Drawing.Point(710, 353)
        Me.supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.supplier.Name = "supplier"
        Me.supplier.Size = New System.Drawing.Size(253, 41)
        Me.supplier.TabIndex = 183
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(970, 350)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(156, 44)
        Me.Button9.TabIndex = 184
        Me.Button9.Text = "Add Supplier"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(595, 353)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 30)
        Me.Label11.TabIndex = 180
        Me.Label11.Text = "Supplier:"
        '
        'exdate
        '
        Me.exdate.CustomFormat = "yyyy/MM/dd"
        Me.exdate.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.exdate.Location = New System.Drawing.Point(710, 291)
        Me.exdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exdate.Name = "exdate"
        Me.exdate.Size = New System.Drawing.Size(365, 41)
        Me.exdate.TabIndex = 179
        Me.exdate.Value = New Date(2021, 4, 9, 15, 56, 46, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(595, 291)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 30)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Ex Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(592, 159)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 30)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Servings:"
        '
        'rate
        '
        Me.rate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rate.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.rate.ForeColor = System.Drawing.Color.White
        Me.rate.Location = New System.Drawing.Point(710, 159)
        Me.rate.Margin = New System.Windows.Forms.Padding(4)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(416, 41)
        Me.rate.TabIndex = 176
        '
        'recdate
        '
        Me.recdate.CustomFormat = "yyyy/MM/dd"
        Me.recdate.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.recdate.Location = New System.Drawing.Point(710, 224)
        Me.recdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recdate.Name = "recdate"
        Me.recdate.Size = New System.Drawing.Size(365, 41)
        Me.recdate.TabIndex = 93
        Me.recdate.Value = New Date(2021, 4, 9, 15, 56, 46, 0)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(577, 225)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(132, 30)
        Me.Label27.TabIndex = 92
        Me.Label27.Text = "Rec Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(74, 152)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 30)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 225)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 30)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Description:"
        '
        'nametb
        '
        Me.nametb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nametb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nametb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.nametb.ForeColor = System.Drawing.Color.White
        Me.nametb.Location = New System.Drawing.Point(171, 152)
        Me.nametb.Margin = New System.Windows.Forms.Padding(4)
        Me.nametb.Name = "nametb"
        Me.nametb.Size = New System.Drawing.Size(394, 41)
        Me.nametb.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(89, 338)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 30)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Price:"
        '
        'pricetb
        '
        Me.pricetb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pricetb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pricetb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.pricetb.ForeColor = System.Drawing.Color.White
        Me.pricetb.Location = New System.Drawing.Point(173, 338)
        Me.pricetb.Margin = New System.Windows.Forms.Padding(4)
        Me.pricetb.Name = "pricetb"
        Me.pricetb.Size = New System.Drawing.Size(395, 41)
        Me.pricetb.TabIndex = 32
        '
        'idtb
        '
        Me.idtb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idtb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.idtb.ForeColor = System.Drawing.Color.White
        Me.idtb.Location = New System.Drawing.Point(170, 89)
        Me.idtb.Margin = New System.Windows.Forms.Padding(4)
        Me.idtb.Name = "idtb"
        Me.idtb.ReadOnly = True
        Me.idtb.Size = New System.Drawing.Size(395, 41)
        Me.idtb.TabIndex = 78
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(52, 90)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 30)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Order ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(621, 90)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 30)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Stock:"
        '
        'stocktb
        '
        Me.stocktb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stocktb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stocktb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.stocktb.ForeColor = System.Drawing.Color.White
        Me.stocktb.Location = New System.Drawing.Point(710, 89)
        Me.stocktb.Margin = New System.Windows.Forms.Padding(4)
        Me.stocktb.Name = "stocktb"
        Me.stocktb.Size = New System.Drawing.Size(416, 41)
        Me.stocktb.TabIndex = 32
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnQuit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnQuit.IconColor = System.Drawing.Color.Gainsboro
        Me.btnQuit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnQuit.Location = New System.Drawing.Point(1094, 13)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(32, 32)
        Me.btnQuit.TabIndex = 88
        Me.btnQuit.TabStop = False
        '
        'desctb
        '
        Me.desctb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.desctb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desctb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.desctb.ForeColor = System.Drawing.Color.White
        Me.desctb.Location = New System.Drawing.Point(171, 220)
        Me.desctb.Name = "desctb"
        Me.desctb.Size = New System.Drawing.Size(396, 96)
        Me.desctb.TabIndex = 185
        Me.desctb.Text = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 37
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(928, 454)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(198, 64)
        Me.btnSave.TabIndex = 186
        Me.btnSave.Text = "Insert Data"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 60)
        Me.Panel1.TabIndex = 189
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(13, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 34)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "New Order"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'weightN
        '
        Me.weightN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.weightN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.weightN.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.weightN.ForeColor = System.Drawing.Color.White
        Me.weightN.Location = New System.Drawing.Point(171, 473)
        Me.weightN.Margin = New System.Windows.Forms.Padding(4)
        Me.weightN.Name = "weightN"
        Me.weightN.Size = New System.Drawing.Size(50, 41)
        Me.weightN.TabIndex = 209
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 472)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 30)
        Me.Label1.TabIndex = 208
        Me.Label1.Text = "Weight:"
        '
        'unittb
        '
        Me.unittb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.unittb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unittb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.unittb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.unittb.ForeColor = System.Drawing.Color.White
        Me.unittb.FormattingEnabled = True
        Me.unittb.Items.AddRange(New Object() {"Pack", "Bottle", "Tray", "Gallon", "Box", "Can", "Tetra Pack", "Jar", "Sachet", "Sack", "Cup", "Glass", "Case", "Drum", "Bucket"})
        Me.unittb.Location = New System.Drawing.Point(173, 406)
        Me.unittb.Margin = New System.Windows.Forms.Padding(4)
        Me.unittb.Name = "unittb"
        Me.unittb.Size = New System.Drawing.Size(392, 41)
        Me.unittb.TabIndex = 207
        '
        'weightAbv
        '
        Me.weightAbv.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.weightAbv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.weightAbv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.weightAbv.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.weightAbv.ForeColor = System.Drawing.Color.White
        Me.weightAbv.FormattingEnabled = True
        Me.weightAbv.Items.AddRange(New Object() {"kg", "L", "ml", "oz", "lb", "pcs", "mg", "g", "t", "tsp", "tbsp", "c", "gal", "qt"})
        Me.weightAbv.Location = New System.Drawing.Point(229, 473)
        Me.weightAbv.Margin = New System.Windows.Forms.Padding(4)
        Me.weightAbv.Name = "weightAbv"
        Me.weightAbv.Size = New System.Drawing.Size(159, 41)
        Me.weightAbv.TabIndex = 206
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(103, 406)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 30)
        Me.Label29.TabIndex = 205
        Me.Label29.Text = "Unit:"
        '
        'AddOrder
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1146, 556)
        Me.Controls.Add(Me.weightN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.unittb)
        Me.Controls.Add(Me.weightAbv)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.desctb)
        Me.Controls.Add(Me.supplier)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.exdate)
        Me.Controls.Add(Me.stocktb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.idtb)
        Me.Controls.Add(Me.pricetb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.recdate)
        Me.Controls.Add(Me.nametb)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddOrder"
        Me.Text = "AddPurchaseOrder"
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents recdate As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nametb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pricetb As TextBox
    Friend WithEvents idtb As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents stocktb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rate As TextBox
    Friend WithEvents exdate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents supplier As ComboBox
    Friend WithEvents Button9 As Button
    Friend WithEvents btnQuit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents desctb As RichTextBox
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents weightN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents unittb As ComboBox
    Friend WithEvents weightAbv As ComboBox
    Friend WithEvents Label29 As Label
End Class
