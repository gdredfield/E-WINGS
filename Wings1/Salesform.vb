Public Class Salesform

    Dim defquery As String = "select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.dcperc, sales.dcamo, concat(customer.fname,' ', customer.lname) as name, product.prod_price from sales INNER JOIN product on product.prod_id=sales.prodid INNER JOIN customer on sales.customer_id = customer.custom_id"
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        dt1.Format = DateTimePickerFormat.Custom
        dt1.CustomFormat = "yyyy/MM/dd"
        dt2.Format = DateTimePickerFormat.Custom
        dt2.CustomFormat = "yyyy/MM/dd"
        Timer1.Enabled = True
        searchcb.Text = "Product"
        Try
            reload(defquery + " where year(sales.sale_date)='" & Date.Now.Year & "' and month(sales.sale_date)='" & Date.Now.Month & "' ORDER BY sale_date DESC", dtglist3)
            gett("select count(*) from sales where year(sales.sale_date)='" & Date.Now.Year & "' and month(sales.sale_date)='" & Date.Now.Month & "' ORDER BY sale_date DESC", Label9)
            gett("select sum(stotal) from sales where year(sales.sale_date)='" & Date.Now.Year & "' and month(sales.sale_date)='" & Date.Now.Month & "' ORDER BY sale_date DESC", Label11)
            Label11.Text = Format(Val(Label11.Text), "0.00")
            Label11.Text = "PHP " + Label11.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
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
            reload(defquery + " ORDER BY sale_date DESC", dtglist3)
            gett("select count(*) from sales ORDER BY sale_date DESC", Label9)
            gett("select sum(stotal) from sales ORDER BY sale_date DESC", Label11)
            Label11.Text = Format(Val(Label11.Text), "0.00")
            Label11.Text = Label11.Text + " PHP"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub sbox_TextChanged(sender As Object, e As EventArgs) Handles sbox.TextChanged
        Try
            If searchcb.Text = "Product" Then
                reload(defquery + " where concat(proname) like '%" & sbox.Text & "%'", dtglist3)
            ElseIf searchcb.Text = "Price" Then
                reload(defquery + " where concat(product.prod_price) like '%" & sbox.Text & "%'", dtglist3)
            ElseIf searchcb.Text = "Date" Then
                reload(defquery + " where concat(sale_date) like '%" & sbox.Text & "%'", dtglist3)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dtglist3.SelectedCells.Count() = 0 Or dtglist3.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            editsale.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'delete'
        If dtglist3.SelectedCells.Count() = 0 Or dtglist3.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete sale record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from sales where sale_code='" & dtglist3.CurrentRow.Cells(0).Value & "'")
                    reload(defquery + " ORDER BY sale_date DESC", dtglist3)
                    gett("select count(*) from sales ORDER BY sale_date DESC", Label9)
                    gett("select sum(stotal) from sales ORDER BY sale_date DESC", Label11)
                    Label11.Text = Format(Val(Label11.Text), "0.00")
                    Label11.Text = Label11.Text + " PHP"
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            reload(defquery + " where (sales.sale_date BETWEEN '" & dt1.Value.ToString("yyyy/MM/dd") & "' and '" & dt2.Value.ToString("yyyy/MM/dd") & "') ORDER BY sale_date DESC", dtglist3)
            gett("select count(*) from sales where (sale_date BETWEEN '" & dt1.Value.ToString("yyyy/MM/dd") & "' and '" & dt2.Value.ToString("yyyy/MM/dd") & "') ORDER BY sale_date DESC", Label9)
            gett("select sum(stotal) from sales where (sale_date BETWEEN '" & dt1.Value.ToString("yyyy/MM/dd") & "' and '" & dt2.Value.ToString("yyyy/MM/dd") & "') ORDER BY sale_date DESC", Label11)
            Label11.Text = Format(Val(Label11.Text), "0.00")
            Label11.Text = Label11.Text + "PHP"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class