Imports MySql.Data.MySqlClient

Public Class AddSale
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        If LoginForm.UserTb.Text = "admin" Then
            gett("select fname from users where user='" & LoginForm.UserTb.Text & "'", Inventoryform2.Label4)
            gett("select count(*) from product where prod_stock<=10", Inventoryform2.Label23)
            gett("select count(*) from ingredients where ing_stock<=10", Inventoryform2.Label24)
            Inventoryform2.Label21.Text = "- (" + Inventoryform2.Label23.Text + ") Products"
            Inventoryform2.Label22.Text = "- (" + Inventoryform2.Label24.Text + ") Ingredients"
            gett("select count(*) from product where prod_status='Available'", Inventoryform2.Label14)
            gett("select count(*) from sales where month(sale_date)='" & DateTime.Now.ToString("MM") & "'", Inventoryform2.Label13)
            gett("select sum(stotal) from sales where month(sale_date)='" & DateTime.Now.ToString("MM") & "'", Inventoryform2.Label27)
            Inventoryform2.Label27.Text = Format(Val(Inventoryform2.Label27.Text), "0.00")
            Inventoryform2.Label20.Text = "₱" + Inventoryform2.Label27.Text
            Inventoryform2.Show()
        Else
            gett("select fname from users where user='" & LoginForm.UserTb.Text & "'", Inventoryform.Label4)
            gett("select count(*) from product where prod_stock<=10", Inventoryform.Label23)
            gett("select count(*) from ingredients where ing_stock<=10", Inventoryform.Label24)
            Inventoryform.Label21.Text = "- (" + Inventoryform.Label23.Text + ") Products"
            Inventoryform.Label22.Text = "- (" + Inventoryform.Label24.Text + ") Ingredients"
            gett("select count(*) from product where prod_status='Available'", Inventoryform.Label14)
            gett("select count(*) from sales where month(sale_date)='" & DateTime.Now.ToString("MM") & "'", Inventoryform.Label13)
            gett("select sum(stotal) from sales where month(sale_date)='" & DateTime.Now.ToString("MM") & "'", Inventoryform.Label27)
            Inventoryform.Label27.Text = Format(Val(Inventoryform.Label27.Text), "0.00")
            Inventoryform.Label20.Text = "₱" + Inventoryform.Label27.Text
            Inventoryform.Show()
        End If
    End Sub
    Public table As New DataTable("Table")
    Private Sub AddSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Timer1.Enabled = True
        searchcb.Text = "Name"
        idtb.Text = "No product selected"
        nametb.Text = "-"
        pricetb.Text = "-"
        stocktb.Text = "-"
        statuscb.Text = "-"
        typecb.Text = "-"
        ' product queue table '
        table.Columns.Add("Product ID", Type.GetType("System.Int32"))
        table.Columns.Add("Product", Type.GetType("System.String"))
        table.Columns.Add("Quantity", Type.GetType("System.Int32"))
        table.Columns.Add("Amount", Type.GetType("System.Double"))
        prodq.DataSource = table
        prodq.Columns(0).Visible = False
        Try
            'only available products are shown'
            reload("Select * from product where prod_status='Available'", dtglist4)
            Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
            Dim con As New connection()
            Dim command As New MySqlCommand("Select * from category", con.getconn())
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim cust As New DataTable()
            gettable("select custom_id from customer", cust)
            custommcb.DataSource = cust
            custommcb.DisplayMember = "custom_id"
            custommcb.ValueMember = "custom_id"
            custommcb.Text = "10"
            Dim custt As New DataTable()
            gettable("select fname,lname from customer where custom_id='" & custommcb.Text & "'", custt)
            custname.Text = custt.Rows(0)(0).ToString() + " " + custt.Rows(0)(1).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.message)
        End Try
    End Sub


    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles quantitytb.TextChanged
        Try
            Dim price, quantity, total As Double
            Double.TryParse(pricetb.Text, price)
            Double.TryParse(quantitytb.Text, quantity)
            total = price * quantity
            totaltb.Text = total.ToString("N2")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dtglist4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist4.CellClick
        idtb.Text = dtglist4.CurrentRow.Cells(0).Value
        nametb.Text = dtglist4.CurrentRow.Cells(1).Value
        pricetb.Text = dtglist4.CurrentRow.Cells(3).Value
        typecb.Text = dtglist4.CurrentRow.Cells(4).Value
        stocktb.Text = dtglist4.CurrentRow.Cells(5).Value
        statuscb.Text = dtglist4.CurrentRow.Cells(7).Value

        Dim price, quantity, total As Double
        Double.TryParse(pricetb.Text, price)
        Double.TryParse(quantitytb.Text, quantity)
        total = price * quantity
        totaltb.Text = total.ToString("N2")
    End Sub

    Private Sub searchtb_TextChanged(sender As Object, e As EventArgs) Handles searchtb.TextChanged
        Try
            If searchcb.Text = "ID" Then
                reload("Select * from product where concat(prod_id) Like '%" & searchtb.Text & "%' and prod_status='Available'", dtglist4)
            ElseIf searchcb.Text = "Name" Then
                reload("select * from product where concat(prod_name) like '%" & searchtb.Text & "%' and prod_status='Available'", dtglist4)
            ElseIf searchcb.Text = "Price" Then
                reload("select * from product where concat(prod_price) like '%" & searchtb.Text & "%' and prod_status='Available'", dtglist4)
            ElseIf searchcb.Text = "Type" Then
                reload("select * from product where concat(prod_type) like '%" & searchtb.Text & "%' and prod_status='Available'", dtglist4)
            ElseIf searchcb.Text = "Stocks" Then
                reload("select * from product where concat(prod_stock) like '%" & searchtb.Text & "%' and prod_status='Available'", dtglist4)
            ElseIf searchcb.Text = "Date" Then
                reload("select * from product where concat(prod_date) like '%" & searchtb.Text & "%' and prod_status='Available'", dtglist4)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub custommcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles custommcb.SelectionChangeCommitted
        Dim custt As New DataTable()
        gettable("select fname,lname from customer where custom_id='" & custommcb.Text & "'", custt)
        custname.Text = custt.Rows(0)(0).ToString() + " " + custt.Rows(0)(1).ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ans As DialogResult
            ans = MessageBox.Show("Are you sure you want to clear queue?", "Clear Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                idtb.Text = "No product selected"
                nametb.Text = "-"
                pricetb.Text = "-"
                stocktb.Text = "-"
                quantitytb.Text = ""
                statuscb.Text = "-"
                typecb.Text = "-"
                totaltb.Text = ""
                custommcb.Text = ""
                table.Clear()
                Dim custt As New DataTable()
                gettable("select fname,lname from customer where custom_id='" & custommcb.Text & "'", custt)
                custname.Text = custt.Rows(0)(0).ToString() + " " + custt.Rows(0)(1).ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If Not prodq.CurrentRow.IsNewRow Then
                Dim ans As DialogResult
                ans = MessageBox.Show("Do you want to remove this product from queue?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    prodq.Rows.Remove(prodq.CurrentRow)
                End If
            Else
                MessageBox.Show("You cannot delete empty row", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'ingredient sufficiency confirmation'
            Dim insuffi As New DataTable()
            gettable("select prodsettings.iid, prodsettings.iname FROM prodsettings inner join ingredients on ingredients.ing_id = prodsettings.iid where proid = '" & idtb.Text & "' and ingredients.ing_stock<(ingredients.ing_rate*'" & quantitytb.Text & "')", insuffi)
            Dim instock As Double
            Double.TryParse(stocktb.Text, instock)
            Dim quan As Double
            Double.TryParse(quantitytb.Text, quan)
            Dim val As Integer
            Dim counter As Integer
            Dim higher As Integer
            Dim finaq As Integer
            Dim scann As Double
            For i As Integer = 0 To prodq.Rows.Count() - 1
                If idtb.Text = prodq.Rows(i).Cells(0).Value Then
                    Dim currents As Integer
                    currents = prodq.Rows(i).Cells(2).Value()
                    scann = prodq.Rows(i).Cells(2).Value + quan
                    If instock < scann Then
                        higher = higher + 1
                        Exit For
                    Else
                        prodq.Rows.Remove(prodq.Rows(i))
                        finaq = currents + quantitytb.Text
                        counter = counter + 1
                        Exit For
                    End If
                End If
            Next
            'quantity validations'
            If idtb.Text = "No product selected" Or idtb.Text = "" Then
                MessageBox.Show("No product selected!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf quantitytb.Text = "" Or quan < 1 Then
                MessageBox.Show("Please enter a valid quantity!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf instock < quan Then
                MessageBox.Show(nametb.Text + " has insufficient stocks!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf val > 0 Then
                MessageBox.Show(nametb.Text + " already added in queue!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf insuffi.Rows.Count > 0 Then
                MessageBox.Show(nametb.Text + " has " + insuffi.Rows.Count.ToString() + " ingredients With insufficient stocks!", "Check Out Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf higher > 0 Then
                MessageBox.Show(nametb.Text + " has insufficient stocks!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                higher = 0
            ElseIf counter > 0 Then
                table.Rows.Add(idtb.Text, nametb.Text, finaq, totaltb.Text)
                counter = 0
            Else
                table.Rows.Add(idtb.Text, nametb.Text, quantitytb.Text, totaltb.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If prodq.RowCount < 1 Then
                MessageBox.Show("No product added!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to proceed checkout?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    PaymentWindow.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class