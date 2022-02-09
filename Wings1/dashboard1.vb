Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting
Imports FontAwesome.Sharp
Imports MySql.Data.MySqlClient
Public Class dashboard1
    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Public Shared currentChildform As Form
    Public exingno As New DataTable
    Public exingno2 As Integer = 0
    Public rest2 As Integer = 0
    Public rest As New DataTable


    Dim Pos As Point
    Private Sub Panel2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    'Methods
    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(40, 40, 43)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

        End If
    End Sub

    Private Sub OpenChildForm(childform As Form)
        'Open form'
        If currentChildform IsNot Nothing Then
            currentChildform.Dispose()
            currentChildform.Close()
        End If
        currentChildform = childform
        ''
        childform.TopLevel = False
        childform.FormBorderStyle = FormBorderStyle.None
        childform.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childform)
        PanelDesktop.Tag = childform
        childform.BringToFront()
        childform.Show()
        lblFormTitle.Text = childform.Text
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(52, 52, 52)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub dashboard1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim userinfo As New DataTable()
        gettable("select user, concat(fname,' ',lname) as name from users where user='" & LoginForm.UserTb.Text.ToString & "' ", userinfo)
        btnEditUser.Text = userinfo.Rows(0)(1).ToString
        If LoginForm.UserTb.Text = "admin" Then
            btnMngUsers.Visible = True
        Else
            btnMngUsers.Visible = False
        End If
        Timer1.Enabled = True
        roundPanel(pnlRound)
        roundPanel(pnlRound2)
        roundPanel(pnlRound3)
        roundPanel(pnlRound4)
        roundPanel(pnlRound5)
        roundBtn(btnEditUser)
        roundBtn(btnBadorder)
        roundBtn(btnViewLow)
        roundBtn(btnViewExp)

        'chart'
        Dim piee As New DataSet
        getset("select proname, sum(squantity) as total from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & Date.Now.Month & "' group by proname", piee)
        If piee.Tables(0).Rows.Count > 0 Then
            With dbpiechart
                .Series(0).Points.Clear()
                .DataSource = piee
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).LegendText = "#VALX (#PERCENT)"
            End With
        Else
            dbpiechart.Series(0).Points.AddXY("No records so far this month yet", 1)
        End If

        'labels'
        Dim lblrev, lblsold, lblrestock, lblexpire As New DataTable
        'revenue
        gettable("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "'and month(sale_date)='" & Date.Now.Month & "'", lblrev)
        If Not DBNull.Value.Equals(lblrev.Rows(0)(0)) Then
            lblRevenue.Text = lblrev.Rows(0)(0)
            lblRevenue.Text = "PHP" + Format(Val(lblRevenue.Text), "0.00")
        Else
            lblRevenue.Text = "PHP0.00"
        End If
        'products sold
        gettable("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & Date.Now.Month & "'", lblsold)
        If Not DBNull.Value.Equals(lblsold.Rows(0)(0)) Then
            lblProduct.Text = lblsold.Rows(0)(0)
        Else
            lblProduct.Text = "0"
        End If
        'running low
        gettable("select count(*) from ingredients where ing_stock<=20", lblrestock)
        If lblrestock.Rows(0)(0) > 0 Then
            Label9.Text = "Restock"
            lblRunningLow.Text = lblrestock.Rows(0)(0)
        Else
            Label9.Text = "All good"
            lblRunningLow.Text = 0
        End If
        'expired
        gettable("select count(*) from expired where it_status='unchecked'", lblexpire)
        If lblexpire.Rows(0)(0) > 0 Then
            lblExpired.Text = lblexpire.Rows(0)(0)
        Else
            lblExpired.Text = "0"
        End If

        Dim inval As New DataTable
        gettable("select * from invaluetbl where invDate='" & Date.Now.ToString("yyyy/MM/dd") & "'", inval)
        If inval.Rows.Count = 0 Then
            Dim totalInv As New DataTable
            gettable("select sum(ing_price*ing_stock) as total from ingredients", totalInv)
            If Not DBNull.Value.Equals(totalInv.Rows(0)(0)) Then
                create2("insert into invaluetbl(inValue,invDate) values('" & totalInv.Rows(0)(0).ToString & "', '" & Date.Now.ToString("yyyy/MM/dd") & "')")
            Else
                create2("insert into invaluetbl(inValue,invDate) values('0', '" & Date.Now.ToString("yyyy/MM/dd") & "')")
            End If
        End If


    End Sub

    'Events
    Private Sub btnPos_Click(sender As Object, e As EventArgs) Handles btnPos.Click
        ActivateButton(sender, Color.Gold)
        If lblFormTitle.Text = "Point of Sale" Then
            currentChildform.Dispose()
            OpenChildForm(AddSale)
        Else
            OpenChildForm(AddSale)
        End If

    End Sub

    Private Sub btnPurchaseOrder_Click(sender As Object, e As EventArgs) Handles btnPurchaseOrder.Click
        ActivateButton(sender, RGBColors.color2)
        If lblFormTitle.Text = "Purchase Order" Then
            currentChildform.Dispose()
            OpenChildForm(PurchaseOrderForm)
        Else
            OpenChildForm(PurchaseOrderForm)
        End If
    End Sub

    Private Sub btnSetIngredients_Click(sender As Object, e As EventArgs) Handles btnSetIngredients.Click
        ActivateButton(sender, RGBColors.color3)
        If lblFormTitle.Text = "Set Ingredients" Then
            currentChildform.Dispose()
            OpenChildForm(Addingredient)
        Else
            OpenChildForm(Addingredient)
        End If
    End Sub

    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        ActivateButton(sender, RGBColors.color5)
        If lblFormTitle.Text = "Sale Reports" Then
            currentChildform.Dispose()
            OpenChildForm(Salesreport)
        Else
            OpenChildForm(Salesreport)
        End If
    End Sub

    Private Sub btnAccSettings_Click(sender As Object, e As EventArgs) Handles btnMngUsers.Click
        ActivateButton(sender, RGBColors.color6)
        If lblFormTitle.Text = "Manage Users" Then
            currentChildform.Dispose()
            OpenChildForm(manageuser)
        Else
            OpenChildForm(manageuser)
        End If
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ActivateButton(sender, RGBColors.color4)
        If currentChildform IsNot Nothing Then
            currentChildform.Close()
        End If
        leftBorderBtn.Visible = False
        lblFormTitle.Text = btnDashboard.Text
        'chart'
        Dim piee As New DataSet
        getset("select proname, sum(squantity) as total from sales where month(sale_date)='" & Date.Now.Month & "' group by proname", piee)
        If piee.Tables(0).Rows.Count > 0 Then
            With dbpiechart
                .Series(0).Points.Clear()
                .DataSource = piee
                .Series(0).LabelFormat = "{#,##0}"
                .Series(0).LegendText = "#VALX (#PERCENT)"
            End With
        Else
            dbpiechart.Series(0).Points.AddXY("No records so far this month yet", 1)
        End If

        'labels'
        Dim lblrev, lblsold, lblrestock, lblexpire As New DataTable
        'revenue
        gettable("select sum(stotal) from sales where month(sale_date)='" & Date.Now.Month & "'", lblrev)
        If Not DBNull.Value.Equals(lblrev.Rows(0)(0)) Then
            lblRevenue.Text = lblrev.Rows(0)(0)
            lblRevenue.Text = "PHP" + Format(Val(lblRevenue.Text), "0.00")
        Else
            lblRevenue.Text = "PHP0.00"
        End If
        'products sold
        gettable("select sum(squantity) from sales where month(sale_date)='" & Date.Now.Month & "'", lblsold)
        If Not DBNull.Value.Equals(lblsold.Rows(0)(0)) Then
            lblProduct.Text = lblsold.Rows(0)(0)
        Else
            lblProduct.Text = "0"
        End If
        'running low
        gettable("select count(*) from ingredients where ing_stock<=20", lblrestock)
        If lblrestock.Rows(0)(0) > 0 Then
            Label9.Text = "Restock"
            lblRunningLow.Text = lblrestock.Rows(0)(0)
        Else
            Label9.Text = "All good"
            lblRunningLow.Text = 0
        End If
        'expired
        gettable("select count(*) from expired where it_status='unchecked'", lblexpire)
        If lblexpire.Rows(0)(0) > 0 Then
            lblExpired.Text = lblexpire.Rows(0)(0)
        Else
            lblExpired.Text = "0"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If currentChildform IsNot Nothing Then
            currentChildform.Close()
        End If
        Reset()
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        lblFormTitle.Text = "Dashboard"
    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
        Dim ans As DialogResult
        ans = MessageBox.Show("Are you sure you want to close program?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ans = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Public rescount As Integer = 1
    Public exscount As Integer = 1
    Public critconfirm As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("yyyy/MM/dd hh:mm:ss tt")
        Dim checkexp, checking, resty, exingnoy As New DataTable
        Dim todd As String = Date.Now.ToString("yyyy/MM/dd")
        gettable("select sub_id,in_id,in_ex,in_stock,in_rec from subitem where date(in_ex) <= date'" & todd & "'", checkexp)
        gettable("select * from ingredients where ing_stock<> 0 AND ex_date<='" & todd & "'", checking)
        gettable("select count(*) from ingredients where ing_stock<=20", resty)
        gettable("select count(*) from expired where it_status='unchecked'", exingnoy)
        If checkexp.Rows.Count() > 0 Then
            For i As Integer = 0 To checkexp.Rows.Count() - 1
                exscount = 1
                Dim indat As New DataTable
                gettable("select * from ingredients where ing_id='" & checkexp.Rows(i)(1).ToString & "'", indat)
                Dim itid As String = indat.Rows(0)(0).ToString
                Dim itname As String = indat.Rows(0)(1).ToString
                Dim itprice As String = indat.Rows(0)(3).ToString
                Dim itstatus As String = "unchecked"
                Dim itunit As String = indat.Rows(0)(5).ToString
                Dim itstock As String = checkexp.Rows(i)(3).ToString
                Dim itrate As String = indat.Rows(0)(7).ToString
                Dim drec As Date = Convert.ToDateTime(checkexp.Rows(i)(4).ToString)
                Dim itrec As String = drec.ToString("yyyy/MM/dd")
                Dim dex As Date = Convert.ToDateTime(checkexp.Rows(i)(2).ToString)
                Dim itex As String = dex.ToString("yyyy/MM/dd")
                Dim itsup As String = indat.Rows(0)(10).ToString
                create2("insert into expired(it_id,it_name,it_price,it_status,it_unit,it_stock,it_rate,it_rec,it_ex,supply) values('" & itid & "','" & itname & "','" & itprice & "','" & itstatus & "','" & itunit & "','" & itstock & "','" & itrate & "','" & itrec & "','" & itex & "','" & itsup & "')")
                updated2("update ingredients set ing_stock=ing_stock-'" & itstock & "' where ing_id='" & itid & "'")
                delete2("delete from subitem where sub_id='" & checkexp.Rows(i)(0).ToString & "'")
                'Refresh lbl'
                Dim lblexpire As New DataTable
                gettable("select count(*) from expired where it_status='unchecked'", lblexpire)
                If lblexpire.Rows(0)(0) > 0 Then
                    lblExpired.Text = lblexpire.Rows(0)(0)
                Else
                    lblExpired.Text = "0"
                End If
            Next
        End If

        If checking.Rows.Count() > 0 Then
            For ii As Integer = 0 To checking.Rows.Count() - 1
                Dim itid As String = checking.Rows(ii)(0).ToString
                Dim itname As String = checking.Rows(ii)(1).ToString
                Dim itprice As String = checking.Rows(ii)(3).ToString
                Dim itstatus As String = "unchecked"
                Dim itunit As String = checking.Rows(ii)(5).ToString
                Dim itstock As String = checking.Rows(ii)(6).ToString
                Dim itrate As String = checking.Rows(ii)(7).ToString
                Dim ddrec As Date = Convert.ToDateTime(checking.Rows(ii)(8).ToString)
                Dim itrec As String = ddrec.ToString("yyyy/MM/dd")
                Dim ddex As Date = Convert.ToDateTime(checking.Rows(ii)(9).ToString)
                Dim itex As String = ddex.ToString("yyyy/MM/dd")
                Dim itsup As String = checking.Rows(ii)(10).ToString
                If itstock > 0 Then
                    exscount = 1
                    create2("insert into expired(it_id,it_name,it_price,it_status,it_unit,it_stock,it_rate,it_rec,it_ex,supply) values('" & itid & "','" & itname & "','" & itprice & "','" & itstatus & "','" & itunit & "','" & itstock & "','" & itrate & "','" & itrec & "','" & itex & "','" & itsup & "')")
                    updated2("update ingredients set ing_stock=0, ing_status='Unavilable' where ing_id='" & itid & "'")
                    'Refresh lbl'
                    Dim lblexpire As New DataTable
                    gettable("select count(*) from expired where it_status='unchecked'", lblexpire)
                    If lblexpire.Rows(0)(0) > 0 Then
                        lblExpired.Text = lblexpire.Rows(0)(0)
                    Else
                        lblExpired.Text = "0"
                    End If
                End If
            Next
        End If

        If resty.Rows(0)(0) > 0 Then
            If rescount > 0 Then
                'Refresh restock lbl'
                rest2 = resty.Rows(0)(0)
                notifbar.Show()
                rescount = 0
            End If
        End If

        If exingnoy.Rows(0)(0) > 0 Then
            If exscount > 0 Then
                exingno2 = exingnoy.Rows(0)(0)
                notifbarRed.Show()
                exscount = 0
                critconfirm = 0
            End If
        End If

        If exscount > 0 And critconfirm > 0 Then
            notifbarRed.Show()
            exscount = 0
            critconfirm = 0
        End If
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        ActivateButton(sender, Color.FromArgb(255, 128, 0))
        If lblFormTitle.Text = "Inventory" Then
            currentChildform.Dispose()
            OpenChildForm(Productform)
        Else
            OpenChildForm(Productform)
        End If
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        ActivateButton(sender, Color.LimeGreen)
        If lblFormTitle.Text = "Sales" Then
            currentChildform.Dispose()
            OpenChildForm(Salesform)
        Else
            OpenChildForm(Salesform)
        End If

    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        ActivateButton(sender, Color.FromArgb(224, 86, 253))
        If lblFormTitle.Text = "Customers" Then
            currentChildform.Dispose()
            OpenChildForm(CustomerForm)
        Else
            OpenChildForm(CustomerForm)
        End If
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        If btnMngUsers.Visible = True Then

        Else
            Dim RC As Rectangle = Me.RectangleToScreen(Me.ClientRectangle)
            Dim bmp As New Bitmap(RC.Width, RC.Height)
            Using G As Graphics = Graphics.FromImage(bmp)
                G.CopyFromScreen(RC.Location, New Point(0, 0), RC.Size)
                Using brsh As New SolidBrush(Color.FromArgb(128, Color.Black))
                    G.FillRectangle(brsh, Me.ClientRectangle)
                End Using
            End Using
            editaccount.Show()
        End If

    End Sub

    Private Sub btnBadorder_Click(sender As Object, e As EventArgs) Handles btnBadorder.Click
        BadOrder.Show()
    End Sub

    Private Sub btnViewExp_Click(sender As Object, e As EventArgs) Handles btnViewExp.Click
        Expiredform.Show()
    End Sub

    Private Sub btnViewLow_Click(sender As Object, e As EventArgs) Handles btnViewLow.Click
        Lowstock.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim ans As DialogResult
        ans = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ans = DialogResult.Yes Then
            Me.Close()
            LoginForm.UserTb.Text = "Username"
            LoginForm.PasswordTb.Text = "Password"
            LoginForm.PasswordTb.isPassword = False
            LoginForm.UserTb.ForeColor = Color.DarkGray
            LoginForm.PasswordTb.ForeColor = Color.DarkGray
            LoginForm.ActiveControl = Nothing
            LoginForm.Show()
        End If
    End Sub

    Private Sub btnStockReports_Click(sender As Object, e As EventArgs) Handles btnStockReports.Click
        ActivateButton(sender, RGBColors.color5)
        If lblFormTitle.Text = "Stock Reports" Then
            currentChildform.Dispose()
            OpenChildForm(stocklogform)
        Else
            OpenChildForm(stocklogform)
        End If
    End Sub
End Class