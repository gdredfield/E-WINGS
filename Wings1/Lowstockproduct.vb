Public Class Lowstockproduct

    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


    Private Sub Lowstockproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            reload("select prod_id,prod_name,prod_stock from product ORDER BY prod_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            reload("select prod_id,prod_name,prod_stock from product where prod_stock<=10 ORDER BY prod_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            reload("select prod_id,prod_name,prod_stock from product ORDER BY prod_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        reload("select prod_id,prod_name,prod_stock from product where concat(prod_name,prod_id) like '%" & searchbox.Text & "%' ORDER BY prod_stock ASC", lowdt)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        addpstock.Show()
    End Sub
End Class