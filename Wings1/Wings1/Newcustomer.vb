Public Class Newcustomer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub BunifuThinButton26_Click(sender As Object, e As EventArgs)
        Try
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
            Else
                create("insert into customer(fname,lname,address,baranggay,city,zip,email) values('" & fnametb.Text & "','" & lnametb.Text & "','" & baranggaytb.Text & "','" & addresstb.Text & "','" & citytb.Text & "','" & ziptb.Text & "','" & emailtb.Text & "')")
            End If
            reload("select * from customer", CustomerForm.dtgcus)
            reload("select * from customer", editsale.customcb)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub confirmbut_Click(sender As Object, e As EventArgs) Handles confirmbut.Click
        Try
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
            Else
                create("insert into customer(fname,lname,address,baranggay,city,zip,email) values('" & fnametb.Text & "','" & lnametb.Text & "','" & baranggaytb.Text & "','" & addresstb.Text & "','" & citytb.Text & "','" & ziptb.Text & "','" & emailtb.Text & "')")
                Me.Close()
            End If
            reload("select * from customer", CustomerForm.dtgcus)
            reload("select * from customer", editsale.customcb)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Newcustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class