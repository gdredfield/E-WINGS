Imports MySql.Data.MySqlClient
Public Class Productform


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        If LoginForm.UserTb.Text = "admin" Then
            gett("select count(*) from product where prod_status='Available'", Inventoryform2.Label14)
            Inventoryform2.Show()
        Else
            gett("select count(*) from product where prod_status='Available'", Inventoryform.Label14)
            Inventoryform.Show()
        End If
    End Sub

    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        prodcb.Text = "Default"
        ingcb.Text = "Default"
        istatuscb.Text = "Available"
        statuscb.Text = "Available"
        searchcb.Text = "Name"
        searchcb2.Text = "Name"
        idate.Format = DateTimePickerFormat.Custom
        idate.CustomFormat = "dd/MM/yyyy"
        datetb.Format = DateTimePickerFormat.Custom
        datetb.CustomFormat = "dd/MM/yyyy"
        Try
            'load new ids'
            gett("select MAX(prod_id)+'1' from product", idtb)
            gett("select MAX(ing_id)+'1' from ingredients", iidtb)
            'load all table data'
            reload("Select * from product", dtglist)
            reload("Select * from ingredients", dtglist2)
            'search textboxes'
            reload("select * from product where concat(prod_id, prod_name, prodesc, prod_price, prod_stock) like '%" & searchbox.Text & "%'", dtglist)
            reload("select * from ingredients where concat(ing_id, ing_name, ing_desc, ing_price, ing_stock) like '%" & isearch.Text & "%'", dtglist2)
            Dim con As New connection()
            Dim command As New MySqlCommand("select * from category", con.getconn())
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            typecb.DataSource = table
            typecb.DisplayMember = "prod_type"
            typecb.ValueMember = "prod_type"
            idate.Value = DateTime.Now()
            datetb.Value = DateTime.Now()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'refresh button'
        Try
            reload("Select * from product", dtglist)
            reload("Select * from category", typecb)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'create'
        Dim pricet, stockt As Integer
        Dim namet As New DataTable
        gettable("select * from product where prod_name='" & nametb.Text & "'", namet)
        If nametb.Text = "" Then
            MessageBox.Show("Please enter a product name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf desctb.Text = "" Then
            MessageBox.Show("Please enter a product description.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf pricetb.Text = "" Then
            MessageBox.Show("Please enter a product price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf pricetb.Text < 1 Then
            MessageBox.Show("Please enter valid product price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text = "" Then
            MessageBox.Show("Please enter stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text < 1 Then
            MessageBox.Show("Please enter valid stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate product names'
        ElseIf namet.Rows.Count() > 0 Then
            MessageBox.Show(nametb.Text + " already exists." & vbCrLf & "Please enter different product name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(pricetb.Text, pricet) Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(stocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                Dim pstock As Integer
                Integer.TryParse(stocktb.Text, pstock)
                'checking if stock is less than 1 to switch status to unavailable'
                If pstock < 1 Then
                    create("INSERT INTO `product`(`prod_name`, `prodesc`, `prod_price`, `prod_type`, `prod_stock`, `prod_status`,`prod_date`) VALUES('" & nametb.Text & "','" & desctb.Text & "','" & pricetb.Text & "','" & typecb.Text & "','" & stocktb.Text & "','Unavailable','" & datetb.Value.ToString("yyyy/MM/dd") & "')")
                Else
                    create("INSERT INTO `product`(`prod_name`, `prodesc`, `prod_price`, `prod_type`, `prod_stock`, `prod_status`,`prod_date`) VALUES('" & nametb.Text & "','" & desctb.Text & "','" & pricetb.Text & "','" & typecb.Text & "','" & stocktb.Text & "','Available','" & datetb.Value.ToString("yyyy/MM/dd") & "')")
                End If
                idtb.Text = ""
                nametb.Text = ""
                desctb.Text = ""
                pricetb.Text = ""
                stocktb.Text = ""
                typecb.Text = "Available"
                reload("Select * from product", dtglist)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'delete product'
        Try
            Dim ans As DialogResult
            ans = MessageBox.Show("Are you sure to delete product record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                delete("delete from product where prod_id='" & idtb.Text & "'")
                reload("Select * from product", dtglist)
                gett("select MAX(prod_id)+'1' from product", idtb)
                nametb.Text = ""
                desctb.Text = ""
                pricetb.Text = ""
                stocktb.Text = ""
                statuscb.Text = "Available"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'new product'
        Try
            gett("select MAX(prod_id)+'1' from product", idtb)
            nametb.Text = ""
            desctb.Text = ""
            pricetb.Text = ""
            stocktb.Text = ""
            statuscb.Text = "Available"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        'update'
        Dim namet As New DataTable
        gettable("select * from product where prod_name='" & nametb.Text & "' and prod_id <> '" & idtb.Text & "'", namet)
        Dim pricet, stockt As Integer
        If nametb.Text = "" Then
            MessageBox.Show("Please enter a product name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf desctb.Text = "" Then
            MessageBox.Show("Please enter a product description.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf pricetb.Text = "" Then
            MessageBox.Show("Please enter a product price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf pricetb.Text < 1 Then
            MessageBox.Show("Please enter valid product price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text = "" Then
            MessageBox.Show("Please enter stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text < 1 Then
            MessageBox.Show("Please enter valid value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate product names'
        ElseIf namet.Rows.Count() > 0 Then
            MessageBox.Show(nametb.Text + " already exists." & vbCrLf & "Please enter different product name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(pricetb.Text, pricet) Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(stocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                updated("UPDATE product set prod_name='" & nametb.Text & "', prodesc='" & desctb.Text & "', prod_price='" & pricetb.Text & "', prod_type='" & typecb.Text & "', prod_stock='" & stocktb.Text & "',prod_status='" & statuscb.Text & "',prod_date='" & datetb.Value.ToString("yyyy/MM/dd") & "' where prod_id='" & idtb.Text & "'")
                'updating sales total amounts for that product if user changes the price'
                Dim saleup As New DataTable
                gettable("select * from sales where prodid = '" & idtb.Text & "'", saleup)
                If saleup.Rows.Count() > 0 Then
                    updated2("update sales set stotal='" & pricetb.Text & "'*squantity where prodid = '" & idtb.Text & "'")
                End If
                'selecting all products that are unavailable'
                Dim prodt As New DataTable
                Dim prodt2 As New DataTable
                gettable("select * from product where prod_stock>0 and prod_status='Unavailable'", prodt)
                gettable("select * from product where prod_stock<1", prodt2)
                'updating all products to available if their stock is not 0 anymore'
                For i As Integer = 0 To prodt.Rows.Count() - 1
                    updated2("update product set prod_status='Available' where prod_id='" & prodt.Rows(i)(0) & "'")
                Next
                'updating all products to unavailable if their stock less than 1'
                If prodt2.Rows.Count() > 0 Then
                    updated2("update product set prod_status='Unavailable' where prod_stock<1")
                End If
                idtb.Text = ""
                nametb.Text = ""
                desctb.Text = ""
                pricetb.Text = ""
                stocktb.Text = ""
                typecb.Text = "Available"
                reload("Select * from product", dtglist)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Addproductype.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Try
            reload("select * from product where concat(prod_id, prod_name, prodesc, prod_price, prod_stock) like '%" & searchbox.Text & "%'", dtglist)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        'search by cb'
        Try
            If searchcb.Text = "ID" Then
                reload("select * from product where concat(prod_id) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Name" Then
                reload("select * from product where concat(prod_name) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Price" Then
                reload("select * from product where concat(prod_price) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Type" Then
                reload("select * from product where concat(prod_type) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Stocks" Then
                reload("select * from product where concat(prod_stock) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Date" Then
                reload("select * from product where concat(prod_date) like '%" & searchbox.Text & "%'", dtglist)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'create ingredient'
        Dim pricet, ratet, stockt As Integer
        Dim inamet As New DataTable
        gettable("select * from ingredients where ing_name='" & inametb.Text & "'", inamet)
        If inametb.Text = "" Then
            MessageBox.Show("Please enter a ingredient name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf idesctb.Text = "" Then
            MessageBox.Show("Please enter a ingredient description.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ipricetb.Text = "" Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ipricetb.Text < 1 Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf unittb.Text = "" Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf istocktb.Text = "" Then
            MessageBox.Show("Please enter a stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf istocktb.Text < 1 Then
            MessageBox.Show("Please enter a stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf iratetb.Text = "" Then
            MessageBox.Show("Please enter a consumption rate.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf iratetb.Text < 1 Then
            MessageBox.Show("Please enter a consumption rate.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate ingredient names'
        ElseIf inamet.Rows.Count() > 0 Then
            MessageBox.Show(inametb.Text + " already exists." & vbCrLf & "Please enter different ingredient name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(ipricetb.Text, pricet) Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(istocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(iratetb.Text, ratet) Then
            MessageBox.Show("Please enter a valid consumption rate value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim istock As Integer
                Integer.TryParse(istocktb.Text, istock)
                'checking if stock is less than 1 to switch status to unavailable'
                If istock < 1 Then
                    create("insert into ingredients(ing_name,ing_desc,ing_price,ing_status,ing_unit,ing_stock,ing_rate,ing_date) values('" & inametb.Text & "','" & idesctb.Text & "','" & ipricetb.Text & "','Unavailable','" & unittb.Text & "','" & istocktb.Text & "','" & iratetb.Text & "','" & idate.Value.ToString("yyyy/MM/dd") & "')")
                Else
                    create("insert into ingredients(ing_name,ing_desc,ing_price,ing_status,ing_unit,ing_stock,ing_rate,ing_date) values('" & inametb.Text & "','" & idesctb.Text & "','" & ipricetb.Text & "','Available','" & unittb.Text & "','" & istocktb.Text & "','" & iratetb.Text & "','" & idate.Value.ToString("yyyy/MM/dd") & "')")
                End If
                iidtb.Text = ""
                inametb.Text = ""
                idesctb.Text = ""
                ipricetb.Text = ""
                unittb.Text = ""
                istocktb.Text = ""
                iratetb.Text = ""
                istatuscb.Text = "Available"
                reload("Select * from ingredients", dtglist2)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            reload("Select * from ingredients", dtglist2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'new ingredient'
        Try
            gett("select MAX(ing_id)+'1' from ingredients", iidtb)
            inametb.Text = ""
            idesctb.Text = ""
            ipricetb.Text = ""
            istatuscb.Text = "Available"
            unittb.Text = ""
            istocktb.Text = ""
            iratetb.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'delete ingredient'
        Try
            Dim ans As DialogResult
            ans = MessageBox.Show("Are you sure to delete ingredient record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                delete("delete from ingredients where ing_id='" & iidtb.Text & "'")
                reload("select * from ingredients", dtglist2)
                gett("select MAX(ing_id)+'1' from ingredients", iidtb)
                inametb.Text = ""
                idesctb.Text = ""
                ipricetb.Text = ""
                istatuscb.Text = "Available"
                unittb.Text = ""
                istocktb.Text = ""
                iratetb.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'update ingredient'
        Dim pricet, ratet, stockt As Integer
        Dim inamet As New DataTable
        gettable("select * from ingredients where ing_name='" & inametb.Text & "' and ing_id<>'" & iidtb.Text & "'", inamet)
        If inametb.Text = "" Then
            MessageBox.Show("Please enter a ingredient name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf idesctb.Text = "" Then
            MessageBox.Show("Please enter a ingredient description.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ipricetb.Text = "" Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ipricetb.Text < 1 Then
            MessageBox.Show("Please enter valid ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf unittb.Text = "" Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf istocktb.Text = "" Then
            MessageBox.Show("Please enter a stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf istocktb.Text < 1 Then
            MessageBox.Show("Please enter valid stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf iratetb.Text = "" Then
            MessageBox.Show("Please enter a consumption rate.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf iratetb.Text < 1 Then
            MessageBox.Show("Please enter valid consumption rate.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate ingredient names'
        ElseIf inamet.Rows.Count() > 0 Then
            MessageBox.Show(inametb.Text + " already exists." & vbCrLf & "Please enter different ingredient name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(ipricetb.Text, pricet) Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(istocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(iratetb.Text, ratet) Then
            MessageBox.Show("Please enter a valid consumption rate value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                'updating ingredients'
                updated("update ingredients set ing_name='" & inametb.Text & "',ing_desc='" & idesctb.Text & "',ing_price='" & ipricetb.Text & "',ing_status='" & istatuscb.Text & "',ing_unit='" & unittb.Text & "',ing_stock='" & istocktb.Text & "',ing_rate='" & iratetb.Text & "',ing_date='" & idate.Value.ToString("yyyy/MM/dd") & "' where ing_id='" & iidtb.Text & "'")
                'selecting all ingredients that are unavailable'
                Dim ingd As New DataTable
                Dim ingd2 As New DataTable
                gettable("select * from ingredients where ing_stock>0 and ing_status='Unavailable'", ingd)
                gettable("select * from ingredients where ing_stock<1", ingd2)
                'updating all ingredients to available if their stock is not 0 anymore'
                For i As Integer = 0 To ingd.Rows.Count() - 1
                    updated2("update ingredients set ing_status='Available' where ing_id='" & ingd.Rows(i)(0) & "'")
                Next
                'updating all ingredients to unavailable if their stock less than 1'
                If ingd2.Rows.Count() > 0 Then
                    updated2("update ingredients set ing_status='Unavailable' where ing_stock<1")
                End If
                iidtb.Text = ""
                inametb.Text = ""
                idesctb.Text = ""
                ipricetb.Text = ""
                unittb.Text = ""
                istocktb.Text = ""
                iratetb.Text = ""
                istatuscb.Text = "Available"
                reload("select * from ingredients", dtglist2)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        Try
            reload("select * from ingredients where concat(ing_id, ing_name, ing_desc, ing_price, ing_stock) like '%" & isearch.Text & "%'", dtglist2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)
        Try
            reload("select * from ingredients", dtglist2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtglist2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist2.CellClick
        iidtb.Text = dtglist2.CurrentRow.Cells(0).Value
        inametb.Text = dtglist2.CurrentRow.Cells(1).Value
        idesctb.Text = dtglist2.CurrentRow.Cells(2).Value
        ipricetb.Text = dtglist2.CurrentRow.Cells(3).Value
        istatuscb.Text = dtglist2.CurrentRow.Cells(4).Value
        unittb.Text = dtglist2.CurrentRow.Cells(5).Value
        istocktb.Text = dtglist2.CurrentRow.Cells(6).Value
        iratetb.Text = dtglist2.CurrentRow.Cells(7).Value
    End Sub

    Private Sub dtglist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellClick
        idtb.Text = dtglist.CurrentRow.Cells(0).Value
        nametb.Text = dtglist.CurrentRow.Cells(1).Value
        desctb.Text = dtglist.CurrentRow.Cells(2).Value
        pricetb.Text = dtglist.CurrentRow.Cells(3).Value
        typecb.Text = dtglist.CurrentRow.Cells(4).Value
        stocktb.Text = dtglist.CurrentRow.Cells(5).Value
        statuscb.Text = dtglist.CurrentRow.Cells(7).Value
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) 
        Addingredient.Show()
    End Sub

    Private Sub prodcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles prodcb.SelectionChangeCommitted
        If prodcb.Text = "Name" Then
            reload("select * from product ORDER BY prod_name ASC", dtglist)
        ElseIf prodcb.Text = "Price" Then
            reload("select * from product ORDER BY prod_price ASC", dtglist)
        ElseIf prodcb.Text = "Date" Then
            reload("select * from product ORDER BY prod_date desc", dtglist)
        ElseIf prodcb.Text = "Stock" Then
            reload("select * from product ORDER BY prod_stock ASC", dtglist)
        ElseIf prodcb.text = "Default" Then
            reload("select * from product", dtglist)
        End If
    End Sub

    Private Sub ingcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ingcb.SelectionChangeCommitted
        If ingcb.Text = "Name" Then
            reload("select * from ingredients ORDER BY ing_name ASC", dtglist2)
        ElseIf ingcb.Text = "Price" Then
            reload("select * from ingredients ORDER BY ing_price ASC", dtglist2)
        ElseIf ingcb.Text = "Date" Then
            reload("select * from ingredients ORDER BY ing_date desc", dtglist2)
        ElseIf ingcb.Text = "Stock" Then
            reload("select * from ingredients ORDER BY ing_stock ASC", dtglist2)
        ElseIf ingcb.Text = "Default" Then
            reload("select * from ingredients", dtglist2)
        End If
    End Sub

    Private Sub isearch_TextChanged(sender As Object, e As EventArgs) Handles isearch.TextChanged
        If searchcb2.Text = "ID" Then
            reload("select * from ingredients where concat(ing_id) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Name" Then
            reload("select * from ingredients where concat(ing_name) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Price" Then
            reload("select * from ingredients where concat(ing_price) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Type" Then
            reload("select * from ingredients where concat(ing_type) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Stocks" Then
            reload("select * from ingredients where concat(ing_stock) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Date" Then
            reload("select * from ingredients where concat(ing_date) like '%" & isearch.Text & "%'", dtglist2)
        End If
    End Sub

End Class