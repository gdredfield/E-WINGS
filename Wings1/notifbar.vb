Public Class notifbar
    Private Sub notifbar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 900
        y = Screen.PrimaryScreen.WorkingArea.Height - 560
        Me.Location = New Point(x, y)
        Dim a As Integer
        For a = 10 To 100 Step +1
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next
        lblFormTitle.Visible = True
        lblFormTitle.Text = dashboard1.rest2.ToString + " items are running low on stocks."
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class