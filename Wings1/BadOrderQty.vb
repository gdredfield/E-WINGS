Public Class BadOrderQty

    Dim Pos As Point
    Dim orID, itname As String

    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub BadOrderQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        orID = BadOrder.badordersdt.CurrentRow.Cells(0).Value
        itname = BadOrder.badordersdt.CurrentRow.Cells(1).Value
        maxqtylbl.Text = BadOrder.badordersdt.CurrentRow.Cells(2).Value
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub confirmbtn_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim qtyi As Integer
        Dim ingdata As New DataTable


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
                updated2("update orderhistory set ord_stock = ord_stock + " & qtytb.Text & " where ord_id = '" & orID & "'")

                gettable("select * from ingredients where ing_name = '" & itname & "' limit 1", ingdata)

                If qtyi = Integer.Parse(maxqtylbl.Text) Then
                    delete("delete from badorders where or_id='" & orID & "'", False)
                Else
                    updated2("update badorders set qty = qty - " & qtytb.Text & " where or_id = '" & orID & "'")
                End If

                If ingdata.Rows.Count = 1 Then
                    updated2("update ingredients set ing_stock = ing_stock + " & qtytb.Text & " where ing_name = '" & itname & "'")
                End If

                MessageBox.Show("Returned successful!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BadOrder.RefreshTable()
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