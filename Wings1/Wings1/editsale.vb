Imports MySql.Data.MySqlClient

Public Class editsale

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            If customcb.Text = 1 And customname.Text = "" Then
                updated("update sales set prodid='" & prod_id.Text & "',proname='" & proname.Text & "', squantity='" & squantity.Text & "', stotal='" & totaltb.Text & "', sale_date='" & datetb.Value.ToString("yyyy/MM/dd") & "', schange='" & changetb.Text & "' where sale_code='" & sale_id.Text & "'")
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid ORDER BY sale_date DESC", Salesform.dtglist3)
            Else
                updated("update sales set prodid='" & prod_id.Text & "',proname='" & proname.Text & "', squantity='" & squantity.Text & "', stotal='" & totaltb.Text & "', sale_date='" & datetb.Value.ToString("yyyy/MM/dd") & "', schange='" & changetb.Text & "', customer_id='" & customcb.Text & "' where sale_code='" & sale_id.Text & "'")
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid ORDER BY sale_date DESC", Salesform.dtglist3)
            End If
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub editsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        datetb.Format = DateTimePickerFormat.Custom
        datetb.CustomFormat = "dd/MM/yyyy"
        Try
            sale_id.Text = Salesform.dtglist3.CurrentRow.Cells(0).Value
            prod_id.Text = Salesform.dtglist3.CurrentRow.Cells(1).Value
            squantity.Text = Salesform.dtglist3.CurrentRow.Cells(3).Value
            totaltb.Text = Salesform.dtglist3.CurrentRow.Cells(4).Value
            changetb.Text = Salesform.dtglist3.CurrentRow.Cells(6).Value
            datetb.Value = Salesform.dtglist3.CurrentRow.Cells(5).Value
            Dim check As New DataTable
            'check if the row has a null customer value for the customer drop down list and name load values'
            gettable("select * from sales where sale_code='" & sale_id.Text & "' and customer_id is NULL", check)
            If check.Rows.Count() > 0 Then
                reload("Select * from customer", customcb)
                customcb.DisplayMember = "custom_id"
                customcb.ValueMember = "custom_id"
            Else
                reload("Select * from customer", customcb)
                customcb.DisplayMember = "custom_id"
                customcb.ValueMember = "custom_id"
                Dim customer As New DataTable()
                customcb.Text = Salesform.dtglist3.CurrentRow.Cells(7).Value
                gettable("select fname,lname from customer where custom_id='" & customcb.Text & "'", customer)
                customname.Text = customer.Rows(0)(0).ToString() + " " + customer.Rows(0)(1).ToString()
            End If
            'load product cb'
            Dim table As New DataTable()
            gettable("select * from product where prod_id='" & prod_id.Text & "'", table)
            If table.Rows.Count() > 0 Then
                ' return only 1 row '
                proname.Text = table.Rows(0)(1).ToString()
                proprice.Text = table.Rows(0)(3).ToString()
                prod_stock.Text = table.Rows(0)(5).ToString()
            Else
                MessageBox.Show("Data not found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'search button'
        Try
            Dim con As New connection()
            Dim command As New MySqlCommand("select * from product where prod_id='" & prod_id.Text & "'", con.getconn())
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                ' return only 1 row
                proname.Text = table.Rows(0)(1).ToString()
                proprice.Text = table.Rows(0)(3).ToString()
                prod_stock.Text = table.Rows(0)(5).ToString()
            Else
                MessageBox.Show("Data not found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub prod_id_TextChanged(sender As Object, e As EventArgs) Handles prod_id.TextChanged
        'search textbox'
        Dim con As New connection()
        Dim command As New MySqlCommand("select * from product where prod_id='" & prod_id.Text & "'", con.getconn())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            ' textbox automatic changes according to product id searched'
            proname.Text = table.Rows(0)(1).ToString()
            proprice.Text = table.Rows(0)(3).ToString()
            prod_stock.Text = table.Rows(0)(5).ToString()
            Dim price, quantity As Double
            Double.TryParse(proprice.Text, price)
            Double.TryParse(squantity.Text, quantity)
            totaltb.Text = price * quantity
        End If
    End Sub

    Private Sub squantity_TextChanged(sender As Object, e As EventArgs) Handles squantity.TextChanged
        'automatic calculation of total amount based on quantity textbox'
        Try
            Dim price, quantity As Double
            Double.TryParse(proprice.Text, price)
            Double.TryParse(squantity.Text, quantity)
            totaltb.Text = price * quantity
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub customcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles customcb.SelectionChangeCommitted
        'customer name textbox change according to customer id combobox'
        Try
            Dim customer As New DataTable()
            gettable("select fname,lname from customer where custom_id='" & customcb.Text & "'", customer)
            Try
                customname.Text = customer.Rows(0)(0).ToString() + " " + customer.Rows(0)(1).ToString()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Newcustomer.Show()
    End Sub

End Class