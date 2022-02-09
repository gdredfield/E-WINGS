Public Class PurchaseOrderQty

    Dim Pos As Point
    Dim orID, itname As String

    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub PurchaseOrderQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        orID = orderhistory.dtghist.CurrentRow.Cells(0).Value
        itname = orderhistory.dtghist.CurrentRow.Cells(1).Value
        maxqtylbl.Text = orderhistory.dtghist.CurrentRow.Cells(6).Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub confirmbtn_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim qtyi As Integer

        If qtytb.Text = "" Then
            MessageBox.Show("Please enter quantity value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(qtytb.Text, qtyi) Then
            MessageBox.Show("Please enter a valid quantity value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf qtytb.Text < 1 Then
            MessageBox.Show("Please enter a valid quantity value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf qtytb.Text > Integer.Parse(maxqtylbl.Text) Then
            MessageBox.Show("Please enter a valid quantity value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim existingData, ingdata As New DataTable
                gettable("select * from badorders where or_id = '" & orID & "' limit 1", existingData)
                gettable("select * from ingredients where ing_name = '" & itname & "' limit 1", ingdata)

                If existingData.Rows.Count = 1 Then
                    updated2("update badorders set qty = qty + " & qtytb.Text & " where or_id = '" & orID & "'")
                Else
                    create2("insert into badorders (or_id, qty) values ('" & orID & "', '" & qtytb.Text & "')")
                End If

                updated2("update orderhistory set ord_stock = ord_stock - " & qtytb.Text & " where ord_id = '" & orID & "'")
                If ingdata.Rows.Count = 1 Then
                    updated2("update ingredients set ing_stock = ing_stock -" & qtytb.Text & " where ing_name = '" & itname & "'")
                End If
                MessageBox.Show("Added successful!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reload("select *, (ord_price * ord_stock) total_price from orderhistory where ord_stock<>0 ORDER BY ord_recdate DESC ", orderhistory.dtghist)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles qtytb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class