Imports MySql.Data.MySqlClient

Public Class editsale

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim checkq As Double
        If squantity.Text = "" Then
            MessageBox.Show("Please enter a quantity value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Double.TryParse(squantity.Text, checkq) Then
            MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf squantity.Text < 1 Then
            MessageBox.Show("Please enter a valid quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                updated("update sales set prodid='" & productcb.SelectedValue.ToString & "',proname='" & productcb.Text & "', squantity='" & squantity.Text & "', stotal='" & totaltb.Text & "', sale_date='" & datetb.Value.ToString("yyyy/MM/dd") & "', schange='" & changetb.Text & "', customer_id='" & customcb.SelectedValue.ToString & "' where sale_code='" & sale_id.Text & "'")
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid ORDER BY sale_date DESC", Salesform.dtglist3)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles squantity.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub editsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        datetb.Format = DateTimePickerFormat.Custom
        datetb.CustomFormat = "dd/MM/yyyy"
        reload("select prod_id, prod_name from product", productcb)
        productcb.DisplayMember = "prod_name"
        productcb.ValueMember = "prod_id"
        Try
            productcb.Text = Salesform.dtglist3.CurrentRow.Cells(2).Value
            sale_id.Text = Salesform.dtglist3.CurrentRow.Cells(0).Value
            squantity.Text = Salesform.dtglist3.CurrentRow.Cells(3).Value
            totaltb.Text = Salesform.dtglist3.CurrentRow.Cells(4).Value
            changetb.Text = Salesform.dtglist3.CurrentRow.Cells(6).Value
            datetb.Value = Salesform.dtglist3.CurrentRow.Cells(5).Value
            Dim check As New DataTable
            'customer
            reload("select custom_id, concat(fname,' ',lname) as name from customer", customcb)
            customcb.DisplayMember = "name"
            customcb.ValueMember = "custom_id"
            customcb.Text = Salesform.dtglist3.CurrentRow.Cells(7).Value
            'load product cb'
            Dim table As New DataTable()
            gettable("select * from product where prod_id='" & productcb.SelectedValue.ToString & "'", table)
            If table.Rows.Count() > 0 Then
                ' return only 1 row '
                proprice.Text = table.Rows(0)(3).ToString()
                prod_stock.Text = table.Rows(0)(5).ToString()
            Else
                MessageBox.Show("Data not found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub prod_id_TextChanged(sender As Object, e As EventArgs)
        'search textbox'
        Dim con As New connection()
        Dim command As New MySqlCommand("select * from product where prod_id='" & productcb.SelectedValue.ToString & "'", con.getconn())
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() > 0 Then
            ' textbox automatic changes according to product id searched'
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNewCust.Click
        Newcustomer.Show()
    End Sub

    Private Sub productcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles productcb.SelectionChangeCommitted
        Try
            Dim con As New connection()
            Dim command As New MySqlCommand("select * from product where prod_id='" & productcb.SelectedValue.ToString & "'", con.getconn())
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() > 0 Then
                ' return only 1 row
                proprice.Text = table.Rows(0)(3).ToString()
                prod_stock.Text = table.Rows(0)(5).ToString()
                Dim price, quantity As Double
                Double.TryParse(proprice.Text, price)
                Double.TryParse(squantity.Text, quantity)
                totaltb.Text = price * quantity
            Else
                MessageBox.Show("Data not found")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class