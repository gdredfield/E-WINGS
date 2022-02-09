Imports MySql.Data.MySqlClient

Public Class Addingredient

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Addingredient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        reload("select * from product", prodcb)
        prodcb.DisplayMember = "prod_name"
        prodcb.ValueMember = "prod_name"
        searchcb.Text = "Name"
        Try
            Dim con As New connection()
            Dim command1 As New MySqlCommand("select * from product where prod_name='" & prodcb.Text & "'", con.getconn())
            Dim adapter1 As New MySqlDataAdapter(command1)
            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            If table1.Rows.Count() > 0 Then
                ' return only 1 row
                idtb.Text = table1.Rows(0)(0).ToString()
                nametb.Text = table1.Rows(0)(1).ToString()
            Else
                MessageBox.Show("Data not found")
            End If
            reload("Select * from ingredients", ingdata)
            reload("select prodsettings.setid, prodsettings.proid, prodsettings.iid, prodsettings.iname, ingredients.ing_stock, ingredients.ing_rate from prodsettings inner join ingredients on ingredients.ing_id = prodsettings.iid where proid = '" & idtb.Text & "'", psettings)
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

    Private Sub prodcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles prodcb.SelectionChangeCommitted
        Try
            reload("select * from ingredients where concat(ing_id, ing_name, ing_stock, ing_price, ing_stock) like '%" & TextBox8.Text & "%'", ingdata)
            Dim con As New connection()
            Dim command1 As New MySqlCommand("select * from product where prod_name='" & prodcb.Text & "'", con.getconn())
            Dim adapter1 As New MySqlDataAdapter(command1)
            Dim table1 As New DataTable()
            adapter1.Fill(table1)
            If table1.Rows.Count() > 0 Then
                idtb.Text = table1.Rows(0)(0).ToString()
                nametb.Text = table1.Rows(0)(1).ToString()
            Else
                MessageBox.Show("Data not found")
            End If
            reload("select prodsettings.setid, prodsettings.proid, prodsettings.iid, prodsettings.iname, ingredients.ing_stock, ingredients.ing_rate from prodsettings inner join ingredients on ingredients.ing_id = prodsettings.iid where proid ='" & idtb.Text & "'", psettings)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ingdata_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ingdata.CellClick
        Dim ans As DialogResult
        Try
            ans = MessageBox.Show("Add " + ingdata.CurrentRow.Cells(1).Value + " to " + nametb.Text + "?", "Set Ingredient", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If ans = DialogResult.Yes Then
                Dim con As New connection()
                Dim command1 As New MySqlCommand("select * from prodsettings where proid='" & idtb.Text & "' and iid='" & ingdata.CurrentRow.Cells(0).Value & "'", con.getconn())
                Dim adapter1 As New MySqlDataAdapter(command1)
                Dim table1 As New DataTable()
                adapter1.Fill(table1)
                'checking if the ingredient is already added in that product'
                If table1.Rows.Count() > 0 Then
                    MessageBox.Show(ingdata.CurrentRow.Cells(1).Value + " is already added!", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    create("insert into prodsettings(proid,iid,iname) values('" & idtb.Text & "','" & ingdata.CurrentRow.Cells(0).Value & "','" & ingdata.CurrentRow.Cells(1).Value & "')")
                    reload("select prodsettings.setid, prodsettings.proid, prodsettings.iid, prodsettings.iname, ingredients.ing_stock, ingredients.ing_rate from prodsettings inner join ingredients on ingredients.ing_id = prodsettings.iid where proid = '" & idtb.Text & "'", psettings)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ans As DialogResult
            ans = MessageBox.Show("Are you sure to remove " + psettings.CurrentRow.Cells(3).Value + " from " + nametb.Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                delete("delete from prodsettings where setid='" & psettings.CurrentRow.Cells(0).Value & "'")
                reload("select prodsettings.setid, prodsettings.proid, prodsettings.iid, prodsettings.iname, ingredients.ing_stock, ingredients.ing_rate from prodsettings inner join ingredients on ingredients.ing_id = prodsettings.iid where proid = '" & idtb.Text & "'", psettings)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Try
            If searchcb.Text = "Name" Then
                reload("select * from ingredients where concat(ing_name) like '%" & TextBox8.Text & "%'", ingdata)
            ElseIf searchcb.Text = "ID" Then
                reload("select * from ingredients where concat(ing_id) like '%" & TextBox8.Text & "%'", ingdata)
            ElseIf searchcb.Text = "Unit" Then
                reload("select * from ingredients where concat(ing_unit) like '%" & TextBox8.Text & "%'", ingdata)
            ElseIf searchcb.Text = "Price" Then
                reload("select * from ingredients where concat(ing_price) like '%" & TextBox8.Text & "%'", ingdata)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class