Imports MySql.Data.MySqlClient

Public Class EditOrder
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim unit As String
        unit = unittb.Text + "/" + weightN.Text + " " + weightAbv.Text
        Dim pricet, stockt As Integer
        Dim namet As New DataTable
        gettable("select * from ordertbl where or_name='" & nametb.Text & "' and or_id != '" & idtb.Text & "'", namet)
        If nametb.Text = "" Then
            MessageBox.Show("Please enter a order name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf desctb.Text = "" Then
            MessageBox.Show("Please enter a order description.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf pricetb.Text = "" Then
            MessageBox.Show("Please enter a order price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(pricetb.Text, pricet) Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf pricetb.Text < 1 Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf weightN.Text = "" Then
            MessageBox.Show("Please enter weight.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text = "" Then
            MessageBox.Show("Please enter stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(stocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text < 1 Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf rate.Text = "" Then
            MessageBox.Show("Please enter rate value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(rate.Text, stockt) Then
            MessageBox.Show("Please enter a valid rate value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf rate.Text < 1 Then
            MessageBox.Show("Please enter a valid rate value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf supplier.Text = "" Then
            MessageBox.Show("Please enter supplier value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf exdate.Value < recdate.Value Then
            MessageBox.Show("Expiration date must be set later than Receiving date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf exdate.Value = recdate.Value Then
            MessageBox.Show("Expiration date must be set later than Receiving date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate order names'
        ElseIf namet.Rows.Count() > 0 Then
            MessageBox.Show(nametb.Text + " already exists." & vbCrLf & "Please enter different order name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                updated("UPDATE ordertbl set or_name='" & nametb.Text & "', or_desc='" & desctb.Text & "', or_price='" & pricetb.Text & "', or_unit='" & unit & "', or_stock='" & stocktb.Text & "', or_rate='" & rate.Text & "', or_recdate='" & recdate.Value.ToString("yyyy/MM/dd") & "', or_exdate='" & exdate.Value.ToString("yyyy/MM/dd") & "', supplier='" & supplier.Text & "' where or_id='" & idtb.Text & "'")
                reload("Select * from ordertbl", PurchaseOrderForm.dtgporder)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AddPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim unite As String = PurchaseOrderForm.dtgporder.CurrentRow.Cells(5).Value
        Dim unitt() As String = unite.Split("/")
        Dim unitt2() As String = unitt(1).Split(" ")
        unittb.Text = unitt(0)
        weightAbv.Text = unitt2(1)
        weightN.Text = unitt2(0)

        recdate.Format = DateTimePickerFormat.Custom
        recdate.CustomFormat = "dd/MM/yyyy"
        exdate.Format = DateTimePickerFormat.Custom
        exdate.CustomFormat = "dd/MM/yyyy"
        reload("select * from supplier", supplier)
        supplier.DisplayMember = "supp_name"
        supplier.ValueMember = "supp_name"
        Try
            idtb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(0).Value
            nametb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(1).Value
            desctb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(2).Value
            pricetb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(3).Value
            stocktb.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(6).Value
            rate.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(7).Value
            recdate.Value = PurchaseOrderForm.dtgporder.CurrentRow.Cells(8).Value
            exdate.Value = PurchaseOrderForm.dtgporder.CurrentRow.Cells(9).Value
            supplier.Text = PurchaseOrderForm.dtgporder.CurrentRow.Cells(10).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Addsupplier.Show()
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles weightN.KeyPress, pricetb.KeyPress, stocktb.KeyPress, rate.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class