Public Class addistock

    Dim Pos As Point
    Private Sub Panel3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel3.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub addistock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label2.Text = "Ingredient: " + Lowstock.lowdt.CurrentRow.Cells(1).Value.ToString
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
                updated("update ingredients set ing_stock= ing_stock+'" & stocktb.Text & "' where ing_id='" & Lowstock.lowdt.CurrentRow.Cells(0).Value.ToString & "'")
                updated2("update ingredients set ing_status='Available' where ing_stock>0")
                reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients ORDER BY ing_stock ASC", Lowstock.lowdt)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class