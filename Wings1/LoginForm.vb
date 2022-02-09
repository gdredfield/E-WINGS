Imports MySql.Data.MySqlClient

Public Class LoginForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        RegistrationForm.Show()

    End Sub

    Private Sub Loginb_Click(sender As Object, e As EventArgs) Handles Loginb.Click
        Dim con As New connection()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT user,pass FROM users where user=@usn and pass=@pass", con.getconn())

        Try
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = UserTb.Text
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordTb.Text
            'validation for empty fiels'
            If UserTb.Text.Trim() = "" Or UserTb.Text.Trim().ToLower = "username" Then
                MessageBox.Show("Enter your username", "Blank Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf PasswordTb.Text.Trim() = "" Or PasswordTb.Text.Trim().ToLower = "password" Then
                MessageBox.Show("Enter your password", "Blank Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'user account user and password confirmation'
                adapter.SelectCommand = command
                adapter.Fill(table)

                If table.Rows.Count > 0 Then
                    If UserTb.Text = "admin" Then
                        Me.Hide()
                        dashboard1.Show()
                    Else
                        Me.Hide()
                        dashboard1.Show()
                    End If
                Else
                    MessageBox.Show("Incorrect username or password entered", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove, Panel4.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'show password'
        If PasswordTb.Text.Trim().ToLower = "password" Or PasswordTb.Text.Trim() = "" Then

        Else
            If CheckBox1.Checked = True Then
                PasswordTb.isPassword = False
            Else
                PasswordTb.isPassword = True
            End If
        End If
    End Sub
    'placeholders'
    Private Sub UserTb_Enter(sender As Object, e As EventArgs) Handles UserTb.Enter
        Dim username As String = UserTb.Text
        If username.Trim().ToLower = "username" Or username.Trim() = "" Then
            UserTb.Text = ""
            UserTb.ForeColor = Color.FromArgb(255, 255, 192)
        End If
    End Sub

    Private Sub UserTb_Leave(sender As Object, e As EventArgs) Handles UserTb.Leave
        Dim username As String = UserTb.Text
        If username.Trim().ToLower = "username" Or username.Trim() = "" Then
            UserTb.Text = "Username"
            UserTb.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub PasswordTb_Enter(sender As Object, e As EventArgs) Handles PasswordTb.Enter
        Dim password As String = PasswordTb.Text
        If password.Trim().ToLower = "password" Or password.Trim() = "" Then
            PasswordTb.Text = ""
            PasswordTb.ForeColor = Color.FromArgb(255, 255, 192)
            PasswordTb.isPassword = True

        End If
    End Sub

    Private Sub PasswordTb_Leave(sender As Object, e As EventArgs) Handles PasswordTb.Leave
        Dim password As String = PasswordTb.Text
        If password.Trim().ToLower = "password" Or password.Trim() = "" Then
            PasswordTb.Text = "Password"
            PasswordTb.ForeColor = Color.DimGray
            PasswordTb.isPassword = False

        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub


End Class
