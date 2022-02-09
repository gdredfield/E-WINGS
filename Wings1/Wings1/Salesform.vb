Public Class Salesform

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        dt1.Format = DateTimePickerFormat.Custom
        dt1.CustomFormat = "dd/MM/yyyy"
        dt2.Format = DateTimePickerFormat.Custom
        dt2.CustomFormat = "dd/MM/yyyy"
        Timer1.Enabled = True
        searchcb.Text = "Product"
        Try
            reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid ORDER BY sale_date DESC", dtglist3)
            gett("select count(*) from sales ORDER BY sale_date DESC", Label9)
            gett("select sum(stotal) from sales ORDER BY sale_date DESC", Label11)
            Label11.Text = Format(Val(Label11.Text), "0.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        If LoginForm.UserTb.Text = "admin" Then
            Inventoryform2.Show()
        Else
            Inventoryform.Show()
        End If
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub BunifuThinButton21_Click_1(sender As Object, e As EventArgs)
        Me.Hide()
        AddSale.Show()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'refresh'
        Try
            reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid ORDER BY sale_date DESC", dtglist3)
            gett("select count(*) from sales ORDER BY sale_date DESC", Label9)
            gett("select sum(stotal) from sales ORDER BY sale_date DESC", Label11)
            Label11.Text = Format(Val(Label11.Text), "0.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub sbox_TextChanged(sender As Object, e As EventArgs) Handles sbox.TextChanged
        Try
            If searchcb.Text = "Product" Then
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid where concat(proname) like '%" & sbox.Text & "%'", dtglist3)
            ElseIf searchcb.Text = "Price" Then
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid where concat(product.prod_price) like '%" & sbox.Text & "%'", dtglist3)
            ElseIf searchcb.Text = "Date" Then
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid where concat(sale_date) like '%" & sbox.Text & "%'", dtglist3)
            ElseIf searchcb.Text = "Stock" Then
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid where concat(product.prod_stock) like '%" & sbox.Text & "%'", dtglist3)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        editsale.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'delete'
        Try
            Dim ans As DialogResult
            ans = MessageBox.Show("Are you sure to delete sale record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                delete("delete from sales where sale_code='" & dtglist3.CurrentRow.Cells(0).Value & "'")
                reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid ORDER BY sale_date DESC", dtglist3)
                gett("select count(*) from sales ORDER BY sale_date DESC", Label9)
                gett("select sum(stotal) from sales ORDER BY sale_date DESC", Label11)
                Label11.Text = Format(Val(Label11.Text), "0.00")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid where (sales.sale_date BETWEEN '" & dt1.Value.ToString("yyyy/MM/dd") & "' and '" & dt2.Value.ToString("yyyy/MM/dd") & "') ORDER BY sale_date DESC", dtglist3)
            gett("select count(*) from sales where (sale_date BETWEEN '" & dt1.Value.ToString("yyyy/MM/dd") & "' and '" & dt2.Value.ToString("yyyy/MM/dd") & "') ORDER BY sale_date DESC", Label9)
            gett("select sum(stotal) from sales where (sale_date BETWEEN '" & dt1.Value.ToString("yyyy/MM/dd") & "' and '" & dt2.Value.ToString("yyyy/MM/dd") & "') ORDER BY sale_date DESC", Label11)
            Label11.Text = Format(Val(Label11.Text), "0.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class