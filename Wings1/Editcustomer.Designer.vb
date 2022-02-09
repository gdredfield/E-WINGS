<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editcustomer
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
        Me.addresstb = New System.Windows.Forms.RichTextBox()
        Me.emailtb = New System.Windows.Forms.TextBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.baranggaytb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnametb = New System.Windows.Forms.TextBox()
        Me.fnametb = New System.Windows.Forms.TextBox()
        Me.citytb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.labelll = New System.Windows.Forms.Label()
        Me.ziptb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.idtb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnQuit = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addresstb
        '
        Me.addresstb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.addresstb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.addresstb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.addresstb.ForeColor = System.Drawing.Color.White
        Me.addresstb.Location = New System.Drawing.Point(169, 220)
        Me.addresstb.Name = "addresstb"
        Me.addresstb.Size = New System.Drawing.Size(396, 96)
        Me.addresstb.TabIndex = 108
        Me.addresstb.Text = ""
        '
        'emailtb
        '
        Me.emailtb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.emailtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailtb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.emailtb.ForeColor = System.Drawing.Color.White
        Me.emailtb.Location = New System.Drawing.Point(168, 518)
        Me.emailtb.Margin = New System.Windows.Forms.Padding(4)
        Me.emailtb.Name = "emailtb"
        Me.emailtb.Size = New System.Drawing.Size(395, 41)
        Me.emailtb.TabIndex = 99
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.label21.ForeColor = System.Drawing.Color.White
        Me.label21.Location = New System.Drawing.Point(22, 95)
        Me.label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(144, 30)
        Me.label21.TabIndex = 90
        Me.label21.Text = "First Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(22, 157)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(146, 30)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Last Name:"
        '
        'baranggaytb
        '
        Me.baranggaytb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.baranggaytb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.baranggaytb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.baranggaytb.ForeColor = System.Drawing.Color.White
        Me.baranggaytb.Location = New System.Drawing.Point(169, 335)
        Me.baranggaytb.Margin = New System.Windows.Forms.Padding(4)
        Me.baranggaytb.Name = "baranggaytb"
        Me.baranggaytb.Size = New System.Drawing.Size(395, 41)
        Me.baranggaytb.TabIndex = 96
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 518)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 30)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 457)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 30)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Zip code:"
        '
        'lnametb
        '
        Me.lnametb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnametb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lnametb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.lnametb.ForeColor = System.Drawing.Color.White
        Me.lnametb.Location = New System.Drawing.Point(169, 157)
        Me.lnametb.Margin = New System.Windows.Forms.Padding(4)
        Me.lnametb.Name = "lnametb"
        Me.lnametb.Size = New System.Drawing.Size(395, 41)
        Me.lnametb.TabIndex = 94
        '
        'fnametb
        '
        Me.fnametb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fnametb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fnametb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.fnametb.ForeColor = System.Drawing.Color.White
        Me.fnametb.Location = New System.Drawing.Point(170, 95)
        Me.fnametb.Margin = New System.Windows.Forms.Padding(4)
        Me.fnametb.Name = "fnametb"
        Me.fnametb.Size = New System.Drawing.Size(395, 41)
        Me.fnametb.TabIndex = 93
        '
        'citytb
        '
        Me.citytb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.citytb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.citytb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.citytb.ForeColor = System.Drawing.Color.White
        Me.citytb.Location = New System.Drawing.Point(169, 397)
        Me.citytb.Margin = New System.Windows.Forms.Padding(4)
        Me.citytb.Name = "citytb"
        Me.citytb.Size = New System.Drawing.Size(395, 41)
        Me.citytb.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 335)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 30)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Barangay:"
        '
        'labelll
        '
        Me.labelll.AutoSize = True
        Me.labelll.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.labelll.ForeColor = System.Drawing.Color.White
        Me.labelll.Location = New System.Drawing.Point(53, 220)
        Me.labelll.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelll.Name = "labelll"
        Me.labelll.Size = New System.Drawing.Size(112, 30)
        Me.labelll.TabIndex = 105
        Me.labelll.Text = "Address:"
        '
        'ziptb
        '
        Me.ziptb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ziptb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ziptb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.ziptb.ForeColor = System.Drawing.Color.White
        Me.ziptb.Location = New System.Drawing.Point(168, 457)
        Me.ziptb.Margin = New System.Windows.Forms.Padding(4)
        Me.ziptb.Name = "ziptb"
        Me.ziptb.Size = New System.Drawing.Size(395, 41)
        Me.ziptb.TabIndex = 98
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(101, 397)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 30)
        Me.Label12.TabIndex = 102
        Me.Label12.Text = "City:"
        '
        'idtb
        '
        Me.idtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idtb.Location = New System.Drawing.Point(512, 58)
        Me.idtb.Margin = New System.Windows.Forms.Padding(4)
        Me.idtb.Name = "idtb"
        Me.idtb.ReadOnly = True
        Me.idtb.Size = New System.Drawing.Size(116, 26)
        Me.idtb.TabIndex = 111
        Me.idtb.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 34)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Edit Customer"
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
        Me.Panel1.Size = New System.Drawing.Size(583, 50)
        Me.Panel1.TabIndex = 111
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
        Me.btnQuit.Location = New System.Drawing.Point(539, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(32, 32)
        Me.btnQuit.TabIndex = 184
        Me.btnQuit.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(355, 577)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(208, 64)
        Me.btnSave.TabIndex = 113
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Editcustomer
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(583, 662)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.addresstb)
        Me.Controls.Add(Me.idtb)
        Me.Controls.Add(Me.emailtb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.label21)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.baranggaytb)
        Me.Controls.Add(Me.ziptb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelll)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lnametb)
        Me.Controls.Add(Me.citytb)
        Me.Controls.Add(Me.fnametb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Editcustomer"
        Me.Text = "Editcustomer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents baranggaytb As TextBox
    Friend WithEvents lnametb As TextBox
    Friend WithEvents fnametb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents idtb As TextBox
    Friend WithEvents addresstb As RichTextBox
    Friend WithEvents emailtb As TextBox
    Friend WithEvents label21 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents citytb As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents labelll As Label
    Friend WithEvents ziptb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnQuit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnSave As Button
End Class
