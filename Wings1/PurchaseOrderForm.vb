Public Class PurchaseOrderForm

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub PurchaseOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        sortcb.Text = "Default"
        searchcb.Text = "Name"

        Try
            reload("Select * from ordertbl", dtgporder)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddOrder.Show()
    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        Try
            If searchcb.Text = "ID" Then
                reload("select * from ordertbl where concat(or_id) like '%" & searchbox.Text & "%'", dtgporder)
            ElseIf searchcb.Text = "Name" Then
                reload("select * from ordertbl where concat(or_name) like '%" & searchbox.Text & "%'", dtgporder)
            ElseIf searchcb.Text = "Price" Then
                reload("select * from ordertbl where concat(or_price) like '%" & searchbox.Text & "%'", dtgporder)
            ElseIf searchcb.Text = "Stocks" Then
                reload("select * from ordertbl where concat(or_stock) like '%" & searchbox.Text & "%'", dtgporder)
            ElseIf searchcb.Text = "RecDate" Then
                reload("select * from ordertbl where concat(or_recdate) like '%" & searchbox.Text & "%'", dtgporder)
            ElseIf searchcb.Text = "ExDate" Then
                reload("select * from ordertbl where concat(or_exdate) like '%" & searchbox.Text & "%'", dtgporder)
            ElseIf searchcb.Text = "Supplier" Then
                reload("select * from ordertbl where concat(supplier) like '%" & searchbox.Text & "%'", dtgporder)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        If sortcb.Text = "Name" Then
            reload("select * from ordertbl ORDER BY or_name ASC", dtgporder)
        ElseIf sortcb.Text = "Price" Then
            reload("select * from ordertbl ORDER BY or_price ASC", dtgporder)
        ElseIf sortcb.Text = "Stock" Then
            reload("select * from ordertbl ORDER BY or_stock ASC", dtgporder)
        ElseIf sortcb.Text = "RecDate" Then
            reload("select * from ordertbl ORDER BY or_recdate desc", dtgporder)
        ElseIf sortcb.Text = "ExDate" Then
            reload("select * from ordertbl ORDER BY or_exdate desc", dtgporder)
        ElseIf sortcb.Text = "Supplier" Then
            reload("select * from ordertbl ORDER BY supplier ASC", dtgporder)
        ElseIf sortcb.Text = "Default" Then
            reload("select * from ordertbl", dtgporder)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dtgporder.SelectedCells.Count() = 0 Or dtgporder.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If dtgporder.CurrentRow.Cells(4).Value = "RESTOCK" Then
                editrestockorder.Show()
            Else
                EditOrder.Show()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'delete order'
        If dtgporder.SelectedCells.Count() = 0 Or dtgporder.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete order record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from ordertbl where or_id='" & dtgporder.CurrentRow.Cells(0).Value & "'")
                    reload("Select * from ordertbl", dtgporder)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAddtoInv_Click(sender As Object, e As EventArgs) Handles btnAddtoInv.Click
        If dtgporder.SelectedCells.Count() = 0 Or dtgporder.Rows.Count() = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim ans, ans2 As DialogResult
            ans = MessageBox.Show("Do you want to add this order to inventory?", "Add to Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                Try
                    Dim user As New DataTable
                    gettable("select fname,lname from users where user='" & LoginForm.UserTb.Text & "'", user)
                    Dim emp As String = user.Rows(0)(0).ToString() + " " + user.Rows(0)(1).ToString()

                    Dim id As String = dtgporder.CurrentRow.Cells(0).Value
                    Dim name As String = dtgporder.CurrentRow.Cells(1).Value
                    Dim desc As String = dtgporder.CurrentRow.Cells(2).Value
                    Dim price As String = dtgporder.CurrentRow.Cells(3).Value
                    Dim status As String = dtgporder.CurrentRow.Cells(4).Value
                    Dim unit As String = dtgporder.CurrentRow.Cells(5).Value
                    Dim stock As String = dtgporder.CurrentRow.Cells(6).Value
                    Dim rate As String = dtgporder.CurrentRow.Cells(7).Value


                    Dim dt1 As DateTime = Convert.ToDateTime(dtgporder.CurrentRow.Cells(8).Value)
                    Dim recdate As String = dt1.ToString("yyyy/MM/dd")

                    Dim dt2 As DateTime = Convert.ToDateTime(dtgporder.CurrentRow.Cells(9).Value)
                    Dim exdate As String = dt2.ToString("yyyy/MM/dd")

                    Dim supplier As String = dtgporder.CurrentRow.Cells(10).Value

                    Dim namet As New DataTable
                    Dim ingfo As New DataTable
                    Dim d1, d2 As DateTime
                    Dim recd1 As String = ""
                    Dim exd1 As String = ""
                    gettable("select ing_id,ing_name,ing_stock,rec_date,ex_date from ingredients where ing_name='" & name & "'", ingfo)
                    If ingfo.Rows.Count > 0 Then
                        d1 = Convert.ToDateTime(ingfo.Rows(0)(3).ToString)
                        recd1 = d1.ToString("yyyy/MM/dd")
                        d2 = Convert.ToDateTime(ingfo.Rows(0)(4).ToString)
                        exd1 = d2.ToString("yyyy/MM/dd")
                    End If
                    gettable("select * from ingredients where ing_name='" & name & "'", namet)
                    If namet.Rows.Count() > 0 Then
                        If status = "RESTOCK" Then
                            Dim id2 As New TextBox
                            Dim id3 As New TextBox
                            Dim oldid As String
                            Dim oldid2 As String
                            Dim newid As String
                            Dim newid2 As String
                            Dim year As String = Date.Today.Year
                            gett("select ing_id from ingredients ORDER BY ing_id DESC LIMIT 1", id2)
                            gett("select ord_id from orderhistory ORDER BY ord_id DESC LIMIT 1", id3)
                            If id2.Text = "" Then
                                If id3.Text = "" Then
                                    id2.Text = "ITEM" & year & 1
                                    id3.Text = "ORDH" & year & 1
                                Else
                                    id2.Text = "ITEM" & year & 1
                                    oldid = id3.Text.Remove(0, 8)
                                    newid = oldid + 1
                                    id3.Text = "ORDH" + year + newid
                                End If

                            ElseIf id3.Text = "" Then
                                id3.Text = "ORDH" & year & 1
                                oldid = id2.Text.Remove(0, 8)
                                newid = oldid + 1
                                id2.Text = "ITEM" + year + newid
                            Else
                                oldid = id2.Text.Remove(0, 8)
                                newid = oldid + 1
                                id2.Text = "ITEM" + year + newid

                                oldid2 = id3.Text.Remove(0, 8)
                                newid2 = oldid2 + 1
                                id3.Text = "ORDH" + year + newid2
                            End If
                            Try
                                Dim existingsub As New DataTable
                                Dim existingdates As New DataTable
                                gettable("select sum(in_stock) from subitem where in_id='" & ingfo.Rows(0)(0).ToString & "'", existingsub)
                                gettable("select in_rec,in_ex,sub_id from subitem where in_id='" & ingfo.Rows(0)(0).ToString & "' ORDER BY sub_id DESC LIMIT 1", existingdates)

                                'checking if item already exists in subitem table'
                                If ingfo.Rows(0)(2) > 0 Then
                                    If existingdates.Rows.Count > 0 Then
                                        'getting dates from existing subitems and currently adding item for comparison'
                                        Dim exist1 As Date = existingdates.Rows(0)(0)
                                        Dim exist2 As Date = existingdates.Rows(0)(1)
                                        Dim dd1 As Date = dtgporder.CurrentRow.Cells(8).Value
                                        Dim dd2 As Date = dtgporder.CurrentRow.Cells(9).Value
                                        'calculating new stock value to not miscalculate with previous records'
                                        Dim currstock As Double
                                        Double.TryParse(existingsub.Rows(0)(0), currstock)
                                        Dim allstock As Double
                                        Double.TryParse(ingfo.Rows(0)(2), allstock)
                                        Dim newstock As Double = allstock - currstock
                                        'if exact date already exists, stock numbers will merge in subitem table'
                                        If exist1.Date = d1.Date And exist2.Date = d2.Date Then
                                            updated("update subitem set in_stock=in_stock+'" & newstock.ToString & "' where sub_id='" & existingdates.Rows(0)(2).ToString & "'")
                                        Else
                                            create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & ingfo.Rows(0)(0).ToString & "','" & ingfo.Rows(0)(1).ToString & "','" & newstock.ToString & "','" & recd1 & "','" & exd1 & "')")
                                        End If
                                    Else
                                        create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & ingfo.Rows(0)(0).ToString & "','" & ingfo.Rows(0)(1).ToString & "','" & ingfo.Rows(0)(2).ToString & "','" & recd1 & "','" & exd1 & "')")
                                    End If
                                End If
                                updated2("update ingredients set ing_stock=ing_stock+'" & stock & "',ing_status='Available',rec_date='" & recdate & "',ex_date='" & exdate & "',supplier='" & supplier & "' where ing_name='" & name & "'")
                                create2("insert into orderhistory(ord_id,ord_name,ord_desc,ord_price,ord_status,ord_unit,ord_stock,ord_rate,ord_recdate,ord_exdate,supplier,empuser) values('" & id3.Text & "','" & name & "','" & desc & "','" & price & "','COMPLETED','" & unit & "','" & stock & "','" & rate & "','" & recdate & "','" & exdate & "','" & supplier & "','" & emp & "')")
                                delete("delete from ordertbl where or_id='" & id & "'", False)
                                MessageBox.Show("Item has been moved to inventory!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                reload("Select * from ordertbl", dtgporder)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                        Else
                            ans2 = MessageBox.Show("Do you want to update existing " + name + " in the inventory?", "Add to Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If ans2 = DialogResult.Yes Then
                                Dim id2 As New TextBox
                                Dim id3 As New TextBox
                                Dim oldid As String
                                Dim oldid2 As String
                                Dim newid As String
                                Dim newid2 As String
                                Dim year As String = Date.Today.Year
                                gett("select ing_id from ingredients ORDER BY ing_id DESC LIMIT 1", id2)
                                gett("select ord_id from orderhistory ORDER BY ord_id DESC LIMIT 1", id3)
                                If id2.Text = "" Then
                                    If id3.Text = "" Then
                                        id2.Text = "ITEM" & year & 1
                                        id3.Text = "ORDH" & year & 1
                                    Else
                                        id2.Text = "ITEM" & year & 1
                                        oldid = id3.Text.Remove(0, 8)
                                        newid = oldid + 1
                                        id3.Text = "ORDH" + year + newid
                                    End If

                                ElseIf id3.Text = "" Then
                                    id3.Text = "ORDH" & year & 1
                                    oldid = id2.Text.Remove(0, 8)
                                    newid = oldid + 1
                                    id2.Text = "ITEM" + year + newid
                                Else
                                    oldid = id2.Text.Remove(0, 8)
                                    newid = oldid + 1
                                    id2.Text = "ITEM" + year + newid

                                    oldid2 = id3.Text.Remove(0, 8)
                                    newid2 = oldid2 + 1
                                    id3.Text = "ORDH" + year + newid2
                                End If

                                Dim existingsub As New DataTable
                                Dim existingdates As New DataTable
                                gettable("select sum(in_stock) from subitem where in_id='" & ingfo.Rows(0)(0).ToString & "'", existingsub)
                                gettable("select in_rec,in_ex,sub_id from subitem where in_id='" & ingfo.Rows(0)(0).ToString & "' ORDER BY sub_id DESC LIMIT 1", existingdates)

                                'checking if item already exists in subitem table'
                                If ingfo.Rows(0)(2) > 0 Then
                                    If existingdates.Rows.Count > 0 Then
                                        'getting dates from existing subitems and currently adding item for comparison'
                                        Dim exist1 As Date = existingdates.Rows(0)(0)
                                        Dim exist2 As Date = existingdates.Rows(0)(1)
                                        Dim dd1 As Date = dtgporder.CurrentRow.Cells(8).Value
                                        Dim dd2 As Date = dtgporder.CurrentRow.Cells(9).Value
                                        'calculating new stock value to not miscalculate with previous records'
                                        Dim currstock As Double
                                        Double.TryParse(existingsub.Rows(0)(0), currstock)
                                        Dim allstock As Double
                                        Double.TryParse(ingfo.Rows(0)(2), allstock)
                                        Dim newstock As Double = allstock - currstock
                                        'if exact date already exists, stock numbers will merge in subitem table'
                                        If exist1.Date = d1.Date And exist2.Date = d2.Date Then
                                            updated("update subitem set in_stock=in_stock+'" & newstock.ToString & "' where sub_id='" & existingdates.Rows(0)(2).ToString & "'")
                                        Else
                                            create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & ingfo.Rows(0)(0).ToString & "','" & ingfo.Rows(0)(1).ToString & "','" & newstock.ToString & "','" & recd1 & "','" & exd1 & "')")
                                        End If
                                    Else
                                        create2("insert into subitem(in_id,in_name,in_stock,in_rec,in_ex) values('" & ingfo.Rows(0)(0).ToString & "','" & ingfo.Rows(0)(1).ToString & "','" & ingfo.Rows(0)(2).ToString & "','" & recd1 & "','" & exd1 & "')")
                                    End If
                                End If
                                updated2("update ingredients set ing_desc='" & desc & "', ing_status='Available', ing_price='" & price & "', ing_unit='" & unit & "', ing_stock= ing_stock+'" & stock & "', rec_date ='" & recdate & "', ex_date='" & exdate & "',supplier='" & supplier & "' where ing_name='" & name & "'")
                                create2("insert into orderhistory(ord_id,ord_name,ord_desc,ord_price,ord_status,ord_unit,ord_stock,ord_rate,ord_recdate,ord_exdate,supplier,empuser) values('" & id3.Text & "','" & name & "','" & desc & "','" & price & "','COMPLETED','" & unit & "','" & stock & "','" & rate & "','" & recdate & "','" & exdate & "','" & supplier & "','" & emp & "')")
                                delete("delete from ordertbl where or_id='" & id & "'", False)
                                MessageBox.Show("Item has been moved to inventory!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                reload("Select * from ordertbl", dtgporder)
                            Else
                                MessageBox.Show(name + " already exists in inventory." & vbCrLf & "Please change the item name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                    Else
                        Dim id2 As New TextBox
                        Dim id3 As New TextBox
                        Dim oldid As String
                        Dim oldid2 As String
                        Dim newid As String
                        Dim newid2 As String
                        Dim year As String = Date.Today.Year
                        gett("select * from ingredients ORDER BY ing_id DESC LIMIT 1", id2)
                        gett("select * from orderhistory ORDER BY ord_id DESC LIMIT 1", id3)
                        If id2.Text = "" Then
                            If id3.Text = "" Then
                                id2.Text = "ITEM" & year & 1
                                id3.Text = "ORDH" & year & 1
                            Else
                                id2.Text = "ITEM" & year & 1
                                oldid = id3.Text.Remove(0, 8)
                                newid = oldid + 1
                                id3.Text = "ORDH" + year + newid
                            End If

                        ElseIf id3.Text = "" Then
                            id3.Text = "ORDH" & year & 1
                            oldid = id2.Text.Remove(0, 8)
                            newid = oldid + 1
                            id2.Text = "ITEM" + year + newid
                        Else
                            oldid = id2.Text.Remove(0, 8)
                            newid = oldid + 1
                            id2.Text = "ITEM" + year + newid

                            oldid2 = id3.Text.Remove(0, 8)
                            newid2 = oldid2 + 1
                            id3.Text = "ORDH" + year + newid2
                        End If
                        create2("insert into ingredients(ing_id,ing_name,ing_desc,ing_price,ing_status,ing_unit,ing_stock,ing_rate,rec_date,ex_date,supplier) values('" & id2.Text & "','" & name & "','" & desc & "','" & price & "','Available','" & unit & "','" & stock & "','" & rate & "','" & recdate & "','" & exdate & "','" & supplier & "')")
                        create2("insert into orderhistory(ord_id,ord_name,ord_desc,ord_price,ord_status,ord_unit,ord_stock,ord_rate,ord_recdate,ord_exdate,supplier,empuser) values('" & id3.Text & "','" & name & "','" & desc & "','" & price & "','COMPLETED','" & unit & "','" & stock & "','" & rate & "','" & recdate & "','" & exdate & "','" & supplier & "','" & emp & "')")
                        delete("delete from ordertbl where or_id='" & id & "'", False)
                        MessageBox.Show("Item has been moved to inventory!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        reload("Select * from ordertbl", dtgporder)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        orderhistory.Show()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btnRestock.Click
        restockform.Show()
    End Sub
End Class