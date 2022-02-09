Imports MySql.Data.MySqlClient

Public Class editaccount

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
        Dim command As New MySqlCommand("select * from users where user=@usr and user<>'" & LoginForm.UserTb.Text & "'", con.getconn())
        command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = usertb.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub editaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            Dim userdata As New DataTable()
            gettable("select * from users where user='" & LoginForm.UserTb.Text & "'", userdata)
            If userdata.Rows.Count() > 0 Then
                label1.Text = userdata.Rows(0)(0).ToString
                usertb.Text = userdata.Rows(0)(1).ToString
                fnametb.Text = userdata.Rows(0)(3).ToString
                lnametb.Text = userdata.Rows(0)(4).ToString
                emailtb.Text = userdata.Rows(0)(5).ToString
            Else
                MessageBox.Show("User not found!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Inventoryform.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        changepassword.Show()
    End Sub

    Private Sub confirmbut_Click(sender As Object, e As EventArgs)
        Try
            If usertb.Text = "" Then
                MessageBox.Show("Please enter username!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf fnametb.Text = "" Then
                MessageBox.Show("Please enter first name!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lnametb.Text = "" Then
                MessageBox.Show("Please enter last name!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf emailtb.Text = "" Then
                MessageBox.Show("Please enter email!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf userexist(usertb.Text) Then
                MessageBox.Show("Username is already taken", "Existing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                updated("update users set user='" & usertb.Text & "',fname='" & fnametb.Text & "',lname='" & lnametb.Text & "',email='" & emailtb.Text & "' where user='" & LoginForm.UserTb.Text & "'")
                Me.Close()
                Inventoryform.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            ElseIf userexist(usertb.Text) Then
                MessageBox.Show("Username is already taken", "Existing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                updated("update users set user='" & usertb.Text & "',fname='" & fnametb.Text & "',lname='" & lnametb.Text & "',email='" & emailtb.Text & "' where user='" & LoginForm.UserTb.Text & "'")
                Me.Close()
                Inventoryform.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class