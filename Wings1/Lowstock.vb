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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim lblrestock As New DataTable
        'running low
        gettable("select count(*) from ingredients where ing_stock<=20", lblrestock)
        If lblrestock.Rows(0)(0) > 0 Then
            dashboard1.Label9.Text = "Restock"
            dashboard1.lblRunningLow.Text = lblrestock.Rows(0)(0)
        Else
            dashboard1.Label9.Text = "All good"
            dashboard1.lblRunningLow.Text = 0
        End If
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLow.Click, btnShowAll.Click
        Try
            reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients where ing_stock<=20 ORDER BY ing_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Try
            reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients ORDER BY ing_stock ASC", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients where concat(ing_name,ing_id) like '%" & searchbox.Text & "%' ORDER BY ing_stock ASC", lowdt)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lowdt.SelectedCells.Count = 0 Or lowdt.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            addistock.Show()
        End If
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        Try
            reload("select ingredients.ing_id, ingredients.ing_name, ingredients.ing_rate, ingredients.ing_stock from ingredients inner join prodsettings on prodsettings.iid=ingredients.ing_id where prodsettings.proid='" & sortcb.SelectedValue.ToString & "'", lowdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class