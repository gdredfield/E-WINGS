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
        Me.emailTb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.cb1 = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.cpasstb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.passtb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.usernametb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lnametb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.fnametb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkRed
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(32, 428)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(287, 58)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'emailTb
        '
        Me.emailTb.BorderColorFocused = System.Drawing.Color.Blue
        Me.emailTb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.emailTb.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.emailTb.BorderThickness = 3
        Me.emailTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.emailTb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.emailTb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.emailTb.isPassword = False
        Me.emailTb.Location = New System.Drawing.Point(348, 197)
        Me.emailTb.Margin = New System.Windows.Forms.Padding(5)
        Me.emailTb.Name = "emailTb"
        Me.emailTb.Size = New System.Drawing.Size(316, 54)
        Me.emailTb.TabIndex = 22
        Me.emailTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Location = New System.Drawing.Point(633, 24)
        Me.LinkLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(57, 27)
        Me.LinkLabel2.TabIndex = 21
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Back"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(61, 383)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(477, 27)
        Me.LinkLabel1.TabIndex = 19
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "I hereby swear that the information above is true"
        '
        'cb1
        '
        Me.cb1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb1.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.cb1.Checked = False
        Me.cb1.CheckedOnColor = System.Drawing.Color.Maroon
        Me.cb1.ForeColor = System.Drawing.Color.White
        Me.cb1.Location = New System.Drawing.Point(32, 387)
        Me.cb1.Margin = New System.Windows.Forms.Padding(5)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(20, 20)
        Me.cb1.TabIndex = 18
        '
        'cpasstb
        '
        Me.cpasstb.BorderColorFocused = System.Drawing.Color.Blue
        Me.cpasstb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpasstb.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.cpasstb.BorderThickness = 3
        Me.cpasstb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cpasstb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cpasstb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpasstb.isPassword = True
        Me.cpasstb.Location = New System.Drawing.Point(349, 304)
        Me.cpasstb.Margin = New System.Windows.Forms.Padding(5)
        Me.cpasstb.Name = "cpasstb"
        Me.cpasstb.Size = New System.Drawing.Size(316, 54)
        Me.cpasstb.TabIndex = 16
        Me.cpasstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'passtb
        '
        Me.passtb.BorderColorFocused = System.Drawing.Color.Blue
        Me.passtb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passtb.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.passtb.BorderThickness = 3
        Me.passtb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passtb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.passtb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passtb.isPassword = True
        Me.passtb.Location = New System.Drawing.Point(32, 304)
        Me.passtb.Margin = New System.Windows.Forms.Padding(5)
        Me.passtb.Name = "passtb"
        Me.passtb.Size = New System.Drawing.Size(287, 54)
        Me.passtb.TabIndex = 15
        Me.passtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'usernametb
        '
        Me.usernametb.BorderColorFocused = System.Drawing.Color.Blue
        Me.usernametb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usernametb.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.usernametb.BorderThickness = 3
        Me.usernametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.usernametb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.usernametb.isPassword = False
        Me.usernametb.Location = New System.Drawing.Point(32, 197)
        Me.usernametb.Margin = New System.Windows.Forms.Padding(5)
        Me.usernametb.Name = "usernametb"
        Me.usernametb.Size = New System.Drawing.Size(287, 54)
        Me.usernametb.TabIndex = 14
        Me.usernametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Brown
        Me.Label7.Location = New System.Drawing.Point(7, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(239, 31)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "CREATE ACCOUNT"
        '
        'lnametb
        '
        Me.lnametb.BorderColorFocused = System.Drawing.Color.Blue
        Me.lnametb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnametb.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.lnametb.BorderThickness = 3
        Me.lnametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lnametb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lnametb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lnametb.isPassword = False
        Me.lnametb.Location = New System.Drawing.Point(348, 87)
        Me.lnametb.Margin = New System.Windows.Forms.Padding(5)
        Me.lnametb.Name = "lnametb"
        Me.lnametb.Size = New System.Drawing.Size(316, 54)
        Me.lnametb.TabIndex = 11
        Me.lnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'fnametb
        '
        Me.fnametb.BorderColorFocused = System.Drawing.Color.Blue
        Me.fnametb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fnametb.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.fnametb.BorderThickness = 3
        Me.fnametb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.fnametb.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.fnametb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.fnametb.isPassword = False
        Me.fnametb.Location = New System.Drawing.Point(32, 87)
        Me.fnametb.Margin = New System.Windows.Forms.Padding(5)
        Me.fnametb.Name = "fnametb"
        Me.fnametb.Size = New System.Drawing.Size(287, 54)
        Me.fnametb.TabIndex = 10
        Me.fnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Confirm Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 277)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 170)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.usernametb)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.passtb)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lnametb)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cpasstb)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.fnametb)
        Me.GroupBox1.Controls.Add(Me.emailTb)
        Me.GroupBox1.Controls.Add(Me.cb1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LinkLabel2)
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 509)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(730, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RegistrationForm"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lnametb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents fnametb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents cpasstb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents passtb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents usernametb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents cb1 As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents emailTb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
