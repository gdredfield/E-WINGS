Imports MySql.Data.MySqlClient

Public Class RegistrationForm
    'username validation function'
    Public Function userexist(ByVal username As String) As Boolean
        Dim con As New connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("select * from users where user=@usr", con.getconn())
        command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = usernametb.Text

        adapter.SelectCommand = command
        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function

    Dim Pos As Point
    Private Sub BunifuCards1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub cb1_OnChange(sender As Object, e As EventArgs) Handles cb1.OnChange
        'terms and agreement checkbox'
        If cb1.Checked = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname As String = fnametb.Text
        Dim lname As String = lnametb.Text
        Dim user As String = usernametb.Text
        Dim email As String = emailTb.Text
        Dim pass As String = passtb.Text
        Dim cpass As String = cpasstb.Text
        Dim email1 As Boolean = IsValidEmailFormat(emailTb.Text)

        'textbox fields validation'
        If fnametb.Text = "" Then
            MessageBox.Show("First name field is empty!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf lnametb.Text = "" Then
            MessageBox.Show("Last name field is empty!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usernametb.Text = "" Then
            MessageBox.Show("Username field is empty", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf emailTb.Text = "" Then
            MessageBox.Show("Email field is empty", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf passtb.Text = "" Then
            MessageBox.Show("Password field is empty", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf email1 = False Then
            MessageBox.Show("Please enter a valid email!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usernametb.Text.Length > 12 Then
            MessageBox.Show("Username must be under 13 characters", "Username length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf usernametb.Text.Length < 3 Then
            MessageBox.Show("Username must be atleast 3 characters", "Username length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf passtb.text.length < 8 Then
            MessageBox.Show("Password must be atleast 8 characters", "Password length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cpasstb.Text = "" Then
            MessageBox.Show("Confirm Password field is empty", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'confirm password & password validation'
        ElseIf Not String.Equals(pass, cpass) Then
            MessageBox.Show("Passwords do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'existing username validation'
        ElseIf userexist(user) Then
            MessageBox.Show("Username is already taken", "Existing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim con As New connection()
            Dim command As New MySqlCommand("insert into users(user,pass,fname,lname,email) values (@usr,@pass,@fn,@ln,@email)", con.getconn())
            command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = user
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email
            con.openconn()
            'success confirmation'
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Account Successfully Created!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.closeconn()
                Me.Close()
                LoginForm.Show()
            Else
                MsgBox("Task Unsuccessful!")
                con.closeconn()
            End If
        End If
    End Sub

    Private Sub Button1_EnabledChanged(sender As Object, e As EventArgs) Handles Button1.EnabledChanged
        If Button1.Enabled = False Then
            Button1.BackColor = Color.MediumSeaGreen
        Else
            Button1.BackColor = Color.SeaGreen
        End If
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub BtnQuit2_Click(sender As Object, e As EventArgs) Handles BtnQuit2.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub fnametb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lnametb.KeyPress, fnametb.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cpasstb_Enter(sender As Object, e As EventArgs) Handles passtb.Enter, cpasstb.Enter
        passtb.isPassword = True
        cpasstb.isPassword = True
    End Sub
End Class