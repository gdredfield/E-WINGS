Imports MySql.Data.MySqlClient

Public Class addproduct
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
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
        ElseIf Not Integer.TryParse(pricetb.Text, pricet) Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf pricetb.Text < 1 Then
            MessageBox.Show("Please enter valid product price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text = "" Then
            MessageBox.Show("Please enter stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(stocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text < 1 Then
            MessageBox.Show("Please enter valid stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate product names'
        ElseIf namet.Rows.Count() > 0 Then
            MessageBox.Show(nametb.Text + " already exists." & vbCrLf & "Please enter different product name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                Dim pstock As Integer
                Integer.TryParse(stocktb.Text, pstock)
                'checking if stock is less than 1 to switch status to unavailable'
                If pstock < 1 Then
                    create("INSERT INTO `product`(`prod_id`,`prod_name`, `prodesc`, `prod_price`, `prod_type`, `prod_stock`, `prod_status`,`prod_date`) VALUES('" & idtb.Text & "','" & nametb.Text & "','" & desctb.Text & "','" & pricetb.Text & "','" & typecb.Text & "','" & stocktb.Text & "','Unavailable','" & Date.Now.ToString("yyyy/MM/dd") & "')")
                Else
                    create("INSERT INTO `product`(`prod_id`,`prod_name`, `prodesc`, `prod_price`, `prod_type`, `prod_stock`, `prod_status`,`prod_date`) VALUES('" & idtb.Text & "','" & nametb.Text & "','" & desctb.Text & "','" & pricetb.Text & "','" & typecb.Text & "','" & stocktb.Text & "','Available','" & Date.Now.ToString("yyyy/MM/dd") & "')")
                End If
                idtb.Text = ""
                nametb.Text = ""
                desctb.Text = ""
                pricetb.Text = ""
                stocktb.Text = ""
                typecb.Text = "Available"
                reload("Select * from product", Productform.dtglist)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub addproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            statuscb.Text = "Available"
            reload("select * from category", typecb)
            typecb.DisplayMember = "prod_type"
            typecb.ValueMember = "prod_type"
            Dim oldid As String
            Dim newid As String
            Dim year As String = Date.Today.Year
            gett("select * from product ORDER BY prod_id DESC LIMIT 1", idtb)
            oldid = idtb.Text.Remove(0, 8)
            newid = oldid + 1
            idtb.Text = "PROD" + year + newid
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
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