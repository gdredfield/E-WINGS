<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editproduct
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
        Me.prevstock = New System.Windows.Forms.Label()
        Me.typecb = New System.Windows.Forms.ComboBox()
        Me.statuscb = New System.Windows.Forms.ComboBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nametb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pricetb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.idtb = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.stocktb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnQuit = New FontAwesome.Sharp.IconPictureBox()
        Me.desctb = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prevstock
        '
        Me.prevstock.AutoSize = True
        Me.prevstock.Location = New System.Drawing.Point(7, 72)
        Me.prevstock.Name = "prevstock"
        Me.prevstock.Size = New System.Drawing.Size(51, 17)
        Me.prevstock.TabIndex = 174
        Me.prevstock.Text = "Label1"
        Me.prevstock.Visible = False
        '
        'typecb
        '
        Me.typecb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.typecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.typecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.typecb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.typecb.ForeColor = System.Drawing.Color.White
        Me.typecb.FormattingEnabled = True
        Me.typecb.Location = New System.Drawing.Point(210, 390)
        Me.typecb.Margin = New System.Windows.Forms.Padding(4)
        Me.typecb.Name = "typecb"
        Me.typecb.Size = New System.Drawing.Size(272, 41)
        Me.typecb.TabIndex = 86
        '
        'statuscb
        '
        Me.statuscb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.statuscb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.statuscb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.statuscb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.statuscb.ForeColor = System.Drawing.Color.White
        Me.statuscb.FormattingEnabled = True
        Me.statuscb.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.statuscb.Location = New System.Drawing.Point(210, 514)
        Me.statuscb.Margin = New System.Windows.Forms.Padding(4)
        Me.statuscb.Name = "statuscb"
        Me.statuscb.Size = New System.Drawing.Size(272, 41)
        Me.statuscb.TabIndex = 42
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(489, 389)
        Me.Button9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(116, 35)
        Me.Button9.TabIndex = 91
        Me.Button9.Text = "Add"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(15, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 30)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Product Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(54, 224)
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
        Me.nametb.Location = New System.Drawing.Point(211, 144)
        Me.nametb.Margin = New System.Windows.Forms.Padding(4)
        Me.nametb.Name = "nametb"
        Me.nametb.Size = New System.Drawing.Size(395, 41)
        Me.nametb.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(129, 326)
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
        Me.pricetb.Location = New System.Drawing.Point(211, 326)
        Me.pricetb.Margin = New System.Windows.Forms.Padding(4)
        Me.pricetb.Name = "pricetb"
        Me.pricetb.Size = New System.Drawing.Size(395, 41)
        Me.pricetb.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(33, 390)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 30)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Product Type:"
        '
        'idtb
        '
        Me.idtb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.idtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.idtb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.idtb.ForeColor = System.Drawing.Color.White
        Me.idtb.Location = New System.Drawing.Point(211, 82)
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
        Me.Label18.Location = New System.Drawing.Point(65, 82)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(143, 30)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Product ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(145, 453)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 30)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Qty."
        '
        'stocktb
        '
        Me.stocktb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stocktb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stocktb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.stocktb.ForeColor = System.Drawing.Color.White
        Me.stocktb.Location = New System.Drawing.Point(210, 453)
        Me.stocktb.Margin = New System.Windows.Forms.Padding(4)
        Me.stocktb.Name = "stocktb"
        Me.stocktb.Size = New System.Drawing.Size(395, 41)
        Me.stocktb.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(119, 514)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 30)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Status:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(641, 60)
        Me.Panel1.TabIndex = 190
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(13, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 34)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Edit Product"
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
        Me.btnQuit.Location = New System.Drawing.Point(597, 13)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(32, 32)
        Me.btnQuit.TabIndex = 183
        Me.btnQuit.TabStop = False
        '
        'desctb
        '
        Me.desctb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.desctb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desctb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.desctb.ForeColor = System.Drawing.Color.White
        Me.desctb.Location = New System.Drawing.Point(211, 208)
        Me.desctb.Name = "desctb"
        Me.desctb.Size = New System.Drawing.Size(396, 96)
        Me.desctb.TabIndex = 191
        Me.desctb.Text = ""
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.White
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 37
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Location = New System.Drawing.Point(415, 587)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(192, 50)
        Me.btnSave.TabIndex = 192
        Me.btnSave.Text = "Save Data"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'editproduct
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(641, 649)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.desctb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.prevstock)
        Me.Controls.Add(Me.typecb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.stocktb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.statuscb)
        Me.Controls.Add(Me.idtb)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pricetb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.nametb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editproduct"
        Me.Text = "editproduct"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents typecb As ComboBox
    Friend WithEvents statuscb As ComboBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents nametb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pricetb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents idtb As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents stocktb As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents prevstock As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents btnQuit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents desctb As RichTextBox
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
End Class
