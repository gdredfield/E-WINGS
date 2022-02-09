Public Class editrestockorder

    Dim Pos As Point
    Dim pricetb, rate As Integer
    Dim desctb, unit As String

    Private Sub editrestockorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            recdate.Format = DateTimePickerFormat.Custom
            recdate.CustomFormat = "dd/MM/yyyy"
            exdate.Format = DateTimePickerFormat.Custom
            exdate.CustomFormat = "dd/MM/yyyy"
            reload("select * from supplier", supplier)
            supplier.DisplayMember = "supp_name"
            supplier.ValueMember = "supp_name"
            idtb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(0).Value
            nametb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(1).Value
            stocktb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(6).Value
            recdate.Value = PurchaseOrderForm.dtgporder.CurrentRow.Cells(8).Value
            exdate.Value = PurchaseOrderForm.dtgporder.CurrentRow.Cells(9).Value
            supplier.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(10).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnAddsupp.Click
        Addsupplier.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel4.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim stockt As Integer
        Dim namet As New DataTable
        gettable("select * from ordertbl where or_name='" & nametb.Text & "'", namet)
        If nametb.Text = "" Then
            MessageBox.Show("Please enter a order name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text = "" Then
            MessageBox.Show("Please enter stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(stocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text < 1 Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf supplier.Text = "" Then
            MessageBox.Show("Please enter supplier value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf exdate.Value < recdate.Value Then
            MessageBox.Show("Expiration date must be set later than Receiving date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf exdate.Value = recdate.Value Then
            MessageBox.Show("Expiration date must be set later than Receiving date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate order names'
            'ElseIf namet.Rows.Count() > 0 Then'
            'MessageBox.Show(nametb.Text + " already exists." & vbCrLf & "Please enter different order name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) '
        Else
            Try
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                updated("update ordertbl set or_stock='" & stocktb.Text & "', or_recdate='" & recdate.Value.ToString("yyyy/MM/dd") & "', or_exdate='" & exdate.Value.ToString("yyyy/MM/dd") & "', supplier='" & supplier.Text & "' where or_id='" & idtb.Text & "'")
                reload("Select * from ordertbl", PurchaseOrderForm.dtgporder)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stocktb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class