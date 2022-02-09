Public Class addpstock

    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub addpstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label2.Text = "Product: " + Lowstockproduct.lowdt.CurrentRow.Cells(1).Value.ToString

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stock As Integer
        If stocktb.Text = "" Then
            MessageBox.Show("Please enter quantity!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(stocktb.Text, stock) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text <= 0 Then
            MessageBox.Show("Please enter higher quantity!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                updated("update product set prod_stock= prod_stock+'" & stocktb.Text & "' where prod_id='" & Lowstockproduct.lowdt.CurrentRow.Cells(0).Value.ToString & "'")
                Dim prodt2 As New DataTable
                updated2("update product set prod_status='Available' where prod_stock>0")
                reload("select prod_id,prod_name,prod_stock from product ORDER BY prod_stock ASC", Lowstockproduct.lowdt)

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


End Class