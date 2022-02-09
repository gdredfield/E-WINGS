Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing
Imports FontAwesome.Sharp

Public Class Salesreport

    Private currentBtn As IconButton
    Private Sub ActivateButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(0, 254, 202)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
        End If
    End Sub
    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(64, 64, 64)
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
        End If
    End Sub

    Dim Pos As Point
    Private Sub Panel2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub Salesreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ActivateButton(btnMonthlySale, Color.Black)
        Timer1.Enabled = True
        sortcb.Text = "Month"
        dater.Format = DateTimePickerFormat.Custom
        dater.CustomFormat = "yyyy/MM/dd"
        'sort chart by products with existing sale record and most frequent value of quantity sale rate' 
        For i As Integer = 1 To 12
            If i = 1 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Jan", 0, salech)
                Continue For
            ElseIf i = 2 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Feb", 0, salech)
                Continue For
            ElseIf i = 3 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Mar", 0, salech)
                Continue For
            ElseIf i = 4 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Apr", 0, salech)
                Continue For
            ElseIf i = 5 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "May", 0, salech)
                Continue For
            ElseIf i = 6 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Jun", 0, salech)
                Continue For
            ElseIf i = 7 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Jul", 0, salech)
                Continue For
            ElseIf i = 8 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Aug", 0, salech)
                Continue For
            ElseIf i = 9 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Sep", 0, salech)
                Continue For
            ElseIf i = 10 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Oct", 0, salech)
                Continue For
            ElseIf i = 11 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Nov", 0, salech)
                Continue For
            ElseIf i = 12 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Dec", 0, salech)
                Continue For
            End If
        Next
        Try
            ComboBox1.SelectedIndex = DateTime.Now.Month - 1
            reload("select sale_code, sale_date, stotal from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "' order by sale_date", datag1)
            Dim stotalb, sttotalb As New DataTable
            gettable("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotalb) 'stotaltb
            gettable("select count(*) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotalb) 'sttotaltb
            If Not DBNull.Value.Equals(stotalb.Rows(0)(0)) Then
                Label8.Text = Format(Val(stotalb.Rows(0)(0)), "0.00")
            Else
                Label8.Text = "0.00"
            End If

            If Not DBNull.Value.Equals(sttotalb.Rows(0)(0)) Then
                Label12.Text = sttotalb.Rows(0)(0)
            Else
                Label12.Text = "0"
            End If
            ComboBox1.Enabled = True
            dater.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dater_ValueChanged(sender As Object, e As EventArgs) Handles dater.ValueChanged
        Try
            reload("select sale_code, sale_date, stotal from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", datag1)
            Dim stotalb, sttotalb As New DataTable
            gettable("select sum(stotal) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", stotalb)
            gettable("select count(*) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", sttotalb)
            If Not DBNull.Value.Equals(stotalb.Rows(0)(0)) Then
                Label8.Text = Format(Val(stotalb.Rows(0)(0)), "0.00")
            Else
                Label8.Text = "0.00"
            End If

            If Not DBNull.Value.Equals(sttotalb.Rows(0)(0)) Then
                Label12.Text = sttotalb.Rows(0)(0)
            Else
                Label12.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Try
            reload("select sale_code, sale_date, stotal from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'  order by sale_date", datag1)
            Dim stotalb, sttotalb As New DataTable
            gettable("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotalb)
            gettable("select count(*) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotalb)
            If Not DBNull.Value.Equals(stotalb.Rows(0)(0)) Then
                Label8.Text = Format(Val(stotalb.Rows(0)(0)), "0.00")
            Else
                Label8.Text = "0.00"
            End If

            If Not DBNull.Value.Equals(sttotalb.Rows(0)(0)) Then
                Label12.Text = sttotalb.Rows(0)(0)
            Else
                Label12.Text = "0"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        Try
            If sortcb.Text = "Date" Then
                Dim stotalb, sttotalb As New DataTable
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                reload("select sale_code, sale_date, stotal from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "' order by sale_date", datag1)
                gettable("select sum(stotal) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "' order by sale_date", stotalb)
                gettable("select count(*) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "' order by sale_date", sttotalb)
                If Not DBNull.Value.Equals(stotalb.Rows(0)(0)) Then
                    Label8.Text = Format(Val(stotalb.Rows(0)(0)), "0.00")
                Else
                    Label8.Text = "0.00"
                End If

                If Not DBNull.Value.Equals(sttotalb.Rows(0)(0)) Then
                    Label12.Text = sttotalb.Rows(0)(0)
                Else
                    Label12.Text = "0"
                End If
                ComboBox1.Enabled = False
                dater.Enabled = True

            ElseIf sortcb.Text = "Month" Then
                Dim stotalb, sttotalb As New DataTable
                reload("select sale_code, sale_date, stotal from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "' order by sale_date", datag1)
                gettable("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotalb)
                gettable("select count(*) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotalb)
                If Not DBNull.Value.Equals(stotalb.Rows(0)(0)) Then
                    Label8.Text = Format(Val(stotalb.Rows(0)(0)), "0.00")
                Else
                    Label8.Text = "0.00"
                End If

                If Not DBNull.Value.Equals(sttotalb.Rows(0)(0)) Then
                    Label12.Text = sttotalb.Rows(0)(0)
                Else
                    Label12.Text = "0"
                End If
                ComboBox1.Enabled = True
                dater.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Try
            'delete'
            Dim ans As DialogResult
            ans = MessageBox.Show("Are you sure to delete sale record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If ans = DialogResult.Yes Then
                delete("delete from sales where sale_code='" & datag1.CurrentRow.Cells(0).Value.ToString & "'")
                If sortcb.Text = "Date" Then
                    Dim stotalb, sttotalb As New DataTable
                    Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                    reload("select sale_code, sale_date, stotal from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", datag1)
                    gettable("select sum(stotal) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", stotalb)
                    gettable("select count(*) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", sttotalb)
                    If Not DBNull.Value.Equals(stotalb.Rows(0)(0)) Then
                        Label8.Text = Format(Val(stotalb.Rows(0)(0)), "0.00")
                    Else
                        Label8.Text = "0.00"
                    End If

                    If Not DBNull.Value.Equals(sttotalb.Rows(0)(0)) Then
                        Label12.Text = sttotalb.Rows(0)(0)
                    Else
                        Label12.Text = "0"
                    End If

                ElseIf sortcb.Text = "Month" Then
                    Dim stotalb, sttotalb As New DataTable
                    reload("select sale_code, sale_date, stotal from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", datag1)
                    gettable("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotalb)
                    gettable("select count(*) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotalb)
                    If Not DBNull.Value.Equals(stotalb.Rows(0)(0)) Then
                        Label8.Text = Format(Val(stotalb.Rows(0)(0)), "0.00")
                    Else
                        Label8.Text = "0.00"
                    End If

                    If Not DBNull.Value.Equals(sttotalb.Rows(0)(0)) Then
                        Label12.Text = sttotalb.Rows(0)(0)
                    Else
                        Label12.Text = "0"
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'quantity rate
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles btnQR.Click
        ActivateButton(sender, Color.Black)
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        salech.Series(3).Points.Clear()
        getchart("select proname, max(squantity), count(*) from sales group by proname order by count(*) desc", "quantityrate", 0, 1, salech)
        'add where month(sale_date) = '" & ComboBox1.SelectedIndex() + 1 & "'  (for monthly)'
    End Sub

    'most sales
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles btnMostSale.Click
        ActivateButton(sender, Color.Black)
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        salech.Series(3).Points.Clear()
        getchart("select proname, sum(sales.squantity) from sales where year(sales.sale_date) = '" & Date.Now.Year & "' group by proname order by sum(squantity) desc", "mostsales", 0, 1, salech)
        'add where month(sale_date) = '" & ComboBox1.SelectedIndex() + 1 & "'  (for monthly)'
    End Sub

    'monthly sale
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles btnMonthlySale.Click
        ActivateButton(sender, Color.Black)
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        salech.Series(3).Points.Clear()
        For i As Integer = 1 To 12
            If i = 1 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Jan", 0, salech)
                Continue For
            ElseIf i = 2 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Feb", 0, salech)
                Continue For
            ElseIf i = 3 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Mar", 0, salech)
                Continue For
            ElseIf i = 4 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Apr", 0, salech)
                Continue For
            ElseIf i = 5 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "May", 0, salech)
                Continue For
            ElseIf i = 6 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Jun", 0, salech)
                Continue For
            ElseIf i = 7 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Jul", 0, salech)
                Continue For
            ElseIf i = 8 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Aug", 0, salech)
                Continue For
            ElseIf i = 9 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Sep", 0, salech)
                Continue For
            ElseIf i = 10 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Oct", 0, salech)
                Continue For
            ElseIf i = 11 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Nov", 0, salech)
                Continue For
            ElseIf i = 12 Then
                getchartm("select sum(stotal) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthly", "Dec", 0, salech)
                Continue For
            End If
        Next
    End Sub

    Private Sub btnMonthlyQ_Click(sender As Object, e As EventArgs) Handles btnMonthlyQ.Click
        ActivateButton(sender, Color.Black)
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        salech.Series(3).Points.Clear()
        For i As Integer = 1 To 12
            If i = 1 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Jan", 0, salech)
                Continue For
            ElseIf i = 2 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Feb", 0, salech)
                Continue For
            ElseIf i = 3 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Mar", 0, salech)
                Continue For
            ElseIf i = 4 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Apr", 0, salech)
                Continue For
            ElseIf i = 5 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "May", 0, salech)
                Continue For
            ElseIf i = 6 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Jun", 0, salech)
                Continue For
            ElseIf i = 7 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Jul", 0, salech)
                Continue For
            ElseIf i = 8 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Aug", 0, salech)
                Continue For
            ElseIf i = 9 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Sep", 0, salech)
                Continue For
            ElseIf i = 10 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Oct", 0, salech)
                Continue For
            ElseIf i = 11 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Nov", 0, salech)
                Continue For
            ElseIf i = 12 Then
                getchartm("select sum(squantity) from sales where year(sale_date) = '" & Date.Now.Year & "' and month(sale_date)='" & i & "'", "monthqty", "Dec", 0, salech)
                Continue For
            End If
        Next
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        salerep0.Text = ""
        salerep.Text = ""
        salerep2.Text = ""
        If datag1.Rows.Count < 1 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                If sortcb.Text = "Date" Then
                    Dim today = dater.Value.ToLongDateString
                    salerep0.AppendText(vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
                    salerep.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
                    salerep.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
                    salerep.AppendText("Sale Report Summary" + vbTab + vbTab + vbTab + vbTab + "       " + today + vbNewLine)
                    salerep2.AppendText("--------------------------------------------------------------------------------------------------------------" + vbNewLine)
                ElseIf sortcb.Text = "Month" Then
                    Dim year = Date.Today.Year.ToString
                    Dim toda = ComboBox1.Text
                    salerep0.AppendText(vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
                    salerep.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
                    salerep.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
                    salerep.AppendText("Sale Report Summary" + vbTab + vbTab + vbTab + vbTab + vbTab + "       " + toda + ", " + year + vbNewLine)
                    salerep2.AppendText("---------------------------------------------------------------------------------------------------------" + vbNewLine)
                End If
                salerep2.AppendText(vbTab + "Transaction ID" + vbTab + vbTab + "Date" + vbTab + vbTab + "      Total Amount" + vbNewLine)

                If datag1.Rows.Count() > 30 Then
                    For i As Integer = 0 To 30 'datag1.Rows.Count() - 1
                        Dim temp As Date
                        temp = CType(datag1.Rows(i).Cells(1).Value, DateTime).ToShortDateString()
                        salerep2.AppendText(vbTab + "      " + datag1.Rows(i).Cells(0).Value.ToString + vbTab + vbTab + "              " + temp + "   " + vbTab + vbTab + datag1.Rows(i).Cells(2).Value.ToString + vbNewLine)
                    Next
                Else
                    For i As Integer = 0 To datag1.Rows.Count() - 1
                        Dim temp As Date
                        temp = CType(datag1.Rows(i).Cells(1).Value, DateTime).ToShortDateString()
                        salerep2.AppendText(vbTab + "      " + datag1.Rows(i).Cells(0).Value.ToString + vbTab + vbTab + "              " + temp + "   " + vbTab + vbTab + datag1.Rows(i).Cells(2).Value.ToString + vbNewLine)
                    Next
                End If

                If sortcb.Text = "Date" Then
                    salerep2.AppendText("--------------------------------------------------------------------------------------------------------------" + vbNewLine)
                ElseIf sortcb.Text = "Month" Then
                    salerep2.AppendText("---------------------------------------------------------------------------------------------------------" + vbNewLine)
                End If
                salerep2.AppendText(vbNewLine + "Total Transactions: " + Label12.Text + vbNewLine + vbNewLine)
                salerep2.AppendText("Total Sales: " + Label8.Text + vbNewLine)
                salerep2.AppendText(vbTab + vbTab + vbTab + PictureBox1.Text + vbNewLine)

                Dim printdoc As New PrintDocument
                AddHandler printdoc.PrintPage, AddressOf Me.PrintText
                PrintPreviewDialog1.ShowDialog()
                'printdoc.Print()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ev.Graphics.DrawString(salerep0.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 130)
            ev.Graphics.DrawString(salerep.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            ev.Graphics.DrawString(salerep2.Text, New Font("Times New Roman", 13, FontStyle.Regular), Brushes.Black, 100, 270)
            ev.Graphics.DrawImage(Me.PictureBox1.Image, 380, 35, PictureBox1.Width - 15, PictureBox1.Height - 25)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(salerep0.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 130)
            e.Graphics.DrawString(salerep.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            e.Graphics.DrawString(salerep2.Text, New Font("Times New Roman", 13, FontStyle.Regular), Brushes.Black, 100, 270)
            e.Graphics.DrawImage(Me.PictureBox1.Image, 380, 35, PictureBox1.Width - 15, PictureBox1.Height - 25)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class