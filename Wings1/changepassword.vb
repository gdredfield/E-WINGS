Public Class changepassword

    Private Sub changepassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.Opacity = 0
        Dim tmr As New Timer
        tmr.Interval = 2
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity += 0.1
                                 If Me.Opacity = 1 Then tmr.Stop()
                             End Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim user As New DataTable()
            gettable("select pass from users where user='" & editaccount.usertb.Text & "' and pass='" & cpass.Text & "'", user)

            If cpass.Text = "" Then
                MessageBox.Show("Please enter current password!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf npass.Text = "" Then
                MessageBox.Show("Please enter new password!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf cnpass.Text = "" Then
                MessageBox.Show("Please enter confirm password!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf npass.Text.Length < 8 Then
                MessageBox.Show("New password must be atleast 8 characters", "Password length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Not String.Equals(npass.Text, cnpass.Text) Then
                MessageBox.Show("Passwords do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If user.Rows.Count > 0 Then
                    updated("update users set pass='" & npass.Text & "' where user='" & editaccount.usertb.Text & "'")
                    Me.Close()
                    editaccount.Show()
                Else
                    MessageBox.Show("Wrong Current Password", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        editaccount.Show()
    End Sub

End Class