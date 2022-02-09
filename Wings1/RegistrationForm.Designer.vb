<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cb1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnQuit2 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnQuit = New FontAwesome.Sharp.IconPictureBox()
        Me.cpasstb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.passtb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.emailTb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.usernametb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.lnametb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.fnametb = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BtnQuit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(24, 714)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(372, 58)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(51, 672)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(291, 23)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "The information above is true"
        '
        'cb1
        '
        Me.cb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb1.Checked = False
        Me.cb1.CheckedOnColor = System.Drawing.Color.Maroon
        Me.cb1.ForeColor = System.Drawing.Color.White
        Me.cb1.Location = New System.Drawing.Point(22, 676)
        Me.cb1.Margin = New System.Windows.Forms.Padding(5)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(20, 20)
        Me.cb1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 2)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(265, 34)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CREATE ACCOUNT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnQuit2)
        Me.GroupBox1.Controls.Add(Me.btnQuit)
        Me.GroupBox1.Controls.Add(Me.cpasstb)
        Me.GroupBox1.Controls.Add(Me.passtb)
        Me.GroupBox1.Controls.Add(Me.emailTb)
        Me.GroupBox1.Controls.Add(Me.usernametb)
        Me.GroupBox1.Controls.Add(Me.lnametb)
        Me.GroupBox1.Controls.Add(Me.fnametb)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 802)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Silver
        Me.Label6.Location = New System.Drawing.Point(18, 356)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 34)
        Me.Label6.TabIndex = 143
        Me.Label6.Text = "Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(18, 563)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 34)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "Confirm Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(18, 459)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 34)
        Me.Label4.TabIndex = 143
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(18, 253)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 34)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(18, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 34)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(18, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 34)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "First Name"
        '
        'BtnQuit2
        '
        Me.BtnQuit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnQuit2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BtnQuit2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuit2.ForeColor = System.Drawing.Color.Gainsboro
        Me.BtnQuit2.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.BtnQuit2.IconColor = System.Drawing.Color.Gainsboro
        Me.BtnQuit2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnQuit2.IconSize = 28
        Me.BtnQuit2.Location = New System.Drawing.Point(399, 21)
        Me.BtnQuit2.Name = "BtnQuit2"
        Me.BtnQuit2.Size = New System.Drawing.Size(32, 32)
        Me.BtnQuit2.TabIndex = 142
        Me.BtnQuit2.TabStop = False
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuit.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnQuit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnQuit.IconColor = System.Drawing.Color.Gainsboro
        Me.btnQuit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnQuit.IconSize = 28
        Me.btnQuit.Location = New System.Drawing.Point(451, 21)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(32, 32)
        Me.btnQuit.TabIndex = 141
        Me.btnQuit.TabStop = False
        '
        'cpasstb
        '
        Me.cpasstb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cpasstb.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpasstb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cpasstb.HintForeColor = System.Drawing.Color.Silver
        Me.cpasstb.HintText = ""
        Me.cpasstb.isPassword = True
        Me.cpasstb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cpasstb.LineIdleColor = System.Drawing.Color.Gray
        Me.cpasstb.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.cpasstb.LineThickness = 2
        Me.cpasstb.Location = New System.Drawing.Point(24, 597)
        Me.cpasstb.Margin = New System.Windows.Forms.Padding(0)
        Me.cpasstb.Name = "cpasstb"
        Me.cpasstb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cpasstb.Size = New System.Drawing.Size(370, 60)
        Me.cpasstb.TabIndex = 24
        Me.cpasstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'passtb
        '
        Me.passtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passtb.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.passtb.HintForeColor = System.Drawing.Color.Silver
        Me.passtb.HintText = ""
        Me.passtb.isPassword = True
        Me.passtb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.passtb.LineIdleColor = System.Drawing.Color.Gray
        Me.passtb.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.passtb.LineThickness = 2
        Me.passtb.Location = New System.Drawing.Point(24, 493)
        Me.passtb.Margin = New System.Windows.Forms.Padding(0)
        Me.passtb.Name = "passtb"
        Me.passtb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.passtb.Size = New System.Drawing.Size(370, 60)
        Me.passtb.TabIndex = 24
        Me.passtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'emailTb
        '
        Me.emailTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailTb.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.emailTb.HintForeColor = System.Drawing.Color.Silver
        Me.emailTb.HintText = ""
        Me.emailTb.isPassword = False
        Me.emailTb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.emailTb.LineIdleColor = System.Drawing.Color.Gray
        Me.emailTb.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.emailTb.LineThickness = 2
        Me.emailTb.Location = New System.Drawing.Point(24, 390)
        Me.emailTb.Margin = New System.Windows.Forms.Padding(0)
        Me.emailTb.Name = "emailTb"
        Me.emailTb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.emailTb.Size = New System.Drawing.Size(370, 60)
        Me.emailTb.TabIndex = 24
        Me.emailTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'usernametb
        '
        Me.usernametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametb.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usernametb.HintForeColor = System.Drawing.Color.Silver
        Me.usernametb.HintText = ""
        Me.usernametb.isPassword = False
        Me.usernametb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.usernametb.LineIdleColor = System.Drawing.Color.Gray
        Me.usernametb.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.usernametb.LineThickness = 2
        Me.usernametb.Location = New System.Drawing.Point(24, 287)
        Me.usernametb.Margin = New System.Windows.Forms.Padding(0)
        Me.usernametb.Name = "usernametb"
        Me.usernametb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.usernametb.Size = New System.Drawing.Size(370, 60)
        Me.usernametb.TabIndex = 24
        Me.usernametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'lnametb
        '
        Me.lnametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lnametb.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnametb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnametb.HintForeColor = System.Drawing.Color.Silver
        Me.lnametb.HintText = ""
        Me.lnametb.isPassword = False
        Me.lnametb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lnametb.LineIdleColor = System.Drawing.Color.Gray
        Me.lnametb.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.lnametb.LineThickness = 2
        Me.lnametb.Location = New System.Drawing.Point(24, 184)
        Me.lnametb.Margin = New System.Windows.Forms.Padding(0)
        Me.lnametb.Name = "lnametb"
        Me.lnametb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lnametb.Size = New System.Drawing.Size(370, 60)
        Me.lnametb.TabIndex = 24
        Me.lnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'fnametb
        '
        Me.fnametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fnametb.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnametb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fnametb.HintForeColor = System.Drawing.Color.Silver
        Me.fnametb.HintText = ""
        Me.fnametb.isPassword = False
        Me.fnametb.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fnametb.LineIdleColor = System.Drawing.Color.Gray
        Me.fnametb.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.fnametb.LineThickness = 2
        Me.fnametb.Location = New System.Drawing.Point(24, 78)
        Me.fnametb.Margin = New System.Windows.Forms.Padding(0)
        Me.fnametb.Name = "fnametb"
        Me.fnametb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fnametb.Size = New System.Drawing.Size(370, 60)
        Me.fnametb.TabIndex = 24
        Me.fnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RegistrationForm
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(467, 826)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegistrationForm"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BtnQuit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cb1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fnametb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents lnametb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents passtb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents emailTb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents usernametb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cpasstb As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BtnQuit2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnQuit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
