<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restockaddorder
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
        Me.stocktb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.recdate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.exdate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.supplier = New System.Windows.Forms.ComboBox()
        Me.nametb = New System.Windows.Forms.Label()
        Me.idtb = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnQuit = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddsupp = New System.Windows.Forms.Button()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'stocktb
        '
        Me.stocktb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.stocktb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stocktb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.stocktb.ForeColor = System.Drawing.Color.White
        Me.stocktb.Location = New System.Drawing.Point(141, 222)
        Me.stocktb.Margin = New System.Windows.Forms.Padding(4)
        Me.stocktb.Name = "stocktb"
        Me.stocktb.Size = New System.Drawing.Size(397, 41)
        Me.stocktb.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(55, 222)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 30)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Stock:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(7, 286)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(132, 30)
        Me.Label27.TabIndex = 92
        Me.Label27.Text = "Rec Date:"
        '
        'recdate
        '
        Me.recdate.CustomFormat = "yyyy/MM/dd"
        Me.recdate.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.recdate.Location = New System.Drawing.Point(141, 286)
        Me.recdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recdate.Name = "recdate"
        Me.recdate.Size = New System.Drawing.Size(355, 41)
        Me.recdate.TabIndex = 93
        Me.recdate.Value = New Date(2021, 4, 9, 15, 56, 46, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(29, 350)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 30)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "Ex Date:"
        '
        'exdate
        '
        Me.exdate.CustomFormat = "yyyy/MM/dd"
        Me.exdate.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.exdate.Location = New System.Drawing.Point(141, 350)
        Me.exdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exdate.Name = "exdate"
        Me.exdate.Size = New System.Drawing.Size(355, 41)
        Me.exdate.TabIndex = 179
        Me.exdate.Value = New Date(2021, 4, 9, 15, 56, 46, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(29, 414)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 30)
        Me.Label11.TabIndex = 180
        Me.Label11.Text = "Supplier:"
        '
        'supplier
        '
        Me.supplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supplier.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supplier.ForeColor = System.Drawing.Color.White
        Me.supplier.FormattingEnabled = True
        Me.supplier.Location = New System.Drawing.Point(141, 414)
        Me.supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.supplier.Name = "supplier"
        Me.supplier.Size = New System.Drawing.Size(253, 38)
        Me.supplier.TabIndex = 183
        '
        'nametb
        '
        Me.nametb.AutoSize = True
        Me.nametb.BackColor = System.Drawing.Color.Transparent
        Me.nametb.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nametb.ForeColor = System.Drawing.Color.White
        Me.nametb.Location = New System.Drawing.Point(143, 68)
        Me.nametb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nametb.Name = "nametb"
        Me.nametb.Size = New System.Drawing.Size(21, 30)
        Me.nametb.TabIndex = 192
        Me.nametb.Text = "-"
        '
        'idtb
        '
        Me.idtb.AutoSize = True
        Me.idtb.BackColor = System.Drawing.Color.Transparent
        Me.idtb.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtb.ForeColor = System.Drawing.Color.White
        Me.idtb.Location = New System.Drawing.Point(143, 15)
        Me.idtb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.idtb.Name = "idtb"
        Me.idtb.Size = New System.Drawing.Size(21, 30)
        Me.idtb.TabIndex = 193
        Me.idtb.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(41, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 30)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(17, 16)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 30)
        Me.Label18.TabIndex = 191
        Me.Label18.Text = "Order ID:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 48)
        Me.Panel1.TabIndex = 194
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
        Me.btnQuit.IconSize = 28
        Me.btnQuit.Location = New System.Drawing.Point(539, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(32, 32)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Restock Add Order"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.nametb)
        Me.Panel2.Controls.Add(Me.idtb)
        Me.Panel2.Location = New System.Drawing.Point(17, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(521, 124)
        Me.Panel2.TabIndex = 195
        '
        'btnAddsupp
        '
        Me.btnAddsupp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddsupp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddsupp.FlatAppearance.BorderSize = 0
        Me.btnAddsupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddsupp.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddsupp.ForeColor = System.Drawing.Color.Black
        Me.btnAddsupp.Location = New System.Drawing.Point(401, 414)
        Me.btnAddsupp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddsupp.Name = "btnAddsupp"
        Me.btnAddsupp.Size = New System.Drawing.Size(156, 44)
        Me.btnAddsupp.TabIndex = 196
        Me.btnAddsupp.Text = "Add Supplier"
        Me.btnAddsupp.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(359, 469)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(198, 64)
        Me.btnSave.TabIndex = 197
        Me.btnSave.Text = "Insert Data"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'restockaddorder
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 545)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAddsupp)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.supplier)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.exdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.recdate)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.stocktb)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "restockaddorder"
        Me.Text = "restockaddorder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stocktb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents recdate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents exdate As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents supplier As ComboBox
    Friend WithEvents nametb As Label
    Friend WithEvents idtb As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnQuit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddsupp As Button
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
End Class
