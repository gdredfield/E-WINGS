Public Class restockaddorder

    Dim Pos As Point
    Dim pricetb, rate As Integer
    Dim desctb, unit As String
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub restockaddorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim info As New DataTable()
            gettable("select * from ingredients where ing_id='" & restockform.lowdt.CurrentRow.Cells(0).Value & "'", info)
            Me.CenterToScreen()
            nametb.Text = info.Rows(0)(1).ToString()
            desctb = info.Rows(0)(2).ToString()
            pricetb = info.Rows(0)(3).ToString()
            unit = info.Rows(0)(5).ToString()
            stocktb.Text = 0
            rate = info.Rows(0)(7).ToString()
            recdate.Format = DateTimePickerFormat.Custom
            recdate.CustomFormat = "dd/MM/yyyy"
            recdate.Value = DateTime.Now()
            Dim date1 As Date = info.Rows(0)(8).ToString()
            Dim date2 As Date = info.Rows(0)(9).ToString()
            Dim days As Integer = (date2.Date - date1.Date).Days
            exdate.Format = DateTimePickerFormat.Custom
            exdate.CustomFormat = "dd/MM/yyyy"
            exdate.Value = DateTime.Now.AddDays(days)
            reload("select * from supplier", supplier)
            supplier.DisplayMember = "supp_name"
            supplier.ValueMember = "supp_name"
            supplier.Text = info.Rows(0)(10).ToString()
            Dim oldid As String
            Dim newid As String
            Dim year As String = Date.Today.Year
            gett("select or_id from ordertbl ORDER BY or_id DESC LIMIT 1", idtb)
            If idtb.Text = "" Then
                idtb.Text = "ORDR" & year & 1
            Else
                oldid = idtb.Text.Remove(0, 8)
                newid = oldid + 1
                idtb.Text = "ORDR" + year + newid
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
                create("INSERT INTO `ordertbl`(`or_id`, `or_name`, `or_desc`, `or_price`, `or_status`, `or_unit`, `or_stock`, `or_rate`, `or_recdate`, `or_exdate`, `supplier`) VALUES('" & idtb.Text & "','" & nametb.Text & "','" & desctb & "','" & pricetb & "','RESTOCK','" & unit & "','" & stocktb.Text & "','" & rate & "','" & recdate.Value.ToString("yyyy/MM/dd") & "','" & exdate.Value.ToString("yyyy/MM/dd") & "','" & supplier.Text & "')")
                reload("Select * from ordertbl", PurchaseOrderForm.dtgporder)
                restockform.Show()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
        restockform.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnAddsupp.Click
        Addsupplier.Show()
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stocktb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class