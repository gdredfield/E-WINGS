Public Class orderhistory
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub orderhistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            sortcb.Text = "Default"
            searchcb.Text = "ItemName"
            reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_id DESC ", dtghist)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        Try
            If sortcb.Text = "Default" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0", dtghist)
            ElseIf sortcb.Text = "ID" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_id ASC", dtghist)
            ElseIf sortcb.Text = "ItemName" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_name ASC", dtghist)
            ElseIf sortcb.Text = "Price" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_price ASC", dtghist)
            ElseIf sortcb.Text = "FromLatest" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_recdate DESC", dtghist)
            ElseIf sortcb.Text = "FromOldest" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_recdate ASC", dtghist)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Try
            If searchcb.Text = "ID" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where concat(ord_id) like '%" & searchbox.Text & "%' and ord_stock<>0", dtghist)
            ElseIf searchcb.Text = "ItemName" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where concat(ord_name) like '%" & searchbox.Text & "%' and ord_stock<>0", dtghist)
            ElseIf searchcb.Text = "Price" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where concat(ord_price) like '%" & searchbox.Text & "%' and ord_stock<>0", dtghist)
            ElseIf searchcb.Text = "ReceivingDate" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where concat(ord_recdate) like '%" & searchbox.Text & "%' and ord_stock<>0", dtghist)
            ElseIf searchcb.Text = "ExpirationDate" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where concat(ord_exdate) like '%" & searchbox.Text & "%' and ord_stock<>0", dtghist)
            ElseIf searchcb.Text = "Supplier" Then
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where concat(supplier) like '%" & searchbox.Text & "%' and ord_stock<>0", dtghist)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dtghist.SelectedCells.Count = 0 Or dtghist.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from orderhistory where ord_id='" & dtghist.CurrentRow.Cells(0).Value & "'")
                    reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_id DESC ", dtghist)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If dtghist.SelectedCells.Count = 0 Or dtghist.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            PurchaseOrderQty.Show()
        End If
    End Sub
End Class