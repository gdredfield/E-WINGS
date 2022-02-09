Public Class adminconfpass
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim adminacc As New DataTable
        If apasstb.Text = "" Then
            MessageBox.Show("Please enter admin password!", "Blank Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            gettable("select user,pass from users where user='admin' and pass='" & apasstb.Text & "'", adminacc)
            If adminacc.Rows.Count > 0 Then
                Me.Close()
                edituser.Show()
            Else
                MessageBox.Show("Incorrect password entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                apasstb.Text = ""
            End If
        End If
    End Sub

    Private Sub adminconfpass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class