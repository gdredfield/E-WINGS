Public Class Addproductype
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Addproductype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        reload("Select * from category", dtgg)
    End Sub


    Private Sub dtgg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgg.CellContentClick
        cattb.Text = dtgg.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            create("INSERT into category(prod_type) values ('" & cattb.Text & "')")
            reload("Select * from category", dtgg)
            reload("Select * from category", Productform.typecb)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            delete("delete from category where prod_type = ('" & cattb.Text & "')")
            reload("Select * from category", dtgg)
            reload("Select * from category", Productform.typecb)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class