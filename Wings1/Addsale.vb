Imports MySql.Data.MySqlClient

Public Class AddSale
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Public table As New DataTable("Table")
    Private Sub AddSale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        idtb.Text = "No product selected"
        nametb.Text = "-"
        pricetb.Text = "-"
        stocktb.Text = "-"
        statuscb.Text = "-"
        dcpercent.Text = "0.00"
        dcamount.Text = "0.00"
        ' product queue table '
        table.Columns.Add("Product ID", Type.GetType("System.String"))
        table.Columns.Add("Product", Type.GetType("System.String"))
        table.Columns.Add("Quantity", Type.GetType("System.Int32"))
        table.Columns.Add("Amount", Type.GetType("System.Double"))
        table.Columns.Add("DiscountPer", Type.GetType("System.Double"))
        table.Columns.Add("DiscountBal", Type.GetType("System.Double"))
        prodq.DataSource = table
        prodq.Columns(0).Visible = False
        prodq.Columns(3).DefaultCellStyle.Format = "N2"
        prodq.Columns(4).DefaultCellStyle.Format = "N2"
        prodq.Columns(5).DefaultCellStyle.Format = "N2"
        Try
            'only available products are shown'
            reload("Select * from product where prod_status='Available'", searchcb)
            searchcb.DisplayMember = "prod_name"
            searchcb.ValueMember = "prod_id"
            Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
            Dim con As New connection()
            Dim command As New MySqlCommand("Select * from category", con.getconn())
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            Dim cust As New DataTable()
            gettable("select custom_id, concat(fname,' ',lname) as name from customer", cust)
            custommcb.DataSource = cust
            custommcb.DisplayMember = "name"
            custommcb.ValueMember = "custom_id"
            custommcb.Text = "Default Guest"
        Catch ex As Exception
            MessageBox.Show(ex.message)
        End Try
    End Sub


    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles quantitytb.TextChanged
        Try
            Dim price, quantity, total, dcper, dcam As Double
            Double.TryParse(pricetb.Text, price)
            Double.TryParse(quantitytb.Text, quantity)
            Double.TryParse(dcpercent.Text, dcper)
            Double.TryParse(dcamount.Text, dcam)
            If dcper > 0 Then
                dcper = dcper * 0.01
                total = price * quantity
                dcam = total * dcper
                total = total - dcam
                dcamount.Text = dcam.ToString("N2")
                totaltb.Text = total.ToString("N2")
            Else
                total = price * quantity
                totaltb.Text = total.ToString("N2")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ans As DialogResult
            ans = MessageBox.Show("Are you sure you want to clear queue?", "Clear Progress", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                idtb.Text = "No product selected"
                nametb.Text = "-"
                pricetb.Text = "-"
                stocktb.Text = "-"
                quantitytb.Text = ""
                statuscb.Text = "-"
                totaltb.Text = ""
                custommcb.Text = "Default Guest"
                dcamount.Text = "0.00"
                dcpercent.Text = "0.00"
                table.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If prodq.Rows.Count = 0 Or prodq.SelectedCells.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                If Not prodq.CurrentRow.IsNewRow Then
                    Dim ans As DialogResult
                    ans = MessageBox.Show("Do you want to remove this product from queue?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If ans = DialogResult.Yes Then
                        prodq.Rows.Remove(prodq.CurrentRow)
                    End If
                Else
                    MessageBox.Show("You cannot delete empty row", "Remove Product", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            'current item count in db if it meets number of servings-- item log --
            'Dim curCount, ingdatt As New DataTable
            'gettable("select ing_rate from ingredients where ing_id='" & table1.Rows(i)(2) & "'", ingdatt) 'ing rate/servings'
            'gettable("select count(*)%" & ingdatt.Rows(0)(0).ToString & " as curCount from item_log where itemid='" & table1.Rows(i)(2) & "'", curCount) 'item count modulus by ing rate
            'Dim dbCount As Integer = curCount.Rows(0)(0)
            'Dim ingratt As Integer = ingdatt.Rows(0)(0)
            'Dim divCount As Integer = (dbCount + quantitytb.Text) / ingratt

            'ingredient sufficiency confirmation'
            Dim insuffi As New DataTable()
            Dim quancheck As Integer
            If prodq.Rows.Count > 0 Then
                For jl As Integer = 0 To prodq.Rows.Count - 1
                    If idtb.Text = prodq.Rows(jl).Cells(0).Value Then
                        quancheck = prodq.Rows(jl).Cells(2).Value + quantitytb.Text
                        gettable("select prodsettings.iid, prodsettings.iname FROM prodsettings inner join ingredients on ingredients.ing_id = prodsettings.iid where proid = '" & idtb.Text & "' and (ingredients.ing_stock*ingredients.ing_rate)<'" & quancheck.ToString & "'", insuffi)
                        Exit For
                    End If
                Next
            Else
                gettable("select prodsettings.iid, prodsettings.iname FROM prodsettings inner join ingredients on ingredients.ing_id = prodsettings.iid where proid = '" & idtb.Text & "' and (ingredients.ing_stock*ingredients.ing_rate)<'" & quantitytb.Text & "'", insuffi)
            End If

            Dim instock, quan, amou, disc As Double
            Double.TryParse(stocktb.Text, instock)
            Double.TryParse(quantitytb.Text, quan)
            Double.TryParse(totaltb.Text, amou)
            Double.TryParse(dcpercent.Text, disc)
            Dim counter, higher, finaq, testQuan As Integer
            Dim scann, finamount, findisc As Double

            For i As Integer = 0 To prodq.Rows.Count() - 1
                If idtb.Text = prodq.Rows(i).Cells(0).Value Then
                    Dim currents As Integer
                    currents = prodq.Rows(i).Cells(2).Value
                    scann = prodq.Rows(i).Cells(2).Value + quan
                    finamount = prodq.Rows(i).Cells(3).Value + amou
                    If Not prodq.Rows(i).Cells(4).Value = disc Then
                        findisc = prodq.Rows(i).Cells(4).Value + disc
                    Else
                        findisc = prodq.Rows(i).Cells(4).Value
                    End If
                    If instock < scann Then
                        higher = higher + 1
                        Exit For
                    Else
                        prodq.Rows.Remove(prodq.Rows(i))
                        finaq = currents + quantitytb.Text
                        counter = counter + 1
                        Exit For
                    End If
                End If
            Next
            'quantity validations'
            If idtb.Text = "No product selected" Or idtb.Text = "" Then
                MessageBox.Show("No product selected!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf quantitytb.Text = "" Or quan < 1 Or Not Integer.TryParse(quantitytb.Text, testQuan) Then
                MessageBox.Show("Please enter a valid quantity!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf instock < quan Then
                MessageBox.Show(nametb.Text + " has insufficient stocks!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf insuffi.Rows.Count > 0 Then
                MessageBox.Show(nametb.Text + " has " + insuffi.Rows.Count.ToString() + " ingredients With insufficient stocks!", "Check Out Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf higher > 0 Then
                MessageBox.Show(nametb.Text + " has insufficient stocks!", "Add Product Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                higher = 0
            ElseIf counter > 0 Then
                table.Rows.Add(idtb.Text, nametb.Text, finaq, finamount, findisc, dcamount.Text)
                counter = 0
            Else
                table.Rows.Add(idtb.Text, nametb.Text, quantitytb.Text, totaltb.Text, dcpercent.Text, dcamount.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Try
            If prodq.RowCount < 1 Then
                MessageBox.Show("No product added!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to proceed checkout?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    PaymentWindow.Show()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub searchcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles searchcb.SelectionChangeCommitted
        Try
            Dim prro As New DataTable
            gettable("select * from product where prod_id='" & searchcb.SelectedValue & "'", prro)
            idtb.Text = prro.Rows(0)(0).ToString
            nametb.Text = prro.Rows(0)(1).ToString
            pricetb.Text = prro.Rows(0)(3).ToString
            stocktb.Text = prro.Rows(0)(5).ToString
            statuscb.Text = prro.Rows(0)(7).ToString

            Dim price, quantity, total, dcper, dcam As Double
            Double.TryParse(pricetb.Text, price)
            Double.TryParse(quantitytb.Text, quantity)
            Double.TryParse(dcpercent.Text, dcper)
            Double.TryParse(dcamount.Text, dcam)
            If dcper > 0 Then
                dcper = dcper * 0.01
                total = price * quantity
                dcam = total * dcper
                total = total - dcam
                dcamount.Text = dcam.ToString("N2")
                totaltb.Text = total.ToString("N2")
            Else
                total = price * quantity
                totaltb.Text = total.ToString("N2")
            End If
        Catch ex As Exception
            MessageBox.Show((ex.Message))
        End Try


    End Sub

    Private Sub dcpercent_TextChanged(sender As Object, e As EventArgs) Handles dcpercent.TextChanged
        Try
            Dim dc As Double
            Dim dca As Double
            Double.TryParse(dcpercent.Text, dc)
            If Not Double.TryParse(dcpercent.Text, dca) And Not dcpercent.Text = "" Then
                MessageBox.Show("Invalid discount value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dcpercent.Text = ""
            ElseIf dcpercent.Text = "" Or dc < 1 Then
                dcamount.Text = "0.00"
                Dim price, quantity, total As Double
                Double.TryParse(pricetb.Text, price)
                Double.TryParse(quantitytb.Text, quantity)
                total = price * quantity
                totaltb.Text = total.ToString("N2")
            ElseIf dc > 100 Then
                MessageBox.Show("Invalid discount value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                dcamount.Text = "0.00"
                dcpercent.Text = ""
                Dim price, quantity, total As Double
                Double.TryParse(pricetb.Text, price)
                Double.TryParse(quantitytb.Text, quantity)
                total = price * quantity
                totaltb.Text = total.ToString("N2")
            Else
                Dim price, quantity, total, dcper, dcam As Double
                    Double.TryParse(pricetb.Text, price)
                    Double.TryParse(quantitytb.Text, quantity)
                    Double.TryParse(dcpercent.Text, dcper)
                    Double.TryParse(dcamount.Text, dcam)
                    dcper = dcper * 0.01
                    total = price * quantity
                    dcam = total * dcper
                    total = total - dcam
                    dcamount.Text = dcam.ToString("N2")
                totaltb.Text = total.ToString("N2")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dcpercent_Enter(sender As Object, e As EventArgs) Handles dcpercent.Enter
        Dim dc As Double
        Double.TryParse(dcpercent.Text, dc)
        If dc < 1 Or dcpercent.Text = "" Then
            dcpercent.Text = ""
        End If
    End Sub

    Private Sub dcpercent_Leave(sender As Object, e As EventArgs) Handles dcpercent.Leave
        Dim dc As Double
        Double.TryParse(dcpercent.Text, dc)
        If dc < 1 Or dcpercent.Text = "" Then
            dcpercent.Text = "0.00"
        End If
    End Sub

    Private Sub totaltb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles totaltb.KeyPress, quantitytb.KeyPress, dcpercent.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class