Public Class Editcustomer
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub confirmbut_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim emailcheck As Boolean = IsValidEmailFormat(emailtb.Text)
            If fnametb.Text = "" Then
                MessageBox.Show("First name field is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf lnametb.Text = "" Then
                MessageBox.Show("Last name field is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf baranggaytb.Text = "" Then
                MessageBox.Show("Address field is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf addresstb.Text = "" Then
                MessageBox.Show("Baranggay field is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf citytb.Text = "" Then
                MessageBox.Show("City field is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ziptb.Text = "" Then
                MessageBox.Show("Zip field is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf emailtb.Text = "" Then
                MessageBox.Show("Email field is empty.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf emailcheck = False Then
                MessageBox.Show("Please input valid email!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                updated("update customer set fname='" & fnametb.Text & "',lname='" & lnametb.Text & "',address='" & addresstb.Text & "',baranggay='" & baranggaytb.Text & "',city='" & citytb.Text & "',zip='" & ziptb.Text & "',email='" & emailtb.Text & "' where custom_id='" & idtb.Text & "'")
                reload("select * from customer", CustomerForm.dtgcus)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ziptb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class