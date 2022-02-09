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
        Label2.Text = "Item: " + Lowstock.lowdt.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim stock As Integer
        Dim user, info As New DataTable
        gettable("select fname,lname from users where user='" & LoginForm.UserTb.Text & "'", user)
        gettable("select * from ingredients where ing_id='" & Lowstock.lowdt.CurrentRow.Cells(0).Value.ToString & "'", info)
        Dim emp As String = user.Rows(0)(0).ToString() + " " + user.Rows(0)(1).ToString()

        Dim id As New TextBox
        Dim itmid As String = info.Rows(0)(0).ToString()
        Dim name As String = info.Rows(0)(1).ToString()
        Dim desc As String = info.Rows(0)(2).ToString()
        Dim price As String = info.Rows(0)(3).ToString()
        Dim status As String = info.Rows(0)(4).ToString()
        Dim unit As String = info.Rows(0)(5).ToString()
        Dim stocks As String = info.Rows(0)(6).ToString()
        Dim rate As String = info.Rows(0)(7).ToString()
        Dim supplier As String = info.Rows(0)(10).ToString()

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

        If stocktb.Text = "" Then
            MessageBox.Show("Please enter quantity!", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(stocktb.Text, stock) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf stocktb.Text <= 0 Then
            MessageBox.Show("Please enter higher quantity!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure you want to add stock to inventory?", "Restock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    Dim dates As New DataTable
                    gettable("select * from ingredients where ing_id='" & Lowstock.lowdt.CurrentRow.Cells(0).Value.ToString & "'", dates)
                    Dim date1 As Date = dates.Rows(0)(8)
                    Dim date2 As Date = dates.Rows(0)(9)
                    Dim days As Integer = (date2.Date - date1.Date).Days
                    Dim idate1 As Date = Date.Now
                    Dim idate2 As Date = Date.Now.AddDays(days)

                    Dim existingsub As New DataTable
                    Dim existingdates As New DataTable
                    gettable("select sum(in_stock) from subitem where in_id='" & Lowstock.lowdt.CurrentRow.Cells(0).Value.ToString & "'", existingsub)
                    gettable("select in_rec,in_ex,sub_id from subitem where in_id='" & Lowstock.lowdt.CurrentRow.Cells(0).Value.ToString & "' ORDER BY sub_id DESC LIMIT 1", existingdates)

                    'checking if item already exists in subitem table'
                    If stocks > 0 Then
                        If idate1.Date = date1.Date And idate2.Date = date2.Date Then

                        ElseIf existingdates.Rows.Count > 0 Then
                            'getting dates from existing subitems and currently adding item for comparison'
                            Dim exist1 As Date = existingdates.Rows(0)(0)
                            Dim exist2 As Date = existingdates.Rows(0)(1)
                            'calculating new stock value to not miscalculate with previous records'
                            Dim currstock As Double
                            Double.TryParse(existingsub.Rows(0)(0), currstock)
                            Dim allstock As Double
                            Double.TryParse(stocks, allstock)
                            Dim newstock As Double = allstock - currstock
                            'if exact date already exists, stock numbers will merge in subitem table'
                            If exist1.Date = date1.Date And exist2.Date = date2.Date Then
                                updated2("update subitem set in_stock=in_stock+'" & newstock.ToString & "' where sub_id='" & existingdates.Rows(0)(2).ToString & "'")
                            Else
                                create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & itmid & "','" & name & "','" & newstock.ToString & "','" & date1.ToString("yyyy/MM/dd") & "','" & date2.ToString("yyyy/MM/dd") & "')")
                            End If
                        Else
                            create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & itmid & "','" & name & "','" & stocks & "','" & date1.ToString("yyyy/MM/dd") & "','" & date2.ToString("yyyy/MM/dd") & "')")
                        End If
                    End If
                    updated("update ingredients set ing_stock= ing_stock+'" & stocktb.Text & "',rec_date='" & idate1.ToString("yyyy/MM/dd") & "',ex_date='" & idate2.ToString("yyyy/MM/dd") & "' where ing_id='" & Lowstock.lowdt.CurrentRow.Cells(0).Value.ToString & "'")
                    'updated2("update ingredients set ing_status='Available' where ing_stock>0 and ex_date<='" & idate1.ToString("yyyy/MM/dd") & "'")
                    create2("insert into orderhistory(ord_id,ord_name,ord_desc,ord_price,ord_status,ord_unit,ord_stock,ord_rate,ord_recdate,ord_exdate,supplier,empuser) values('" & id.Text & "','" & name & "','" & desc & "','" & price & "','COMPLETED','" & unit & "','" & stock & "','" & rate & "','" & idate1.ToString("yyyy/MM/dd") & "','" & idate2.ToString("yyyy/MM/dd") & "','" & supplier & "','" & emp & "')")
                    reload("select ing_id,ing_name,ing_rate,ing_stock from ingredients order by ing_stock asc", Lowstock.lowdt)
                    Me.Close()
                End If
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