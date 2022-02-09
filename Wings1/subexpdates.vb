Imports System.ComponentModel
Public Class subexpdates

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub subexpdates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        reload("select in_id,in_name,in_stock,in_rec,in_ex from subitem where in_id='" & Productform.dtglist2.CurrentRow.Cells(0).Value.ToString & "'", dtgexp)
    End Sub

    Private Sub closer(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '' Fade out when closed
        e.Cancel = True
        Me.Opacity = 1
        Dim tmr As New Timer
        tmr.Interval = 1
        tmr.Start()
        AddHandler tmr.Tick, Sub()
                                 Me.Opacity -= 0.1
                                 If Me.Opacity = 0 Then
                                     e.Cancel = False
                                     tmr.Stop()
                                     Me.Dispose()
                                 End If
                             End Sub
    End Sub
End Class