<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class newitem
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
        Me.suppliertb = New System.Windows.Forms.ComboBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.idate2 = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.idate = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.iidtb = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.iratetb = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.inametb = New System.Windows.Forms.TextBox()
        Me.idesctb = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ipricetb = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.istocktb = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnQuit = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.weightAbv = New System.Windows.Forms.ComboBox()
        Me.unittb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.weightN = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'suppliertb
        '
        Me.suppliertb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.suppliertb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.suppliertb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.suppliertb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.suppliertb.ForeColor = System.Drawing.Color.White
        Me.suppliertb.FormattingEnabled = True
        Me.suppliertb.Location = New System.Drawing.Point(710, 353)
        Me.suppliertb.Margin = New System.Windows.Forms.Padding(4)
        Me.suppliertb.Name = "suppliertb"
        Me.suppliertb.Size = New System.Drawing.Size(253, 41)
        Me.suppliertb.TabIndex = 95
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(970, 350)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(156, 44)
        Me.Button9.TabIndex = 96
        Me.Button9.Text = "Add Supplier"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(103, 405)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(65, 30)
        Me.Label29.TabIndex = 93
        Me.Label29.Text = "Unit:"
        '
        'idate2
        '
        Me.idate2.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.idate2.Location = New System.Drawing.Point(710, 291)
        Me.idate2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.idate2.Name = "idate2"
        Me.idate2.Size = New System.Drawing.Size(365, 41)
        Me.idate2.TabIndex = 91
        Me.idate2.Value = New Date(2021, 4, 9, 15, 56, 32, 0)
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(595, 291)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(110, 30)
        Me.Label28.TabIndex = 90
        Me.Label28.Text = "Ex Date:"
        '
        'idate
        '
        Me.idate.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.idate.Location = New System.Drawing.Point(710, 224)
        Me.idate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.idate.Name = "idate"
        Me.idate.Size = New System.Drawing.Size(365, 41)
        Me.idate.TabIndex = 91
        Me.idate.Value = New Date(2021, 4, 9, 15, 56, 32, 0)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(577, 225)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(132, 30)
        Me.Label26.TabIndex = 90
        Me.Label26.Text = "Rec Date:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(63, 89)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 30)
        Me.Label24.TabIndex = 87
        Me.Label24.Text = "Item ID:"
        '
        'iidtb
        '
        Me.iidtb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.iidtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.iidtb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.iidtb.ForeColor = System.Drawing.Color.White
        Me.iidtb.Location = New System.Drawing.Point(170, 89)
        Me.iidtb.Margin = New System.Windows.Forms.Padding(4)
        Me.iidtb.Name = "iidtb"
        Me.iidtb.ReadOnly = True
        Me.iidtb.Size = New System.Drawing.Size(395, 41)
        Me.iidtb.TabIndex = 88
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(13, 152)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 30)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "Item Name:"
        '
        'iratetb
        '
        Me.iratetb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.iratetb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.iratetb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.iratetb.ForeColor = System.Drawing.Color.White
        Me.iratetb.Location = New System.Drawing.Point(710, 159)
        Me.iratetb.Margin = New System.Windows.Forms.Padding(4)
        Me.iratetb.Name = "iratetb"
        Me.iratetb.Size = New System.Drawing.Size(416, 41)
        Me.iratetb.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(14, 225)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(154, 30)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Description:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(592, 159)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(117, 30)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Servings:"
        '
        'inametb
        '
        Me.inametb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.inametb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inametb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.inametb.ForeColor = System.Drawing.Color.White
        Me.inametb.Location = New System.Drawing.Point(171, 152)
        Me.inametb.Margin = New System.Windows.Forms.Padding(4)
        Me.inametb.Name = "inametb"
        Me.inametb.Size = New System.Drawing.Size(395, 41)
        Me.inametb.TabIndex = 48
        '
        'idesctb
        '
        Me.idesctb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idesctb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idesctb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.idesctb.ForeColor = System.Drawing.Color.White
        Me.idesctb.Location = New System.Drawing.Point(171, 220)
        Me.idesctb.Margin = New System.Windows.Forms.Padding(4)
        Me.idesctb.Multiline = True
        Me.idesctb.Name = "idesctb"
        Me.idesctb.Size = New System.Drawing.Size(396, 96)
        Me.idesctb.TabIndex = 52
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(89, 338)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 30)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Price:"
        '
        'ipricetb
        '
        Me.ipricetb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ipricetb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ipricetb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.ipricetb.ForeColor = System.Drawing.Color.White
        Me.ipricetb.Location = New System.Drawing.Point(173, 338)
        Me.ipricetb.Margin = New System.Windows.Forms.Padding(4)
        Me.ipricetb.Name = "ipricetb"
        Me.ipricetb.Size = New System.Drawing.Size(395, 41)
        Me.ipricetb.TabIndex = 49
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(595, 350)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(114, 30)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Supplier:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(647, 89)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 30)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Qty."
        '
        'istocktb
        '
        Me.istocktb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.istocktb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.istocktb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.istocktb.ForeColor = System.Drawing.Color.White
        Me.istocktb.Location = New System.Drawing.Point(710, 89)
        Me.istocktb.Margin = New System.Windows.Forms.Padding(4)
        Me.istocktb.Name = "istocktb"
        Me.istocktb.Size = New System.Drawing.Size(416, 41)
        Me.istocktb.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1146, 60)
        Me.Panel1.TabIndex = 191
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(13, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 34)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "New Item"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnSave.Location = New System.Drawing.Point(928, 462)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(198, 64)
        Me.btnSave.TabIndex = 195
        Me.btnSave.Text = "Insert Data"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'weightAbv
        '
        Me.weightAbv.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.weightAbv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.weightAbv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.weightAbv.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.weightAbv.ForeColor = System.Drawing.Color.White
        Me.weightAbv.FormattingEnabled = True
        Me.weightAbv.Items.AddRange(New Object() {"kg", "L", "ml", "oz", "lb", "mg", "g", "t", "tsp", "tbsp", "c", "gal", "qt"})
        Me.weightAbv.Location = New System.Drawing.Point(229, 472)
        Me.weightAbv.Margin = New System.Windows.Forms.Padding(4)
        Me.weightAbv.Name = "weightAbv"
        Me.weightAbv.Size = New System.Drawing.Size(159, 41)
        Me.weightAbv.TabIndex = 196
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
        Me.unittb.Location = New System.Drawing.Point(173, 405)
        Me.unittb.Margin = New System.Windows.Forms.Padding(4)
        Me.unittb.Name = "unittb"
        Me.unittb.Size = New System.Drawing.Size(392, 41)
        Me.unittb.TabIndex = 197
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 471)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 30)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "Weight:"
        '
        'weightN
        '
        Me.weightN.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.weightN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.weightN.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.weightN.ForeColor = System.Drawing.Color.White
        Me.weightN.Location = New System.Drawing.Point(171, 472)
        Me.weightN.Margin = New System.Windows.Forms.Padding(4)
        Me.weightN.Name = "weightN"
        Me.weightN.Size = New System.Drawing.Size(50, 41)
        Me.weightN.TabIndex = 199
        '
        'newitem
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
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.suppliertb)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.iidtb)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.inametb)
        Me.Controls.Add(Me.istocktb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.idesctb)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.idate2)
        Me.Controls.Add(Me.ipricetb)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.iratetb)
        Me.Controls.Add(Me.idate)
        Me.Controls.Add(Me.Label26)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "newitem"
        Me.Text = "newitem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label29 As Label
    Friend WithEvents idate2 As DateTimePicker
    Friend WithEvents Label28 As Label
    Friend WithEvents idate As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents iidtb As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents iratetb As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents inametb As TextBox
    Friend WithEvents idesctb As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ipricetb As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents istocktb As TextBox
    Friend WithEvents suppliertb As ComboBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnQuit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents weightAbv As ComboBox
    Friend WithEvents unittb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents weightN As TextBox
End Class
