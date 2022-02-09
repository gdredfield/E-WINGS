Public Class Productreport

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Productreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Try
        monthpb.SelectedIndex = DateTime.Now.ToString("MM") - 1
            'product chart
            getchart("select proname, sum(squantity), sum(stotal) from sales where month(sale_date)='" & monthpb.SelectedIndex + 1 & "' GROUP by proname ORDER by sum(squantity) desc limit 5", "month", 0, 1, pchart)
            'monthly chart
            For i As Integer = 1 To 12
                If i = 1 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "January", 0, ichart)
                    Continue For
                ElseIf i = 2 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "February", 0, ichart)
                    Continue For
                ElseIf i = 3 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "March", 0, ichart)
                    Continue For
                ElseIf i = 4 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "April", 0, ichart)
                    Continue For
                ElseIf i = 5 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "May", 0, ichart)
                    Continue For
                ElseIf i = 6 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "June", 0, ichart)
                    Continue For
                ElseIf i = 7 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "July", 0, ichart)
                    Continue For
                ElseIf i = 8 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "August", 0, ichart)
                    Continue For
                ElseIf i = 9 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "September", 0, ichart)
                    Continue For
                ElseIf i = 10 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "October", 0, ichart)
                    Continue For
                ElseIf i = 11 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "November", 0, ichart)
                    Continue For
                ElseIf i = 12 Then
                    getchartm("select sum(squantity) from sales where month(sale_date)='" & i & "'", "month", "December", 0, ichart)
                    Continue For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


    Private Sub monthpb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles monthpb.SelectionChangeCommitted
        pchart.Series(0).Points.Clear()
        getchart("select proname, sum(squantity), sum(stotal) from sales where month(sale_date)='" & monthpb.SelectedIndex + 1 & "' GROUP by proname ORDER by sum(squantity) desc limit 5", "month", 0, 1, pchart)
    End Sub

End Class