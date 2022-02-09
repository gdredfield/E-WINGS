<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentWindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.finid = New System.Windows.Forms.TextBox()
        Me.rtb3 = New System.Windows.Forms.RichTextBox()
        Me.rtb2 = New System.Windows.Forms.RichTextBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cpasstb = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.confirmbut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.receipt = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.printbut = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.finid)
        Me.Panel1.Controls.Add(Me.rtb3)
        Me.Panel1.Controls.Add(Me.rtb2)
        Me.Panel1.Controls.Add(Me.rtb1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 58)
        Me.Panel1.TabIndex = 2
        '
        'finid
        '
        Me.finid.Location = New System.Drawing.Point(482, 17)
        Me.finid.Name = "finid"
        Me.finid.Size = New System.Drawing.Size(50, 22)
        Me.finid.TabIndex = 192
        Me.finid.Visible = False
        '
        'rtb3
        '
        Me.rtb3.Location = New System.Drawing.Point(321, 18)
        Me.rtb3.Name = "rtb3"
        Me.rtb3.Size = New System.Drawing.Size(65, 24)
        Me.rtb3.TabIndex = 191
        Me.rtb3.Text = ""
        Me.rtb3.Visible = False
        '
        'rtb2
        '
        Me.rtb2.Location = New System.Drawing.Point(250, 18)
        Me.rtb2.Name = "rtb2"
        Me.rtb2.Size = New System.Drawing.Size(65, 24)
        Me.rtb2.TabIndex = 191
        Me.rtb2.Text = ""
        Me.rtb2.Visible = False
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(179, 18)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(65, 24)
        Me.rtb1.TabIndex = 191
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 34)
        Me.Label4.TabIndex = 190
        Me.Label4.Text = "Payment"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(564, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 23)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Close"
        '
        'cpasstb
        '
        Me.cpasstb.BackColor = System.Drawing.Color.White
        Me.cpasstb.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cpasstb.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpasstb.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cpasstb.BorderThickness = 3
        Me.cpasstb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cpasstb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpasstb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpasstb.isPassword = False
        Me.cpasstb.Location = New System.Drawing.Point(164, 13)
        Me.cpasstb.Margin = New System.Windows.Forms.Padding(5)
        Me.cpasstb.Name = "cpasstb"
        Me.cpasstb.Size = New System.Drawing.Size(171, 51)
        Me.cpasstb.TabIndex = 97
        Me.cpasstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(9, 23)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 30)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Enter Cash:"
        '
        'confirmbut
        '
        Me.confirmbut.BackColor = System.Drawing.Color.Maroon
        Me.confirmbut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.confirmbut.FlatAppearance.BorderSize = 0
        Me.confirmbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmbut.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmbut.ForeColor = System.Drawing.Color.White
        Me.confirmbut.Location = New System.Drawing.Point(345, 11)
        Me.confirmbut.Name = "confirmbut"
        Me.confirmbut.Size = New System.Drawing.Size(138, 54)
        Me.confirmbut.TabIndex = 100
        Me.confirmbut.Text = "Confirm"
        Me.confirmbut.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.receipt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(636, 385)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'receipt
        '
        Me.receipt.BackColor = System.Drawing.Color.White
        Me.receipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.receipt.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receipt.Location = New System.Drawing.Point(7, 22)
        Me.receipt.Name = "receipt"
        Me.receipt.ReadOnly = True
        Me.receipt.Size = New System.Drawing.Size(629, 367)
        Me.receipt.TabIndex = 100
        Me.receipt.TabStop = False
        Me.receipt.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 384)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(0, 469)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel4.Size = New System.Drawing.Size(644, 104)
        Me.Panel4.TabIndex = 181
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Panel14)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(642, 102)
        Me.Panel5.TabIndex = 0
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel14.Controls.Add(Me.printbut)
        Me.Panel14.Controls.Add(Me.cpasstb)
        Me.Panel14.Controls.Add(Me.Label6)
        Me.Panel14.Controls.Add(Me.confirmbut)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(642, 102)
        Me.Panel14.TabIndex = 84
        '
        'printbut
        '
        Me.printbut.BackColor = System.Drawing.Color.Teal
        Me.printbut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printbut.FlatAppearance.BorderSize = 0
        Me.printbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printbut.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printbut.ForeColor = System.Drawing.Color.White
        Me.printbut.Location = New System.Drawing.Point(493, 11)
        Me.printbut.Name = "printbut"
        Me.printbut.Size = New System.Drawing.Size(138, 54)
        Me.printbut.TabIndex = 101
        Me.printbut.Text = "Print"
        Me.printbut.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(7, 14)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(114, 19)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Filter by Date"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wings1.My.Resources.Resources.wing_logo
        Me.PictureBox1.Location = New System.Drawing.Point(8, 585)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'PaymentWindow
        '
        Me.AcceptButton = Me.confirmbut
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 551)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PaymentWindow"
        Me.Text = "PaymentWindow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents cpasstb As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents confirmbut As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents receipt As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents printbut As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents rtb3 As RichTextBox
    Friend WithEvents rtb2 As RichTextBox
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents finid As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
