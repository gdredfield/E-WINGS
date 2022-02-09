Public Class Lowstock

    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Lowstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            reload("select * from product", sortcb)
            sortcb.DisplayMember = "prod_name"
            sortcb.ValueMember = "prod_id"
            reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients ORDER BY ing_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients where ing_stock<=10 ORDER BY ing_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients ORDER BY ing_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients where concat(ing_name,ing_id) like '%" & searchbox.Text & "%' ORDER BY ing_stock ASC", lowdt)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        addistock.Show()
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        Try
            reload("select ingredients.ing_id, ingredients.ing_name, ingredients.ing_rate, ingredients.ing_stock from ingredients inner join prodsettings on prodsettings.iid=ingredients.ing_id where prodsettings.proid='" & sortcb.SelectedValue.ToString & "'", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class