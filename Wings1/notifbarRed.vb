Public Class notifbarRed
    Private Sub notifbarRed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 900
        y = Screen.PrimaryScreen.WorkingArea.Height - 480
        Me.Location = New Point(x, y)
        Dim a As Integer
        For a = 10 To 100 Step +1
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next
        lblExp.Visible = True
        If dashboard1.critconfirm > 0 Then
            lblExp.Text = dashboard1.critconfirm.ToString + " items' stocks have reached critical level!"
        Else
            lblExp.Text = dashboard1.exingno2.ToString + " items' stocks have expired."
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class