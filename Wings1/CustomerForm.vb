Public Class CustomerForm

    Private Sub OrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        sortcb.Text = "Default"
        searchcb.Text = "Name"
        reload("select * from customer", dtgcus)
    End Sub

    Private Sub searchbox_TextChanged_1(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Try
            If searchcb.Text = "ID" Then
                reload("select * from customer where concat(custom_id) like '%" & searchbox.Text & "%'", dtgcus)
            ElseIf searchcb.Text = "Name" Then
                reload("select * from customer where concat(fname,lname) like '%" & searchbox.Text & "%'", dtgcus)
            ElseIf searchcb.Text = "City" Then
                reload("select * from customer where concat(city) like '%" & searchbox.Text & "%'", dtgcus)
            ElseIf searchcb.Text = "Baranggay" Then
                reload("select * from customer where concat(baranggay) like '%" & searchbox.Text & "%'", dtgcus)
            ElseIf searchcb.Text = "Email" Then
                reload("select * from customer where concat(email) like '%" & searchbox.Text & "%'", dtgcus)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        If sortcb.Text = "Default" Then
            reload("select * from customer", dtgcus)
        ElseIf sortcb.Text = "ID" Then
            reload("select * from customer ORDER BY custom_id ASC", dtgcus)
        ElseIf sortcb.Text = "First Name" Then
            reload("select * from customer ORDER BY fname ASC", dtgcus)
        ElseIf sortcb.Text = "Last Name" Then
            reload("select * from customer ORDER BY lname ASC", dtgcus)
        ElseIf sortcb.Text = "City" Then
            reload("select * from customer ORDER BY city ASC", dtgcus)
        ElseIf sortcb.Text = "Baranggay" Then
            reload("select * from customer ORDER BY baranggay ASC", dtgcus)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dtgcus.SelectedCells.Count = 0 Or dtgcus.Rows.Count = 0 Then
            MessageBox.Show("No record selected", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf dtgcus.CurrentRow.Cells(0).Value = 10 Then
            MessageBox.Show("Cannot edit default guest details", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Editcustomer.Show()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dtgcus.SelectedCells.Count = 0 Or dtgcus.Rows.Count = 0 Then
            MessageBox.Show("No record selected", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete customer record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from customer where custom_id='" & dtgcus.CurrentRow.Cells(0).Value.ToString() & "'")
                    reload("Select * from customer", dtgcus)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Newcustomer.Show()
    End Sub
End Class