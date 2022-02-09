Public Class manageuser

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub manageuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        searchcb.Text = "Username"
        reload("select * from users", dtguser)
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        If searchcb.Text = "ID" Then
            reload("select * from users where concat(ID) like '%" & searchbox.Text & "%'", dtguser)
        ElseIf searchcb.Text = "Name" Then
            reload("select * from users where concat(fname,lname) like '%" & searchbox.Text & "%'", dtguser)
        ElseIf searchcb.Text = "Username" Then
            reload("select * from users where concat(user) like '%" & searchbox.Text & "%'", dtguser)
        ElseIf searchcb.Text = "Email" Then
            reload("select * from users where concat(email) like '%" & searchbox.Text & "%'", dtguser)
        End If
    End Sub

    Private Sub confirmbut_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If dtguser.CurrentRow.Cells(1).Value.ToString = "admin" Then
                MessageBox.Show("Default admin account cannot be deleted!", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from users where ID='" & dtguser.CurrentRow.Cells(0).Value & "'")
                    reload("select * from users", dtguser)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If dtguser.SelectedCells.Count = 0 Or dtguser.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf dtguser.CurrentRow.Cells(1).Value.ToString = "admin" Then
            MessageBox.Show("Cannot change account settings for default admin account!", "Task Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            adminconfpass.Show()
        End If
    End Sub

End Class