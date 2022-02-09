<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard1
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
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnStockReports = New FontAwesome.Sharp.IconButton()
        Me.btnLogout = New FontAwesome.Sharp.IconPictureBox()
        Me.btnMngUsers = New FontAwesome.Sharp.IconButton()
        Me.btnSalesReport = New FontAwesome.Sharp.IconButton()
        Me.btnSetIngredients = New FontAwesome.Sharp.IconButton()
        Me.btnPurchaseOrder = New FontAwesome.Sharp.IconButton()
        Me.btnPos = New FontAwesome.Sharp.IconButton()
        Me.btnCustomers = New FontAwesome.Sharp.IconButton()
        Me.btnSales = New FontAwesome.Sharp.IconButton()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.btnDashboard = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEditUser = New FontAwesome.Sharp.IconButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.pnlRound5 = New System.Windows.Forms.Panel()
        Me.IconPictureBox6 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnViewExp = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlRound4 = New System.Windows.Forms.Panel()
        Me.btnBadorder = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dbpiechart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pnlRound3 = New System.Windows.Forms.Panel()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRunningLow = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnViewLow = New FontAwesome.Sharp.IconButton()
        Me.pnlRound2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlRound = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        Me.pnlRound5.SuspendLayout()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRound4.SuspendLayout()
        CType(Me.dbpiechart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRound3.SuspendLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRound2.SuspendLayout()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRound.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnStockReports)
        Me.PanelMenu.Controls.Add(Me.btnLogout)
        Me.PanelMenu.Controls.Add(Me.btnMngUsers)
        Me.PanelMenu.Controls.Add(Me.btnSalesReport)
        Me.PanelMenu.Controls.Add(Me.btnSetIngredients)
        Me.PanelMenu.Controls.Add(Me.btnPurchaseOrder)
        Me.PanelMenu.Controls.Add(Me.btnPos)
        Me.PanelMenu.Controls.Add(Me.btnCustomers)
        Me.PanelMenu.Controls.Add(Me.btnSales)
        Me.PanelMenu.Controls.Add(Me.btnInventory)
        Me.PanelMenu.Controls.Add(Me.btnDashboard)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(240, 853)
        Me.PanelMenu.TabIndex = 0
        '
        'btnStockReports
        '
        Me.btnStockReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStockReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStockReports.FlatAppearance.BorderSize = 0
        Me.btnStockReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStockReports.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStockReports.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnStockReports.IconChar = FontAwesome.Sharp.IconChar.ChartPie
        Me.btnStockReports.IconColor = System.Drawing.Color.Gainsboro
        Me.btnStockReports.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnStockReports.IconSize = 35
        Me.btnStockReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockReports.Location = New System.Drawing.Point(0, 690)
        Me.btnStockReports.Name = "btnStockReports"
        Me.btnStockReports.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnStockReports.Size = New System.Drawing.Size(240, 60)
        Me.btnStockReports.TabIndex = 40
        Me.btnStockReports.Text = "Stock Reports"
        Me.btnStockReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStockReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnStockReports.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.btnLogout.IconColor = System.Drawing.Color.Gainsboro
        Me.btnLogout.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogout.IconSize = 42
        Me.btnLogout.Location = New System.Drawing.Point(12, 799)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(54, 42)
        Me.btnLogout.TabIndex = 39
        Me.btnLogout.TabStop = False
        '
        'btnMngUsers
        '
        Me.btnMngUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMngUsers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMngUsers.FlatAppearance.BorderSize = 0
        Me.btnMngUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMngUsers.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMngUsers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnMngUsers.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnMngUsers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMngUsers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMngUsers.IconSize = 35
        Me.btnMngUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMngUsers.Location = New System.Drawing.Point(0, 630)
        Me.btnMngUsers.Name = "btnMngUsers"
        Me.btnMngUsers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnMngUsers.Size = New System.Drawing.Size(240, 60)
        Me.btnMngUsers.TabIndex = 38
        Me.btnMngUsers.Text = "Manage Users"
        Me.btnMngUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMngUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMngUsers.UseVisualStyleBackColor = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalesReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSalesReport.FlatAppearance.BorderSize = 0
        Me.btnSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalesReport.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSalesReport.IconChar = FontAwesome.Sharp.IconChar.ChartArea
        Me.btnSalesReport.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSalesReport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalesReport.IconSize = 35
        Me.btnSalesReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalesReport.Location = New System.Drawing.Point(0, 570)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSalesReport.Size = New System.Drawing.Size(240, 60)
        Me.btnSalesReport.TabIndex = 37
        Me.btnSalesReport.Text = "Sales Report"
        Me.btnSalesReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalesReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnSetIngredients
        '
        Me.btnSetIngredients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSetIngredients.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetIngredients.FlatAppearance.BorderSize = 0
        Me.btnSetIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetIngredients.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetIngredients.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSetIngredients.IconChar = FontAwesome.Sharp.IconChar.ListAlt
        Me.btnSetIngredients.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSetIngredients.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSetIngredients.IconSize = 35
        Me.btnSetIngredients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetIngredients.Location = New System.Drawing.Point(0, 510)
        Me.btnSetIngredients.Name = "btnSetIngredients"
        Me.btnSetIngredients.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSetIngredients.Size = New System.Drawing.Size(240, 60)
        Me.btnSetIngredients.TabIndex = 36
        Me.btnSetIngredients.Text = "Set Ingredients"
        Me.btnSetIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetIngredients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetIngredients.UseVisualStyleBackColor = True
        '
        'btnPurchaseOrder
        '
        Me.btnPurchaseOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPurchaseOrder.FlatAppearance.BorderSize = 0
        Me.btnPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchaseOrder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchaseOrder.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPurchaseOrder.IconChar = FontAwesome.Sharp.IconChar.CartPlus
        Me.btnPurchaseOrder.IconColor = System.Drawing.Color.Gainsboro
        Me.btnPurchaseOrder.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPurchaseOrder.IconSize = 35
        Me.btnPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseOrder.Location = New System.Drawing.Point(0, 450)
        Me.btnPurchaseOrder.Name = "btnPurchaseOrder"
        Me.btnPurchaseOrder.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPurchaseOrder.Size = New System.Drawing.Size(240, 60)
        Me.btnPurchaseOrder.TabIndex = 35
        Me.btnPurchaseOrder.Text = "Purchase Order"
        Me.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPurchaseOrder.UseVisualStyleBackColor = True
        '
        'btnPos
        '
        Me.btnPos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPos.FlatAppearance.BorderSize = 0
        Me.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPos.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPos.IconChar = FontAwesome.Sharp.IconChar.Coins
        Me.btnPos.IconColor = System.Drawing.Color.Gainsboro
        Me.btnPos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPos.IconSize = 35
        Me.btnPos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPos.Location = New System.Drawing.Point(0, 390)
        Me.btnPos.Name = "btnPos"
        Me.btnPos.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnPos.Size = New System.Drawing.Size(240, 60)
        Me.btnPos.TabIndex = 34
        Me.btnPos.Text = "Point of Sale"
        Me.btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPos.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCustomers.FlatAppearance.BorderSize = 0
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.AddressCard
        Me.btnCustomers.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCustomers.IconSize = 35
        Me.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.Location = New System.Drawing.Point(0, 330)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnCustomers.Size = New System.Drawing.Size(240, 60)
        Me.btnCustomers.TabIndex = 33
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSales.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSales.FlatAppearance.BorderSize = 0
        Me.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSales.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnSales.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSales.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSales.IconSize = 35
        Me.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.Location = New System.Drawing.Point(0, 270)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnSales.Size = New System.Drawing.Size(240, 60)
        Me.btnSales.TabIndex = 32
        Me.btnSales.Text = "Sales"
        Me.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.btnInventory.IconColor = System.Drawing.Color.Gainsboro
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.IconSize = 35
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 210)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnInventory.Size = New System.Drawing.Size(240, 60)
        Me.btnInventory.TabIndex = 31
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnDashboard
        '
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btnDashboard.IconColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDashboard.IconSize = 35
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 150)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Padding = New System.Windows.Forms.Padding(10, 0, 20, 0)
        Me.btnDashboard.Size = New System.Drawing.Size(240, 60)
        Me.btnDashboard.TabIndex = 25
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 150)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wings1.My.Resources.Resources.Wingslogo1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 145)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnEditUser)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.IconPictureBox3)
        Me.Panel2.Controls.Add(Me.IconPictureBox1)
        Me.Panel2.Controls.Add(Me.lblFormTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(240, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1242, 91)
        Me.Panel2.TabIndex = 1
        '
        'btnEditUser
        '
        Me.btnEditUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEditUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditUser.FlatAppearance.BorderSize = 0
        Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUser.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnEditUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnEditUser.IconColor = System.Drawing.Color.Gainsboro
        Me.btnEditUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditUser.IconSize = 42
        Me.btnEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditUser.Location = New System.Drawing.Point(862, 5)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(308, 47)
        Me.btnEditUser.TabIndex = 26
        Me.btnEditUser.Text = "Joo Hong"
        Me.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditUser.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblTime.Location = New System.Drawing.Point(944, 57)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(70, 30)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time"
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.IconPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconPictureBox3.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 28
        Me.IconPictureBox3.Location = New System.Drawing.Point(1214, 0)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox3.TabIndex = 4
        Me.IconPictureBox3.TabStop = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.IconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Gainsboro
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 28
        Me.IconPictureBox1.Location = New System.Drawing.Point(1176, 0)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox1.TabIndex = 2
        Me.IconPictureBox1.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(15, 54)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(166, 34)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Dashboard"
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.pnlRound5)
        Me.PanelDesktop.Controls.Add(Me.Label2)
        Me.PanelDesktop.Controls.Add(Me.pnlRound4)
        Me.PanelDesktop.Controls.Add(Me.pnlRound3)
        Me.PanelDesktop.Controls.Add(Me.pnlRound2)
        Me.PanelDesktop.Controls.Add(Me.pnlRound)
        Me.PanelDesktop.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(240, 91)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1242, 762)
        Me.PanelDesktop.TabIndex = 2
        '
        'pnlRound5
        '
        Me.pnlRound5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlRound5.Controls.Add(Me.IconPictureBox6)
        Me.pnlRound5.Controls.Add(Me.Label8)
        Me.pnlRound5.Controls.Add(Me.lblExpired)
        Me.pnlRound5.Controls.Add(Me.Label11)
        Me.pnlRound5.Controls.Add(Me.btnViewExp)
        Me.pnlRound5.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlRound5.Location = New System.Drawing.Point(75, 522)
        Me.pnlRound5.Name = "pnlRound5"
        Me.pnlRound5.Size = New System.Drawing.Size(325, 211)
        Me.pnlRound5.TabIndex = 141
        '
        'IconPictureBox6
        '
        Me.IconPictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox6.Cursor = System.Windows.Forms.Cursors.Default
        Me.IconPictureBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.IconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.IconPictureBox6.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.IconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox6.IconSize = 98
        Me.IconPictureBox6.Location = New System.Drawing.Point(37, 70)
        Me.IconPictureBox6.Name = "IconPictureBox6"
        Me.IconPictureBox6.Size = New System.Drawing.Size(98, 98)
        Me.IconPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox6.TabIndex = 30
        Me.IconPictureBox6.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(164, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 46)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Unchecked" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Expired Items"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExpired
        '
        Me.lblExpired.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpired.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblExpired.Location = New System.Drawing.Point(141, 80)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(162, 58)
        Me.lblExpired.TabIndex = 31
        Me.lblExpired.Text = "0046"
        Me.lblExpired.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label11.Location = New System.Drawing.Point(189, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 34)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Expired" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnViewExp
        '
        Me.btnViewExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewExp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewExp.FlatAppearance.BorderSize = 0
        Me.btnViewExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewExp.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewExp.ForeColor = System.Drawing.Color.White
        Me.btnViewExp.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnViewExp.IconColor = System.Drawing.Color.White
        Me.btnViewExp.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnViewExp.IconSize = 35
        Me.btnViewExp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewExp.Location = New System.Drawing.Point(19, 12)
        Me.btnViewExp.Name = "btnViewExp"
        Me.btnViewExp.Size = New System.Drawing.Size(116, 49)
        Me.btnViewExp.TabIndex = 138
        Me.btnViewExp.Text = "View"
        Me.btnViewExp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewExp.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(36, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(671, 30)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Welcome! Check out how business is doing this month!"
        '
        'pnlRound4
        '
        Me.pnlRound4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlRound4.Controls.Add(Me.btnBadorder)
        Me.pnlRound4.Controls.Add(Me.Label3)
        Me.pnlRound4.Controls.Add(Me.dbpiechart)
        Me.pnlRound4.Location = New System.Drawing.Point(421, 296)
        Me.pnlRound4.Name = "pnlRound4"
        Me.pnlRound4.Size = New System.Drawing.Size(787, 437)
        Me.pnlRound4.TabIndex = 141
        '
        'btnBadorder
        '
        Me.btnBadorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBadorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBadorder.FlatAppearance.BorderSize = 0
        Me.btnBadorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBadorder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBadorder.ForeColor = System.Drawing.Color.White
        Me.btnBadorder.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle
        Me.btnBadorder.IconColor = System.Drawing.Color.White
        Me.btnBadorder.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBadorder.IconSize = 35
        Me.btnBadorder.Location = New System.Drawing.Point(584, 356)
        Me.btnBadorder.Name = "btnBadorder"
        Me.btnBadorder.Size = New System.Drawing.Size(175, 57)
        Me.btnBadorder.TabIndex = 138
        Me.btnBadorder.Text = "Bad Orders"
        Me.btnBadorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBadorder.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(30, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Product Sale Breakdown Chart"
        '
        'dbpiechart
        '
        Me.dbpiechart.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.dbpiechart.ChartAreas.Add(ChartArea1)
        Me.dbpiechart.Cursor = System.Windows.Forms.Cursors.Arrow
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Legend1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.Gainsboro
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Legend1.ShadowOffset = 1
        Me.dbpiechart.Legends.Add(Legend1)
        Me.dbpiechart.Location = New System.Drawing.Point(0, 3)
        Me.dbpiechart.Name = "dbpiechart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.CustomProperties = "PieLabelStyle=Outside"
        Series1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Sale"
        Series1.ShadowOffset = 1
        Series1.XValueMember = "proname"
        Series1.YValueMembers = "total"
        Me.dbpiechart.Series.Add(Series1)
        Me.dbpiechart.Size = New System.Drawing.Size(798, 487)
        Me.dbpiechart.TabIndex = 0
        Me.dbpiechart.Text = "Chart1"
        '
        'pnlRound3
        '
        Me.pnlRound3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlRound3.Controls.Add(Me.IconPictureBox5)
        Me.pnlRound3.Controls.Add(Me.Label7)
        Me.pnlRound3.Controls.Add(Me.lblRunningLow)
        Me.pnlRound3.Controls.Add(Me.Label9)
        Me.pnlRound3.Controls.Add(Me.btnViewLow)
        Me.pnlRound3.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlRound3.Location = New System.Drawing.Point(75, 296)
        Me.pnlRound3.Name = "pnlRound3"
        Me.pnlRound3.Size = New System.Drawing.Size(325, 211)
        Me.pnlRound3.TabIndex = 140
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconPictureBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle
        Me.IconPictureBox5.IconColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.IconSize = 98
        Me.IconPictureBox5.Location = New System.Drawing.Point(37, 73)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(98, 98)
        Me.IconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox5.TabIndex = 30
        Me.IconPictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(171, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 46)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Running Low" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on Stocks"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRunningLow
        '
        Me.lblRunningLow.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.lblRunningLow.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunningLow.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblRunningLow.Location = New System.Drawing.Point(141, 73)
        Me.lblRunningLow.Name = "lblRunningLow"
        Me.lblRunningLow.Size = New System.Drawing.Size(162, 58)
        Me.lblRunningLow.TabIndex = 31
        Me.lblRunningLow.Text = "0046"
        Me.lblRunningLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(182, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 34)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Restock"
        '
        'btnViewLow
        '
        Me.btnViewLow.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnViewLow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewLow.FlatAppearance.BorderSize = 0
        Me.btnViewLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewLow.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewLow.ForeColor = System.Drawing.Color.White
        Me.btnViewLow.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnViewLow.IconColor = System.Drawing.Color.White
        Me.btnViewLow.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnViewLow.IconSize = 35
        Me.btnViewLow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnViewLow.Location = New System.Drawing.Point(19, 14)
        Me.btnViewLow.Name = "btnViewLow"
        Me.btnViewLow.Size = New System.Drawing.Size(116, 49)
        Me.btnViewLow.TabIndex = 138
        Me.btnViewLow.Text = "View"
        Me.btnViewLow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewLow.UseVisualStyleBackColor = False
        '
        'pnlRound2
        '
        Me.pnlRound2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlRound2.Controls.Add(Me.Label6)
        Me.pnlRound2.Controls.Add(Me.lblRevenue)
        Me.pnlRound2.Controls.Add(Me.IconPictureBox4)
        Me.pnlRound2.Controls.Add(Me.Label4)
        Me.pnlRound2.Location = New System.Drawing.Point(654, 62)
        Me.pnlRound2.Name = "pnlRound2"
        Me.pnlRound2.Size = New System.Drawing.Size(554, 211)
        Me.pnlRound2.TabIndex = 140
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(403, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Total Sales"
        '
        'lblRevenue
        '
        Me.lblRevenue.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblRevenue.Location = New System.Drawing.Point(249, 82)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(277, 58)
        Me.lblRevenue.TabIndex = 28
        Me.lblRevenue.Text = "0046"
        Me.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt
        Me.IconPictureBox4.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 116
        Me.IconPictureBox4.Location = New System.Drawing.Point(39, 58)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(119, 116)
        Me.IconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox4.TabIndex = 1
        Me.IconPictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(386, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 34)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Revenue"
        '
        'pnlRound
        '
        Me.pnlRound.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.pnlRound.Controls.Add(Me.Label5)
        Me.pnlRound.Controls.Add(Me.lblProduct)
        Me.pnlRound.Controls.Add(Me.Label1)
        Me.pnlRound.Controls.Add(Me.IconPictureBox2)
        Me.pnlRound.Location = New System.Drawing.Point(75, 62)
        Me.pnlRound.Name = "pnlRound"
        Me.pnlRound.Size = New System.Drawing.Size(554, 211)
        Me.pnlRound.TabIndex = 139
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(392, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Products Sold"
        '
        'lblProduct
        '
        Me.lblProduct.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduct.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblProduct.Location = New System.Drawing.Point(275, 82)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(260, 58)
        Me.lblProduct.TabIndex = 28
        Me.lblProduct.Text = "0046"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(452, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 34)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Sales"
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 116
        Me.IconPictureBox2.Location = New System.Drawing.Point(37, 59)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(119, 116)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox2.TabIndex = 0
        Me.IconPictureBox2.TabStop = False
        '
        'Timer1
        '
        '
        'dashboard1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1482, 853)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelMenu)
        Me.Name = "dashboard1"
        Me.Text = "dashboard1"
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.btnLogout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.pnlRound5.ResumeLayout(False)
        Me.pnlRound5.PerformLayout()
        CType(Me.IconPictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRound4.ResumeLayout(False)
        Me.pnlRound4.PerformLayout()
        CType(Me.dbpiechart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRound3.ResumeLayout(False)
        Me.pnlRound3.PerformLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRound2.ResumeLayout(False)
        Me.pnlRound2.PerformLayout()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRound.ResumeLayout(False)
        Me.pnlRound.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnBadorder As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMngUsers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSalesReport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSetIngredients As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPurchaseOrder As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCustomers As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSales As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditUser As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlRound As Panel
    Friend WithEvents pnlRound2 As Panel
    Friend WithEvents pnlRound4 As Panel
    Friend WithEvents pnlRound3 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblProduct As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblRunningLow As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dbpiechart As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlRound5 As Panel
    Friend WithEvents IconPictureBox6 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblExpired As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnViewLow As FontAwesome.Sharp.IconButton
    Friend WithEvents btnViewExp As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLogout As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnStockReports As FontAwesome.Sharp.IconButton
End Class
