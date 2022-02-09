Public Class Supplierform
    Dim defquery As String = "select * from supplier where supp_name<>'N/A'"
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Supplierform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            sortcb.Text = "Default"
            searchcb.Text = "Supplier"
            reload(defquery, dtgsupp)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        Try
            If sortcb.Text = "Default" Then
                reload(defquery, dtgsupp)
            ElseIf sortcb.Text = "Supplier" Then
                reload(defquery + " ORDER BY supp_name ASC", dtgsupp)
            ElseIf sortcb.Text = "ContactPerson" Then
                reload(defquery + " ORDER BY contactPerson ASC", dtgsupp)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        If searchcb.Text = "Supplier" Then
            reload(defquery + "AND concat(supp_name) like '%" & searchbox.Text & "%'", dtgsupp)
        ElseIf searchcb.Text = "ContactPerson" Then
            reload(defquery + "AND concat(contactPerson) like '%" & searchbox.Text & "%'", dtgsupp)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dtgsupp.SelectedCells.Count() = 0 Or dtgsupp.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from supplier where supp_id = ('" & dtgsupp.CurrentRow.Cells(0).Value & "')")
                    reload(defquery, dtgsupp)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Addsupplier.Show()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dtgsupp.SelectedCells.Count() = 0 Or dtgsupp.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Editsupplier.Show()
        End If
    End Sub
End Class