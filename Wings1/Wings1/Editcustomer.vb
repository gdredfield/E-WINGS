Public Class Editcustomer
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Editcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            idtb.Text = CustomerForm.dtgcus.CurrentRow.Cells(0).Value
            fnametb.Text = CustomerForm.dtgcus.CurrentRow.Cells(1).Value
            lnametb.Text = CustomerForm.dtgcus.CurrentRow.Cells(2).Value
            addresstb.Text = CustomerForm.dtgcus.CurrentRow.Cells(3).Value
            baranggaytb.Text = CustomerForm.dtgcus.CurrentRow.Cells(4).Value
            citytb.Text = CustomerForm.dtgcus.CurrentRow.Cells(5).Value
            ziptb.Text = CustomerForm.dtgcus.CurrentRow.Cells(6).Value
            emailtb.Text = CustomerForm.dtgcus.CurrentRow.Cells(7).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub confirmbut_Click(sender As Object, e As EventArgs) Handles confirmbut.Click
        Try

            updated("update customer set fname='" & fnametb.Text & "',lname='" & lnametb.Text & "',address='" & addresstb.Text & "',baranggay='" & baranggaytb.Text & "',city='" & citytb.Text & "',zip='" & ziptb.Text & "',email='" & emailtb.Text & "' where custom_id='" & idtb.Text & "'")
                reload("select * from customer", CustomerForm.dtgcus)
                Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class