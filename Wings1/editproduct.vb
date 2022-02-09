Imports MySql.Data.MySqlClient

Public Class editproduct
    Private Sub editproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        reload("select * from category", typecb)
        typecb.DisplayMember = "prod_type"
        typecb.ValueMember = "prod_type"
        Try
            idtb.Text = Productform.dtglist.CurrentRow.Cells(0).Value
            nametb.Text = Productform.dtglist.CurrentRow.Cells(1).Value
            desctb.Text = Productform.dtglist.CurrentRow.Cells(2).Value
            pricetb.Text = Productform.dtglist.CurrentRow.Cells(3).Value
            typecb.Text = Productform.dtglist.CurrentRow.Cells(4).Value
            stocktb.Text = Productform.dtglist.CurrentRow.Cells(5).Value
            statuscb.Text = Productform.dtglist.CurrentRow.Cells(7).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
                updated("UPDATE product set prod_name='" & nametb.Text & "', prodesc='" & desctb.Text & "', prod_price='" & pricetb.Text & "', prod_type='" & typecb.Text & "', prod_stock='" & stocktb.Text & "',prod_status='" & statuscb.Text & "' where prod_id='" & idtb.Text & "'")
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
                reload("Select * from product", Productform.dtglist)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Addproductype.Show()
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pricetb.KeyPress, stocktb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class