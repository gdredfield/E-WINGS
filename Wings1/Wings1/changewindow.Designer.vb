<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changewindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changewindow))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rtb3 = New System.Windows.Forms.RichTextBox()
        Me.rtb2 = New System.Windows.Forms.RichTextBox()
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.changelbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.rtb3)
        Me.Panel1.Controls.Add(Me.rtb2)
        Me.Panel1.Controls.Add(Me.rtb1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.changelbl)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 393)
        Me.Panel1.TabIndex = 0
        '
        'rtb3
        '
        Me.rtb3.Location = New System.Drawing.Point(235, 12)
        Me.rtb3.Name = "rtb3"
        Me.rtb3.Size = New System.Drawing.Size(88, 33)
        Me.rtb3.TabIndex = 5
        Me.rtb3.Text = ""
        Me.rtb3.Visible = False
        '
        'rtb2
        '
        Me.rtb2.Location = New System.Drawing.Point(125, 12)
        Me.rtb2.Name = "rtb2"
        Me.rtb2.Size = New System.Drawing.Size(88, 33)
        Me.rtb2.TabIndex = 4
        Me.rtb2.Text = ""
        Me.rtb2.Visible = False
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(12, 12)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(88, 33)
        Me.rtb1.TabIndex = 3
        Me.rtb1.Text = ""
        Me.rtb1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(154, 342)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Print Receipt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'changelbl
        '
        Me.changelbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.changelbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.changelbl.Location = New System.Drawing.Point(162, 194)
        Me.changelbl.Name = "changelbl"
        Me.changelbl.Size = New System.Drawing.Size(161, 169)
        Me.changelbl.TabIndex = 2
        Me.changelbl.Text = "0.00"
        Me.changelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(168, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Change:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Successful!"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(174, 406)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
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
        'changewindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(475, 469)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changewindow"
        Me.Text = "changewindow"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents changelbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents rtb1 As RichTextBox
    Friend WithEvents rtb3 As RichTextBox
    Friend WithEvents rtb2 As RichTextBox
End Class
