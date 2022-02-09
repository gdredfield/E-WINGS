Imports System.Text
Imports System.Text.RegularExpressions

Public Class edititem
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub edititem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            Dim unite As String = Productform.dtglist2.CurrentRow.Cells(5).Value
            Dim unitt() As String = unite.Split("/")
            Dim unitt2() As String = unitt(1).Split(" ")
            unittb.Text = unitt(0)
            weightAbv.Text = unitt2(1)
            weightN.Text = unitt2(0)

            idate.Format = DateTimePickerFormat.Custom
            idate.CustomFormat = "dd/MM/yyyy"
            idate2.Format = DateTimePickerFormat.Custom
            idate2.CustomFormat = "dd/MM/yyyy"
            reload("select * from supplier", suppliertb)
            suppliertb.DisplayMember = "supp_name"
            suppliertb.ValueMember = "supp_name"
            iidtb.Text = Productform.dtglist2.CurrentRow.Cells(0).Value
            inametb.Text = Productform.dtglist2.CurrentRow.Cells(1).Value
            idesctb.Text = Productform.dtglist2.CurrentRow.Cells(2).Value
            ipricetb.Text = Productform.dtglist2.CurrentRow.Cells(3).Value
            istocktb.Text = Productform.dtglist2.CurrentRow.Cells(6).Value
            iratetb.Text = Productform.dtglist2.CurrentRow.Cells(7).Value
            idate.Value = Productform.dtglist2.CurrentRow.Cells(8).Value
            idate2.Value = Productform.dtglist2.CurrentRow.Cells(9).Value
            suppliertb.Text = Productform.dtglist2.CurrentRow.Cells(10).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'update ingredient'
        Dim unit As String
        unit = unittb.Text + "/" + weightN.Text + " " + weightAbv.Text
        Dim id As New TextBox
        Dim oldid As String
        Dim newid As String
        Dim year As String = Date.Today.Year
        gett("select ord_id from orderhistory ORDER BY ord_id DESC LIMIT 1", id)
        If id.Text = "" Then
            id.Text = "ORDH" & year & 1
        Else
            oldid = id.Text.Remove(0, 8)
            newid = oldid + 1
            id.Text = "ORDH" + year + newid
        End If
        Try
            Dim pricet, ratet, stockt As Integer
            Dim inamet As New DataTable
            gettable("select * from ingredients where ing_name='" & inametb.Text & "' and ing_id<>'" & iidtb.Text & "'", inamet)
            If inametb.Text = "" Then
                MessageBox.Show("Please enter a ingredient name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf idesctb.Text = "" Then
                MessageBox.Show("Please enter a ingredient description.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ipricetb.Text = "" Then
                MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not Integer.TryParse(ipricetb.Text, pricet) Then
                MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf ipricetb.Text < 1 Then
                MessageBox.Show("Please enter valid ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf unittb.Text = "" Then
                MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf weightN.Text = "" Then
                MessageBox.Show("Please enter weight.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf istocktb.Text = "" Then
                MessageBox.Show("Please enter a stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not Integer.TryParse(istocktb.Text, stockt) Then
                MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf istocktb.Text < 1 Then
                MessageBox.Show("Please enter valid stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf iratetb.Text = "" Then
                MessageBox.Show("Please enter a consumption rate.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not Integer.TryParse(iratetb.Text, ratet) Then
                MessageBox.Show("Please enter a valid consumption rate value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf iratetb.Text < 1 Then
                MessageBox.Show("Please enter valid consumption rate.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf idate2.Value < idate.Value Then
                MessageBox.Show("Expiration date must be set later than Receiving date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf idate2.Value = idate.Value Then
                MessageBox.Show("Expiration date must be set later than Receiving date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'validation to prevent duplicate ingredient names'
            ElseIf inamet.Rows.Count() > 0 Then
                MessageBox.Show(inametb.Text + " already exists." & vbCrLf & "Please enter different ingredient name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Productform.dtglist2.CurrentRow.Cells(6).Value < istocktb.Text Then
                    Dim date1 As Date = Productform.dtglist2.CurrentRow.Cells(8).Value
                    Dim date2 As Date = Productform.dtglist2.CurrentRow.Cells(9).Value
                    Dim days As Integer = (date2.Date - date1.Date).Days
                    idate.Value = DateTime.Now
                    idate2.Value = DateTime.Now.AddDays(days)
                    'updating ingredients'
                    Dim existingsub As New DataTable
                    Dim existingdates As New DataTable
                    gettable("select sum(in_stock) from subitem where in_id='" & iidtb.Text & "'", existingsub)
                    gettable("select in_rec,in_ex,sub_id from subitem where in_id='" & iidtb.Text & "' ORDER BY sub_id DESC LIMIT 1", existingdates)
                    'checking if item already exists in subitem table'
                    If Productform.dtglist2.CurrentRow.Cells(6).Value > 0 Then
                        If idate.Value.Date = date1.Date And idate2.Value.Date = date2.Date Then

                        ElseIf existingdates.Rows.Count > 0 Then
                            'getting dates from existing subitems and currently adding item for comparison'
                            Dim exist1 As Date = existingdates.Rows(0)(0)
                            Dim exist2 As Date = existingdates.Rows(0)(1)
                            'calculating new stock value to not miscalculate with previous records'
                            Dim currstock As Double
                            Double.TryParse(existingsub.Rows(0)(0), currstock)
                            Dim allstock As Double
                            Double.TryParse(Productform.dtglist2.CurrentRow.Cells(6).Value, allstock)
                            Dim newstock As Double = allstock - currstock
                            'if exact date already exists, stock numbers will merge in subitem table'

                            If exist1.Date = date1.Date And exist2.Date = date2.Date Then
                                updated2("update subitem set in_stock=in_stock+'" & newstock.ToString & "' where sub_id='" & existingdates.Rows(0)(2).ToString & "'")
                            Else
                                create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & iidtb.Text & "','" & inametb.Text & "','" & newstock.ToString & "','" & date1.ToString("yyyy/MM/dd") & "','" & date2.ToString("yyyy/MM/dd") & "')")
                            End If
                        Else
                            create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & iidtb.Text & "','" & inametb.Text & "','" & Productform.dtglist2.CurrentRow.Cells(6).Value.ToString & "','" & date1.ToString("yyyy/MM/dd") & "','" & date2.ToString("yyyy/MM/dd") & "')")
                        End If
                    End If
                    updated("update ingredients set ing_name='" & inametb.Text & "',ing_desc='" & idesctb.Text & "',ing_price='" & ipricetb.Text & "',ing_unit='" & unit & "',ing_stock='" & istocktb.Text & "',ing_rate='" & iratetb.Text & "',rec_date='" & idate.Value.ToString("yyyy/MM/dd") & "',ex_date='" & idate2.Value.ToString("yyyy/MM/dd") & "',supplier='" & suppliertb.Text & "' where ing_id='" & iidtb.Text & "'")
                    create2("insert into orderhistory(ord_id,ord_name,ord_desc,ord_price,ord_status,ord_unit,ord_stock,ord_rate,ord_recdate,ord_exdate,supplier,empuser) values('" & id.Text & "','" & inametb.Text & "','" & idesctb.Text & "','" & ipricetb.Text & "','COMPLETED','" & unit & "','" & istocktb.Text - Productform.dtglist2.CurrentRow.Cells(6).Value & "','" & iratetb.Text & "','" & idate.Value.ToString("yyyy/MM/dd") & "','" & idate2.Value.ToString("yyyy/MM/dd") & "','" & suppliertb.Text & "','" & dashboard1.btnEditUser.Text & "')")
                Else
                    'updating ingredients'
                    updated("update ingredients set ing_name='" & inametb.Text & "',ing_desc='" & idesctb.Text & "',ing_price='" & ipricetb.Text & "',ing_unit='" & unit & "',ing_stock='" & istocktb.Text & "',ing_rate='" & iratetb.Text & "',rec_date='" & idate.Value.ToString("yyyy/MM/dd") & "',ex_date='" & idate2.Value.ToString("yyyy/MM/dd") & "',supplier='" & suppliertb.Text & "' where ing_id='" & iidtb.Text & "'")
                End If
                'selecting all ingredients that are unavailable'
                Dim idate1 As Date = Date.Now
                Dim ingd As New DataTable
                Dim ingd2 As New DataTable
                gettable("select * from ingredients where ing_stock>0 and ing_status='Unavailable' and ex_date>='" & idate1.ToString("yyyy/MM/dd") & "'", ingd)
                gettable("select * from ingredients where ing_stock<1", ingd2)
                'updating all ingredients to available if their stock is not 0 anymore'
                For i As Integer = 0 To ingd.Rows.Count() - 1
                    updated2("update ingredients set ing_status='Available' where ing_id='" & ingd.Rows(i)(0) & "'")
                Next
                'updating all ingredients to unavailable if their stock less than 1'
                If ingd2.Rows.Count() > 0 Then
                    updated2("update ingredients set ing_status='Unavailable' where ing_stock<1")
                End If
                reload("Select *, ing_stock*ing_price as totalInv from ingredients", Productform.dtglist2)
                Me.Close()
                dashboard1.rescount = 1
                Dim confirmcrit As New DataTable
                gettable("select count(*) from ingredients where (ing_stock*ing_rate)<=20", confirmcrit)
                dashboard1.rescount = 1
                If confirmcrit.Rows(0)(0) > 0 Then
                    dashboard1.exscount = 1
                    dashboard1.critconfirm = confirmcrit.Rows(0)(0)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Addsupplier.Show()
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles weightN.KeyPress, istocktb.KeyPress, iratetb.KeyPress, ipricetb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class