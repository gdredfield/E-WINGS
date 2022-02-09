Imports MySql.Data.MySqlClient

Public Class AddOrder
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
        gettable("select * from ordertbl where or_name='" & nametb.Text & "'", namet)
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
            'ElseIf namet.Rows.Count() > 0 Then'
            'MessageBox.Show(nametb.Text + " already exists." & vbCrLf & "Please enter different order name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) '
        Else
            Try
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                create("INSERT INTO `ordertbl`(`or_id`, `or_name`, `or_desc`, `or_price`, `or_status`, `or_unit`, `or_stock`, `or_rate`, `or_recdate`, `or_exdate`, `supplier`) VALUES('" & idtb.Text & "','" & nametb.Text & "','" & desctb.Text & "','" & pricetb.Text & "','PENDING','" & unit & "','" & stocktb.Text & "','" & rate.Text & "','" & recdate.Value.ToString("yyyy/MM/dd") & "','" & exdate.Value.ToString("yyyy/MM/dd") & "','" & supplier.Text & "')")
                Dim oldid As String
                Dim newid As String
                Dim year As String = Date.Today.Year
                gett("select * from ordertbl ORDER BY or_id DESC LIMIT 1", idtb)
                oldid = idtb.Text.Remove(0, 8)
                newid = oldid + 1
                idtb.Text = "ORDR" + year.ToString + newid.ToString
                nametb.Text = ""
                desctb.Text = ""
                pricetb.Text = ""
                unittb.Text = "Pack"
                weightN.Text = ""
                weightAbv.Text = "kg"
                stocktb.Text = ""
                rate.Text = ""
                supplier.Text = ""
                reload("Select * from ordertbl", PurchaseOrderForm.dtgporder)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AddPurchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            weightAbv.Text = "kg"
            unittb.Text = "Pack"
            recdate.Format = DateTimePickerFormat.Custom
            recdate.CustomFormat = "dd/MM/yyyy"
            recdate.Value = DateTime.Now()
            exdate.Format = DateTimePickerFormat.Custom
            exdate.CustomFormat = "dd/MM/yyyy"
            exdate.Value = DateTime.Now.AddDays(1)
            reload("select * from supplier", supplier)
            supplier.DisplayMember = "supp_name"
            supplier.ValueMember = "supp_name"

            Dim oldid, newid As String
            Dim year As String = Date.Today.Year
            Dim eddata As New DataTable
            gettable("select * from ordertbl ORDER BY or_id DESC LIMIT 1", eddata)
            If eddata.Rows.Count = 1 Then
                idtb.Text = eddata.Rows(0)(0).ToString
                oldid = idtb.Text.Remove(0, 8)
                newid = oldid + 1
                idtb.Text = "ORDR" + year.ToString + newid.ToString
            Else
                idtb.Text = "ORDR" + year.ToString + "1"
            End If
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