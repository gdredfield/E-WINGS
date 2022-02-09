<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editsale
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnQuit = New FontAwesome.Sharp.IconPictureBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.datetb = New System.Windows.Forms.DateTimePicker()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.squantity = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prod_stock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.totaltb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.changetb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.proprice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.customcb = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.productcb = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sale_id = New System.Windows.Forms.Label()
        Me.btnNewCust = New System.Windows.Forms.Button()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnQuit)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 48)
        Me.Panel1.TabIndex = 0
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
        Me.btnQuit.Location = New System.Drawing.Point(575, 9)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(32, 32)
        Me.btnQuit.TabIndex = 108
        Me.btnQuit.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(4, 9)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(270, 34)
        Me.Label21.TabIndex = 107
        Me.Label21.Text = "Transaction Details"
        '
        'datetb
        '
        Me.datetb.CustomFormat = "yyyy/MM/dd"
        Me.datetb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.datetb.Location = New System.Drawing.Point(252, 409)
        Me.datetb.Name = "datetb"
        Me.datetb.Size = New System.Drawing.Size(326, 41)
        Me.datetb.TabIndex = 110
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(24, 409)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(221, 30)
        Me.Label27.TabIndex = 109
        Me.Label27.Text = "Transaction Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(66, 72)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 30)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Product ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(47, 345)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 30)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Quantity Sold:"
        '
        'squantity
        '
        Me.squantity.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.squantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.squantity.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.squantity.ForeColor = System.Drawing.Color.White
        Me.squantity.Location = New System.Drawing.Point(233, 346)
        Me.squantity.Margin = New System.Windows.Forms.Padding(4)
        Me.squantity.Name = "squantity"
        Me.squantity.Size = New System.Drawing.Size(354, 41)
        Me.squantity.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(115, 197)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 30)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Stocks:"
        '
        'prod_stock
        '
        Me.prod_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.prod_stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.prod_stock.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.prod_stock.ForeColor = System.Drawing.Color.White
        Me.prod_stock.Location = New System.Drawing.Point(216, 197)
        Me.prod_stock.Margin = New System.Windows.Forms.Padding(4)
        Me.prod_stock.Name = "prod_stock"
        Me.prod_stock.ReadOnly = True
        Me.prod_stock.Size = New System.Drawing.Size(354, 41)
        Me.prod_stock.TabIndex = 96
        Me.prod_stock.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(47, 535)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 30)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Total Amount:"
        '
        'totaltb
        '
        Me.totaltb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.totaltb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totaltb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.totaltb.ForeColor = System.Drawing.Color.White
        Me.totaltb.Location = New System.Drawing.Point(233, 536)
        Me.totaltb.Margin = New System.Windows.Forms.Padding(4)
        Me.totaltb.Name = "totaltb"
        Me.totaltb.ReadOnly = True
        Me.totaltb.Size = New System.Drawing.Size(354, 41)
        Me.totaltb.TabIndex = 112
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(108, 472)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 30)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Change:"
        '
        'changetb
        '
        Me.changetb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.changetb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.changetb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.changetb.ForeColor = System.Drawing.Color.White
        Me.changetb.Location = New System.Drawing.Point(233, 472)
        Me.changetb.Margin = New System.Windows.Forms.Padding(4)
        Me.changetb.Name = "changetb"
        Me.changetb.ReadOnly = True
        Me.changetb.Size = New System.Drawing.Size(354, 41)
        Me.changetb.TabIndex = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(31, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 30)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Product Price:"
        '
        'proprice
        '
        Me.proprice.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.proprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.proprice.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.proprice.ForeColor = System.Drawing.Color.White
        Me.proprice.Location = New System.Drawing.Point(216, 134)
        Me.proprice.Margin = New System.Windows.Forms.Padding(4)
        Me.proprice.Name = "proprice"
        Me.proprice.ReadOnly = True
        Me.proprice.Size = New System.Drawing.Size(354, 41)
        Me.proprice.TabIndex = 118
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(48, 600)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(136, 30)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Customer:"
        '
        'customcb
        '
        Me.customcb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.customcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.customcb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.customcb.ForeColor = System.Drawing.Color.White
        Me.customcb.FormattingEnabled = True
        Me.customcb.Location = New System.Drawing.Point(191, 600)
        Me.customcb.Name = "customcb"
        Me.customcb.Size = New System.Drawing.Size(295, 41)
        Me.customcb.TabIndex = 121
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.productcb)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.sale_id)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.proprice)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.prod_stock)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(17, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(588, 260)
        Me.Panel2.TabIndex = 130
        '
        'productcb
        '
        Me.productcb.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.productcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.productcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.productcb.Font = New System.Drawing.Font("Century Gothic", 16.2!)
        Me.productcb.ForeColor = System.Drawing.Color.White
        Me.productcb.FormattingEnabled = True
        Me.productcb.Location = New System.Drawing.Point(216, 73)
        Me.productcb.Name = "productcb"
        Me.productcb.Size = New System.Drawing.Size(274, 41)
        Me.productcb.TabIndex = 131
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(108, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 30)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Sale ID:"
        '
        'sale_id
        '
        Me.sale_id.AutoSize = True
        Me.sale_id.BackColor = System.Drawing.Color.Transparent
        Me.sale_id.Font = New System.Drawing.Font("Century Gothic", 13.8!)
        Me.sale_id.ForeColor = System.Drawing.Color.White
        Me.sale_id.Location = New System.Drawing.Point(213, 23)
        Me.sale_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sale_id.Name = "sale_id"
        Me.sale_id.Size = New System.Drawing.Size(52, 30)
        Me.sale_id.TabIndex = 84
        Me.sale_id.Text = "001"
        '
        'btnNewCust
        '
        Me.btnNewCust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNewCust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewCust.FlatAppearance.BorderSize = 0
        Me.btnNewCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCust.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCust.ForeColor = System.Drawing.Color.Black
        Me.btnNewCust.Location = New System.Drawing.Point(492, 600)
        Me.btnNewCust.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNewCust.Name = "btnNewCust"
        Me.btnNewCust.Size = New System.Drawing.Size(95, 41)
        Me.btnNewCust.TabIndex = 131
        Me.btnNewCust.Text = "New"
        Me.btnNewCust.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(349, 658)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(238, 64)
        Me.btnSave.TabIndex = 196
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'editsale
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 737)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNewCust)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.totaltb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.changetb)
        Me.Controls.Add(Me.customcb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.datetb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.squantity)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editsale"
        Me.Text = "editsale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnQuit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents datetb As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents squantity As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents prod_stock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents totaltb As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents changetb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents proprice As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents customcb As ComboBox
    Friend WithEvents btnQuit As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents sale_id As Label
    Friend WithEvents productcb As ComboBox
    Friend WithEvents btnNewCust As Button
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
End Class
