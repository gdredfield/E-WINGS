<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stocklogform
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.salech = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.yearBtn = New FontAwesome.Sharp.IconButton()
        Me.monthBtn = New FontAwesome.Sharp.IconButton()
        Me.weekBtn = New FontAwesome.Sharp.IconButton()
        Me.switchCb = New System.Windows.Forms.ComboBox()
        CType(Me.salech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'salech
        '
        Me.salech.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.IsStartedFromZero = False
        ChartArea2.AxisX.LabelAutoFitMaxFontSize = 8
        ChartArea2.AxisX.LabelAutoFitMinFontSize = 7
        ChartArea2.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer))
        ChartArea2.AxisX.LabelStyle.Interval = 1.0R
        ChartArea2.AxisX.LineColor = System.Drawing.Color.White
        ChartArea2.AxisX.LineWidth = 0
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea2.AxisX.ScaleBreakStyle.Spacing = 1.0R
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea2.AxisX2.Interval = 1.0R
        ChartArea2.AxisX2.LabelAutoFitMaxFontSize = 8
        ChartArea2.AxisX2.LabelAutoFitMinFontSize = 7
        ChartArea2.AxisX2.LabelStyle.Enabled = False
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea2.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea2.AxisY.InterlacedColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        ChartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisY.IsInterlaced = True
        ChartArea2.AxisY.LabelAutoFitMaxFontSize = 8
        ChartArea2.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(195, Byte), Integer))
        ChartArea2.AxisY.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer))
        ChartArea2.AxisY2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea2.AxisY2.LabelAutoFitMaxFontSize = 8
        ChartArea2.AxisY2.LabelStyle.Enabled = False
        ChartArea2.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        ChartArea2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer))
        ChartArea2.BorderColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        ChartArea2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.salech.ChartAreas.Add(ChartArea2)
        Me.salech.Cursor = System.Windows.Forms.Cursors.Default
        Legend2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Legend2.HeaderSeparatorColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Legend2.IsTextAutoFit = False
        Legend2.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Legend2.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row
        Legend2.Name = "Legend1"
        Legend2.ShadowColor = System.Drawing.Color.Chocolate
        Legend2.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Legend2.TitleSeparatorColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.salech.Legends.Add(Legend2)
        Me.salech.Location = New System.Drawing.Point(-22, 121)
        Me.salech.Name = "salech"
        Me.salech.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Me.salech.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Series6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series6.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Series6.BorderColor = System.Drawing.Color.Transparent
        Series6.ChartArea = "ChartArea1"
        Series6.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Series6.CustomProperties = "LabelStyle=Top"
        Series6.IsValueShownAsLabel = True
        Series6.IsVisibleInLegend = False
        Series6.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series6.Legend = "Legend1"
        Series6.LegendText = "Inv Value"
        Series6.MarkerBorderColor = System.Drawing.Color.White
        Series6.MarkerColor = System.Drawing.Color.White
        Series6.Name = "inValue"
        Series6.ShadowOffset = 1
        Series7.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series7.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Series7.BorderColor = System.Drawing.Color.Transparent
        Series7.ChartArea = "ChartArea1"
        Series7.CustomProperties = "LabelStyle=Top"
        Series7.IsValueShownAsLabel = True
        Series7.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series7.Legend = "Legend1"
        Series7.LegendText = "Sales"
        Series7.Name = "Sales"
        Series7.ShadowOffset = 1
        Series8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series8.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Series8.BorderColor = System.Drawing.Color.Transparent
        Series8.ChartArea = "ChartArea1"
        Series8.Color = System.Drawing.Color.Aqua
        Series8.CustomProperties = "LabelStyle=Top"
        Series8.IsValueShownAsLabel = True
        Series8.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series8.Legend = "Legend1"
        Series8.LegendText = "Costs"
        Series8.Name = "stockCon"
        Series8.ShadowOffset = 1
        Series9.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series9.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Series9.BorderColor = System.Drawing.Color.Transparent
        Series9.ChartArea = "ChartArea1"
        Series9.Color = System.Drawing.Color.DodgerBlue
        Series9.CustomProperties = "LabelStyle=Top"
        Series9.IsValueShownAsLabel = True
        Series9.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series9.Legend = "Legend1"
        Series9.LegendText = "ServingsMade"
        Series9.Name = "servings"
        Series9.ShadowOffset = 1
        Series10.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series10.BackSecondaryColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Series10.BorderColor = System.Drawing.Color.Transparent
        Series10.ChartArea = "ChartArea1"
        Series10.Color = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(0, Byte), Integer))
        Series10.CustomProperties = "LabelStyle=Top"
        Series10.IsValueShownAsLabel = True
        Series10.LabelForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Series10.Legend = "Legend1"
        Series10.LegendText = "StockUsed"
        Series10.Name = "stockqty"
        Series10.ShadowOffset = 1
        Me.salech.Series.Add(Series6)
        Me.salech.Series.Add(Series7)
        Me.salech.Series.Add(Series8)
        Me.salech.Series.Add(Series9)
        Me.salech.Series.Add(Series10)
        Me.salech.Size = New System.Drawing.Size(1287, 633)
        Me.salech.TabIndex = 149
        Me.salech.Text = "Chart1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1242, 52)
        Me.Panel2.TabIndex = 150
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(0, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1242, 42)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Sales and Costs Report"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'yearBtn
        '
        Me.yearBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.yearBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.yearBtn.FlatAppearance.BorderSize = 0
        Me.yearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.yearBtn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearBtn.ForeColor = System.Drawing.Color.White
        Me.yearBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.yearBtn.IconColor = System.Drawing.Color.White
        Me.yearBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.yearBtn.IconSize = 35
        Me.yearBtn.Location = New System.Drawing.Point(350, 70)
        Me.yearBtn.Name = "yearBtn"
        Me.yearBtn.Size = New System.Drawing.Size(140, 44)
        Me.yearBtn.TabIndex = 152
        Me.yearBtn.Text = "Annual"
        Me.yearBtn.UseVisualStyleBackColor = False
        '
        'monthBtn
        '
        Me.monthBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.monthBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.monthBtn.FlatAppearance.BorderSize = 0
        Me.monthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.monthBtn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthBtn.ForeColor = System.Drawing.Color.White
        Me.monthBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.monthBtn.IconColor = System.Drawing.Color.White
        Me.monthBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.monthBtn.IconSize = 35
        Me.monthBtn.Location = New System.Drawing.Point(208, 70)
        Me.monthBtn.Name = "monthBtn"
        Me.monthBtn.Size = New System.Drawing.Size(123, 44)
        Me.monthBtn.TabIndex = 153
        Me.monthBtn.Text = "Monthly"
        Me.monthBtn.UseVisualStyleBackColor = False
        '
        'weekBtn
        '
        Me.weekBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.weekBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.weekBtn.FlatAppearance.BorderSize = 0
        Me.weekBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.weekBtn.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weekBtn.ForeColor = System.Drawing.Color.White
        Me.weekBtn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.weekBtn.IconColor = System.Drawing.Color.White
        Me.weekBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.weekBtn.IconSize = 35
        Me.weekBtn.Location = New System.Drawing.Point(33, 70)
        Me.weekBtn.Name = "weekBtn"
        Me.weekBtn.Size = New System.Drawing.Size(156, 44)
        Me.weekBtn.TabIndex = 154
        Me.weekBtn.Text = "This Week"
        Me.weekBtn.UseVisualStyleBackColor = False
        '
        'switchCb
        '
        Me.switchCb.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.switchCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.switchCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.switchCb.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.switchCb.ForeColor = System.Drawing.Color.Gainsboro
        Me.switchCb.FormattingEnabled = True
        Me.switchCb.Items.AddRange(New Object() {"Sales and Costs", "Servings Made", "Stocks Consumed"})
        Me.switchCb.Location = New System.Drawing.Point(970, 72)
        Me.switchCb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.switchCb.Name = "switchCb"
        Me.switchCb.Size = New System.Drawing.Size(250, 38)
        Me.switchCb.TabIndex = 189
        '
        'stocklogform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1242, 762)
        Me.Controls.Add(Me.switchCb)
        Me.Controls.Add(Me.yearBtn)
        Me.Controls.Add(Me.monthBtn)
        Me.Controls.Add(Me.weekBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.salech)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stocklogform"
        Me.Text = "Stock Reports"
        CType(Me.salech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents salech As DataVisualization.Charting.Chart
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents yearBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents monthBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents weekBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents switchCb As ComboBox
End Class
