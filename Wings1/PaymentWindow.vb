Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class PaymentWindow

    Public sum As Double
    Public cash As Double
    Public disc As Double
    Public disca As Double
    Public change As Double
    Private Sub PaymentWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            roundBtn(confirmbut)
            roundBtn(printbut)
            receipt.SelectionAlignment = HorizontalAlignment.Center
            confirmbut.Enabled = False
            printbut.Enabled = False
            For i As Integer = 0 To AddSale.prodq.Rows.Count() - 1
                sum += AddSale.prodq.Rows(i).Cells(3).Value
                disc += AddSale.prodq.Rows(i).Cells(4).Value
                disca += AddSale.prodq.Rows(i).Cells(5).Value
            Next
            receipt.AppendText(vbNewLine + "E-WINGS BY 8:25" + vbNewLine + vbNewLine)
            receipt.AppendText("Savor Wings at the Comfort of your Home!" + vbNewLine)
            receipt.AppendText("Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
            receipt.AppendText("Order Summary" + vbNewLine)
            receipt.AppendText("------------------------------------------------------------------------------------------" + vbNewLine)
            For i As Integer = 0 To AddSale.prodq.Rows.Count() - 1
                '& vbTab & AddSale.prodq.Rows(i).Cells(3).Value.ToString'
                Dim amount, dcper, dcamou As Double
                Double.TryParse(AddSale.prodq.Rows(i).Cells(3).Value, amount)
                Double.TryParse(AddSale.prodq.Rows(i).Cells(4).Value, dcper)
                Double.TryParse(AddSale.prodq.Rows(i).Cells(5).Value, dcamou)
                If AddSale.prodq.Rows(i).Cells(4).Value > 0 Then
                    receipt.AppendText(AddSale.prodq.Rows(i).Cells(1).Value.ToString + " x " + AddSale.prodq.Rows(i).Cells(2).Value.ToString + " = ₱" + amount.ToString("N2") + " (" + dcper.ToString("N2") + "% Discount)" + vbNewLine)
                Else
                    receipt.AppendText(AddSale.prodq.Rows(i).Cells(1).Value.ToString + " x " + AddSale.prodq.Rows(i).Cells(2).Value.ToString + " = ₱" + amount.ToString("N2") + vbNewLine)
                End If

            Next
            receipt.AppendText("------------------------------------------------------------------------------------------" + vbNewLine + vbNewLine)
            receipt.AppendText("Total Bill: " + "₱" + sum.ToString("N2") + vbNewLine)
            receipt.AppendText("Total Discount Amount: " + "₱" + disca.ToString("N2") + vbNewLine)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If printbut.Enabled = True Then
            AddSale.idtb.Text = "No product selected"
            AddSale.nametb.Text = "-"
            AddSale.pricetb.Text = "-"
            AddSale.stocktb.Text = "-"
            AddSale.quantitytb.Text = ""
            AddSale.statuscb.Text = "-"
            AddSale.totaltb.Text = ""
            AddSale.custommcb.Text = "Default Guest"
            AddSale.dcamount.Text = "0.00"
            AddSale.dcpercent.Text = "0.00"
            AddSale.table.Clear()
            Dim confirmcrit As New DataTable
            gettable("select count(*) from ingredients where (ing_stock*ing_rate)<=20", confirmcrit)
            dashboard1.rescount = 1
            If confirmcrit.Rows(0)(0) > 0 Then
                dashboard1.exscount = 1
                dashboard1.critconfirm = confirmcrit.Rows(0)(0)
            End If
            Me.Close()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub BunifuThinButton27_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub cpasstb_OnValueChanged(sender As Object, e As EventArgs) Handles cpasstb.OnValueChanged

        If Double.TryParse(cpasstb.Text, cash) Then
            If cash >= sum Then
                confirmbut.Enabled = True
                change = cash - sum
                Label2.Text = change.ToString("N2")
            Else
                confirmbut.Enabled = False

            End If
        Else
            confirmbut.Enabled = False
        End If
    End Sub

    Private Sub confirmbut_Click(sender As Object, e As EventArgs) Handles confirmbut.Click
        Try
            Dim con As New connection()
            Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
            Dim pscode As String = ""
            Dim oldid As String
            Dim newid As String
            Dim year As String = Date.Today.Year
            gett("select * from sales2 ORDER BY s_id DESC LIMIT 1", finid)
            oldid = finid.Text.Remove(0, 8)
            newid = oldid + 1
            finid.Text = "SALE" + year + newid
            For ii As Integer = 0 To AddSale.prodq.Rows.Count() - 1
                If AddSale.prodq.Rows.Count() = 1 Then
                    pscode = AddSale.prodq.Rows(ii).Cells(0).Value.ToString + "x" + AddSale.prodq.Rows(ii).Cells(2).Value.ToString
                Else
                    If AddSale.prodq.Rows.Count() - ii = 1 Then
                        pscode = pscode + AddSale.prodq.Rows(ii).Cells(0).Value.ToString + "x" + AddSale.prodq.Rows(ii).Cells(2).Value.ToString
                    Else
                        pscode = pscode + AddSale.prodq.Rows(ii).Cells(0).Value.ToString + "x" + AddSale.prodq.Rows(ii).Cells(2).Value.ToString + ", "
                    End If
                End If
                create2("insert into sales(prodid,proname,squantity,stotal,sale_date,schange, customer_id, dcperc, dcamo) values('" & AddSale.prodq.Rows(ii).Cells(0).Value.ToString & "','" & AddSale.prodq.Rows(ii).Cells(1).Value.ToString & "','" & AddSale.prodq.Rows(ii).Cells(2).Value.ToString & "','" & AddSale.prodq.Rows(ii).Cells(3).Value.ToString & "','" & timestamp & "','" & Label2.Text & "', '" & AddSale.custommcb.SelectedValue.ToString & "', '" & AddSale.prodq.Rows(ii).Cells(4).Value & "', '" & AddSale.prodq.Rows(ii).Cells(5).Value & "')")
                updated2("update product set prod_stock=prod_stock-'" & AddSale.prodq.Rows(ii).Cells(2).Value.ToString & "' where prod_id='" & AddSale.prodq.Rows(ii).Cells(0).Value.ToString & "'")

                'selecting all ingredients for the selected product'
                Dim table1 As New DataTable()
                gettable("select * from prodsettings where proid='" & AddSale.prodq.Rows(ii).Cells(0).Value.ToString & "'", table1)

                'deducting stocks based on servings and previous records'

                For i As Integer = 0 To table1.Rows.Count() - 1
                    'declarations
                    Dim subquantity As Integer = AddSale.prodq.Rows(ii).Cells(2).Value.ToString
                    Dim subit As New DataTable()
                    gettable("select sub_id,in_id,in_stock from subitem where in_id='" & table1.Rows(i)(2) & "' ORDER BY sub_id ASC", subit)

                    'current item count in db if it meets number of servings-- item log --
                    Dim curCount, ingdatt As New DataTable
                    gettable("select ing_rate from ingredients where ing_id='" & table1.Rows(i)(2) & "'", ingdatt) 'ing rate/servings'
                    gettable("select sum(qty)%" & ingdatt.Rows(0)(0).ToString & " as curCount from item_log where itemid='" & table1.Rows(i)(2) & "'", curCount) 'item count modulus by ing rate
                    Dim dbCount As Integer
                    If Not DBNull.Value.Equals(curCount.Rows(0)(0)) Then
                        dbCount = curCount.Rows(0)(0)
                    Else
                        dbCount = 0
                    End If
                    Dim ingratt As Integer = ingdatt.Rows(0)(0)
                    Dim divCount As Integer = (dbCount + subquantity) \ ingratt
                    Dim subbCount As Integer = divCount
                    'if the whole quantity meets the serving count, deduct a stock from the items'
                    If divCount > 0 Then
                        'deducting from subitem first if existing'
                        If subit.Rows.Count > 0 Then
                            For ip As Integer = 0 To subit.Rows.Count() - 1
                                Dim inst As Integer = subit.Rows(ip)(2)
                                If subbCount < 1 Then
                                    Exit For
                                ElseIf subbCount >= inst Then
                                    subbCount = subbCount - inst
                                    delete2("delete from subitem where sub_id='" & subit.Rows(ip)(0) & "'")
                                    Continue For
                                ElseIf inst > subbCount Then
                                    updated2("update subitem set in_stock=in_stock-'" & subbCount & "' where sub_id='" & subit.Rows(ip)(0) & "'")
                                    subbCount = 0
                                    Exit For
                                End If
                            Next
                        End If

                        'deduct and create record in stock deduction log
                        updated2("update ingredients set ing_stock=ing_stock-'" & divCount & "' where ing_id='" & table1.Rows(i)(2).ToString & "'")
                        create2("insert into stock_log(item_id,qty,sldate) values('" & table1.Rows(i)(2).ToString & "','" & divCount & "','" & timestamp & "')")
                    End If
                    'create usage records in item log
                    create2("insert into item_log(itemid,qty,scdate) values('" & table1.Rows(i)(2).ToString & "','" & subquantity.ToString & "','" & timestamp & "')")
                Next

            Next
            create2("insert into sales2(s_id,s_date,s_total,s_paid,s_change,ps_code,dcper,dcamount,custom_id) values('" & finid.Text & "','" & timestamp & "','" & sum.ToString("N2") & "','" & cash.ToString("N2") & "','" & change.ToString("N2") & "','" & pscode & "','" & disc.ToString("N2") & "','" & disca.ToString("N2") & "','" & AddSale.custommcb.SelectedValue.ToString & "')")
            'checking all products And ingredients that have 0 stocks'
            Dim prod As New DataTable()
            Dim ingd As New DataTable()
            Dim idate1 As Date = Date.Now
            gettable("select * from product where prod_stock<1", prod)
            gettable("select * from ingredients where ing_stock<1 or ex_date<='" & idate1.ToString("yyyy/MM/dd") & "'", ingd)
            'updating all products And ingredients that have 0 stocks to status unavailable'
            If prod.Rows.Count() > 0 Then
                updated2("update product set prod_status='Unavailable' where prod_stock<1")
            End If
            If ingd.Rows.Count() > 0 Then
                updated2("update ingredients set ing_status='Unavailable' where ing_stock<1 or ex_date<='" & idate1.ToString("yyyy/MM/dd") & "'")
            End If
            reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.dcperc, sales.dcamo, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid", Salesform.dtglist3)
            receipt.AppendText("------------------------------------------------------------------------------------------" + vbNewLine + vbNewLine)
            receipt.AppendText("Transaction Processed Successfully!" + vbNewLine + vbNewLine)
            receipt.AppendText("Total Amount Paid: " + "₱" + cash.ToString("N2") + vbNewLine)
            receipt.AppendText("Change: " + "₱" + change.ToString("N2") + vbNewLine)
            printbut.Enabled = True
            confirmbut.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(rtb1.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 100)
            e.Graphics.DrawString(rtb2.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            e.Graphics.DrawString(rtb3.Text, New Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, 100, 270)
            e.Graphics.DrawImage(Me.PictureBox1.Image, 380, 35, PictureBox1.Width - 15, PictureBox1.Height - 25)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ev.Graphics.DrawString(rtb1.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 100)
            ev.Graphics.DrawString(rtb2.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            ev.Graphics.DrawString(rtb3.Text, New Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, 100, 270)
            ev.Graphics.DrawImage(Me.PictureBox1.Image, 380, 35, PictureBox1.Width - 15, PictureBox1.Height - 25)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub printbut_Click(sender As Object, e As EventArgs) Handles printbut.Click
        rtb1.Text = ""
        rtb2.Text = ""
        rtb3.Text = ""
        Try
            rtb1.Text = ""
            Dim today = Date.Now.ToLongDateString
            rtb1.AppendText(vbNewLine + vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
            rtb2.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
            rtb2.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
            rtb2.AppendText("Order Summary" + vbTab + vbTab + vbTab + vbTab + vbTab + today + vbNewLine)
            rtb3.AppendText("------------------------------------------------------------------------------------------" + vbNewLine)

            For i As Integer = 0 To AddSale.prodq.Rows.Count() - 1
                rtb3.AppendText("Product Name:   " + vbTab + vbTab + vbTab + vbTab + vbTab + AddSale.prodq.Rows(i).Cells(1).Value.ToString + vbNewLine)
                rtb3.AppendText("Order Quantity:  " + vbTab + vbTab + vbTab + vbTab + vbTab + AddSale.prodq.Rows(i).Cells(2).Value.ToString + " (pcs) " + vbNewLine + "Amount:  " + vbTab + vbTab + vbTab + vbTab + vbTab + AddSale.prodq.Rows(i).Cells(3).Value.ToString + vbNewLine + vbNewLine)
            Next

            rtb3.AppendText("------------------------------------------------------------------------------------------" + vbNewLine)
            rtb3.AppendText("Total Bill: " + vbTab + vbTab + vbTab + vbTab + vbTab + sum.ToString("N2") + vbNewLine)
            rtb3.AppendText("Amount Paid: " + vbTab + vbTab + vbTab + vbTab + vbTab + cash.ToString("N2") + vbNewLine)
            rtb3.AppendText("Total Change: " + vbTab + vbTab + vbTab + vbTab + vbTab + change.ToString("N2") + vbNewLine)
            rtb3.AppendText("------------------------------------------------------------------------------------------" + vbNewLine)
            rtb3.AppendText(vbTab + "             " + "THANK YOU FOR DINING WITH US!" + vbNewLine)
            rtb3.AppendText(vbTab + vbTab + "        PLEASE COME AGAIN!" + vbNewLine)
            rtb3.AppendText(vbTab + vbTab + vbTab + PictureBox1.Text + vbNewLine)
            Dim printdoc As New PrintDocument
            AddHandler printdoc.PrintPage, AddressOf Me.PrintText
            PrintPreviewDialog1.ShowDialog()
            'printdoc.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cpasstb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class