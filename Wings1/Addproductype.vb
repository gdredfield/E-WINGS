Public Class Addproductype
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        reload("select * from category", addproduct.typecb)
        addproduct.typecb.DisplayMember = "prod_type"
        addproduct.typecb.ValueMember = "prod_type"
        reload("select * from category", editproduct.typecb)
        editproduct.typecb.DisplayMember = "prod_type"
        editproduct.typecb.ValueMember = "prod_type"
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Addproductype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        reload("Select * from category", dtgg)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim checc As New DataTable
            gettable("select * from category where prod_type='" & cattb.Text & "'", checc)
            If checc.Rows.Count > 0 Then
                MessageBox.Show("This type already exists!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf cattb.Text = "" Then
                MessageBox.Show("Please enter product type!", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                create("INSERT into category(prod_type) values ('" & cattb.Text & "')")
                reload("Select * from category", dtgg)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dtgg.SelectedCells.Count() = 0 Or dtgg.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                delete("delete from category where prod_type = ('" & dtgg.CurrentRow.Cells(0).Value & "')")
                reload("Select * from category", dtgg)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

End Class