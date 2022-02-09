Imports MySql.Data.MySqlClient

Public Class editaccount

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function

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
        '' Fade in when started
        Me.Opacity = 0
        Dim tmr As New Timer
        tmr.Interval = 2
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity += 0.1
                                 If Me.Opacity = 1 Then tmr.Stop()
                             End Sub
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Me.Hide()
        changepassword.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim email As Boolean = IsValidEmailFormat(emailtb.Text)
        Try
            If usertb.Text = "" Then
                MessageBox.Show("Please enter username!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf fnametb.Text = "" Then
                MessageBox.Show("Please enter first name!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf lnametb.Text = "" Then
                MessageBox.Show("Please enter last name!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf emailtb.Text = "" Then
                MessageBox.Show("Please enter email!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf email = False Then
                MessageBox.Show("Please enter a valid email!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf userexist(usertb.Text) Then
                MessageBox.Show("Username is already taken", "Existing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                updated("update users set user='" & usertb.Text & "',fname='" & fnametb.Text & "',lname='" & lnametb.Text & "',email='" & emailtb.Text & "' where user='" & LoginForm.UserTb.Text & "'")
                Dim userinfo As New DataTable()
                gettable("select user, concat(fname,' ',lname) as name from users where user='" & LoginForm.UserTb.Text.ToString & "' ", userinfo)
                dashboard1.btnEditUser.Text = userinfo.Rows(0)(1).ToString
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class