
Imports System.ComponentModel
Public Class Expiredform

    Dim defquery As String = "select exid,it_id,it_name,it_price,it_unit,it_stock,it_rec,it_ex,supply from expired"

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        updated2("update expired set it_status='checked'")
        Dim forview2 As New DataTable
        Productform.expireden.Clear()
        gettable("select exid,it_id from expired where it_status='unchecked'", forview2)
        If forview2.Rows.Count > 0 Then
            For i As Integer = 0 To forview2.Rows.Count - 1
                Dim inidd As String = forview2(i)(1).ToString
                Productform.expireden.Add(inidd)
            Next
        End If
        reload("Select * from ingredients", Productform.dtglist2)

        Dim lblexpire As New DataTable
        gettable("select count(*) from expired where it_status='unchecked'", lblexpire)
        If lblexpire.Rows(0)(0) > 0 Then
            dashboard1.lblExpired.Text = lblexpire.Rows(0)(0)
        Else
            dashboard1.lblExpired.Text = "0"
        End If
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Expiredform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        sortcb.Text = "Default"
        searchcb.Text = "ItemName"
        reload(defquery + " ORDER BY it_ex DESC ", dtgexp)
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Try
            If searchcb.Text = "ID" Then
                reload(defquery + " where concat(it_id) like '%" & searchbox.Text & "%'", dtgexp)
            ElseIf searchcb.Text = "ItemName" Then
                reload(defquery + " where concat(it_name) like '%" & searchbox.Text & "%'", dtgexp)
            ElseIf searchcb.Text = "Price" Then
                reload(defquery + " where concat(it_price) like '%" & searchbox.Text & "%'", dtgexp)
            ElseIf searchcb.Text = "ReceivingDate" Then
                reload(defquery + " where concat(it_rec) like '%" & searchbox.Text & "%'", dtgexp)
            ElseIf searchcb.Text = "ExpirationDate" Then
                reload(defquery + " where concat(it_ex) like '%" & searchbox.Text & "%'", dtgexp)
            ElseIf searchcb.Text = "Supplier" Then
                reload(defquery + " where concat(supply) like '%" & searchbox.Text & "%'", dtgexp)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        If sortcb.Text = "ItemName" Then
            reload(defquery + " ORDER BY it_name ASC", dtgexp)
        ElseIf sortcb.Text = "ItemPrice" Then
            reload(defquery + " ORDER BY it_price ASC", dtgexp)
        ElseIf sortcb.Text = "ItemID" Then
            reload(defquery + " ORDER BY it_id ASC", dtgexp)
        ElseIf sortcb.Text = "FromLatest" Then
            reload(defquery + " ORDER BY it_ex DESC", dtgexp)
        ElseIf sortcb.Text = "FromOldest" Then
            reload(defquery + " ORDER BY it_ex ASC", dtgexp)
        ElseIf sortcb.Text = "Default" Then
            reload(defquery, dtgexp)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dtgexp.SelectedCells.Count = 0 Or dtgexp.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from expired where exid='" & dtgexp.CurrentRow.Cells(0).Value & "'")
                    reload(defquery, dtgexp)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
