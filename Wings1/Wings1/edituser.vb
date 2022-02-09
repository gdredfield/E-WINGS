Imports MySql.Data.MySqlClient

Public Class edituser

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Public Function userexist(ByVal username As String) As Boolean
        Dim con As New connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("select * from users where user=@usr and user<>'" & manageuser.dtguser.CurrentRow.Cells(1).Value.ToString & "'", con.getconn())
        command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = usertb.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub edituser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try

            Label1.Text = manageuser.dtguser.CurrentRow.Cells(0).Value.ToString
            usertb.Text = manageuser.dtguser.CurrentRow.Cells(1).Value
            passtb.Text = manageuser.dtguser.CurrentRow.Cells(2).Value
            fnametb.Text = manageuser.dtguser.CurrentRow.Cells(3).Value
            lnametb.Text = manageuser.dtguser.CurrentRow.Cells(4).Value
            emailtb.Text = manageuser.dtguser.CurrentRow.Cells(5).Value

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        manageuser.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            If usertb.Text = "" Then
                MessageBox.Show("Please enter username!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf fnametb.Text = "" Then
                MessageBox.Show("Please enter first name!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lnametb.Text = "" Then
                MessageBox.Show("Please enter last name!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf emailtb.Text = "" Then
                MessageBox.Show("Please enter email!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf passtb.Text.Length < 8 Then
                MessageBox.Show("New password must be atleast 8 characters", "Password length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf usertb.Text = "admin" Then
                MessageBox.Show("Username already exists!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf userexist(usertb.Text) Then
                MessageBox.Show("Username is already taken!", "Existing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                updated("update users set user='" & usertb.Text & "', pass='" & passtb.Text & "', fname='" & fnametb.Text & "', lname='" & lnametb.Text & "', email='" & emailtb.Text & "' where ID='" & manageuser.dtguser.CurrentRow.Cells(0).Value.ToString & "' ")
                reload("select * from users", manageuser.dtguser)
                Me.Close()
                manageuser.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class