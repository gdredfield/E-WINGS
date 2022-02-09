Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing

Public Class Salesreport

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
        If LoginForm.UserTb.Text = "admin" Then
            Inventoryform2.Show()
        Else
            Inventoryform.Show()
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
        Timer1.Enabled = True
        sortcb.Text = "Month"
        dater.Format = DateTimePickerFormat.Custom
        dater.CustomFormat = "dd/MM/yyyy"
        'sort chart by products with existing sale record and most frequent value of quantity sale rate' 
        For i As Integer = 1 To 12
            If i = 1 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "January", 0, salech)
                Continue For
            ElseIf i = 2 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "February", 0, salech)
                Continue For
            ElseIf i = 3 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "March", 0, salech)
                Continue For
            ElseIf i = 4 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "April", 0, salech)
                Continue For
            ElseIf i = 5 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "May", 0, salech)
                Continue For
            ElseIf i = 6 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "June", 0, salech)
                Continue For
            ElseIf i = 7 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "July", 0, salech)
                Continue For
            ElseIf i = 8 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "August", 0, salech)
                Continue For
            ElseIf i = 9 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "September", 0, salech)
                Continue For
            ElseIf i = 10 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "October", 0, salech)
                Continue For
            ElseIf i = 11 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "November", 0, salech)
                Continue For
            ElseIf i = 12 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "December", 0, salech)
                Continue For
            End If
        Next
        Try
            If sortcb.Text = "Date" Then
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                reload("select sale_code, sale_date, stotal, schange from sales where sale_date='" & timestamp & "' order by sale_date", datag1)
                gett("select sum(stotal) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", stotaltb)
                gett("select count(*) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", sttotaltb)
                stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
                Label12.Text = sttotaltb.Text
                Label8.Text = stotaltb.Text
                'combobox for monthly sales value'
                ComboBox1.SelectedIndex = DateTime.Now.ToString("MM") - 1
                ComboBox1.Enabled = False
                dater.Enabled = True

            ElseIf sortcb.Text = "Month" Then
                ComboBox1.SelectedIndex = DateTime.Now.ToString("MM") - 1
                reload("select sale_code, sale_date, stotal, schange from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "' order by sale_date", datag1)
                gett("select sum(stotal) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotaltb)
                gett("select count(*) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotaltb)
                stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
                Label12.Text = sttotaltb.Text
                Label8.Text = stotaltb.Text
                ComboBox1.Enabled = True
                dater.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dater_ValueChanged(sender As Object, e As EventArgs) Handles dater.ValueChanged
        Try
            reload("select sale_code, sale_date, stotal, schange from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", datag1)
            gett("select sum(stotal) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", stotaltb)
            gett("select count(*) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", sttotaltb)
            stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
            Label12.Text = sttotaltb.Text
            Label8.Text = stotaltb.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        Try
            reload("select sale_code, sale_date, stotal, schange from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'  order by sale_date", datag1)
            gett("select sum(stotal) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotaltb)
            gett("select count(*) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotaltb)
            stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
            Label12.Text = sttotaltb.Text
            Label8.Text = stotaltb.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        Try
            If sortcb.Text = "Date" Then
                Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                reload("select sale_code, sale_date, stotal, schange from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "' order by sale_date", datag1)
                gett("select sum(stotal) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "' order by sale_date", stotaltb)
                gett("select count(*) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "' order by sale_date", sttotaltb)
                stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
                Label12.Text = sttotaltb.Text
                Label8.Text = stotaltb.Text
                ComboBox1.Enabled = False
                dater.Enabled = True

            ElseIf sortcb.Text = "Month" Then
                reload("select sale_code, sale_date, stotal, schange from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "' order by sale_date", datag1)
                gett("select sum(stotal) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotaltb)
                gett("select count(*) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotaltb)
                stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
                Label12.Text = sttotaltb.Text
                Label8.Text = stotaltb.Text
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
                    Dim timestamp As String = Date.Now.ToString("yyyy/MM/dd")
                    reload("select sale_code, sale_date, stotal, schange from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", datag1)
                    gett("select sum(stotal) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", stotaltb)
                    gett("select count(*) from sales where sale_date='" & dater.Value.ToString("yyyy/MM/dd") & "'", sttotaltb)
                    stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
                    Label12.Text = sttotaltb.Text
                    Label8.Text = stotaltb.Text

                ElseIf sortcb.Text = "Month" Then
                    reload("select sale_code, sale_date, stotal, schange from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", datag1)
                    gett("select sum(stotal) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", stotaltb)
                    gett("select count(*) from sales where month(sale_date)='" & ComboBox1.SelectedIndex() + 1 & "'", sttotaltb)
                    stotaltb.Text = Format(Val(stotaltb.Text), "0.00")
                    Label12.Text = sttotaltb.Text
                    Label8.Text = stotaltb.Text
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'quantity rate
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        getchart("select proname, max(squantity), count(*) from sales group by proname order by count(*) desc ", "quantityrate", 0, 1, salech)
        'add where month(sale_date) = '" & ComboBox1.SelectedIndex() + 1 & "'  (for monthly)'
    End Sub

    'most sales
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        getchart("select proname, sum(sales.squantity) from sales group by proname order by sum(squantity) desc", "mostsales", 0, 1, salech)
        'add where month(sale_date) = '" & ComboBox1.SelectedIndex() + 1 & "'  (for monthly)'
    End Sub

    'monthly sale
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        salech.Series(0).Points.Clear()
        salech.Series(1).Points.Clear()
        salech.Series(2).Points.Clear()
        For i As Integer = 1 To 12
            If i = 1 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "January", 0, salech)
                Continue For
            ElseIf i = 2 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "February", 0, salech)
                Continue For
            ElseIf i = 3 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "March", 0, salech)
                Continue For
            ElseIf i = 4 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "April", 0, salech)
                Continue For
            ElseIf i = 5 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "May", 0, salech)
                Continue For
            ElseIf i = 6 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "June", 0, salech)
                Continue For
            ElseIf i = 7 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "July", 0, salech)
                Continue For
            ElseIf i = 8 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "August", 0, salech)
                Continue For
            ElseIf i = 9 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "September", 0, salech)
                Continue For
            ElseIf i = 10 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "October", 0, salech)
                Continue For
            ElseIf i = 11 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "November", 0, salech)
                Continue For
            ElseIf i = 12 Then
                getchartm("select sum(stotal) from sales where month(sale_date)='" & i & "'", "monthly", "December", 0, salech)
                Continue For
            End If
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        salerep0.Text = ""
        salerep.Text = ""
        salerep2.Text = ""
        Try
            If sortcb.Text = "Date" Then
                Dim today = dater.Value.ToLongDateString
                salerep0.AppendText(vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
                salerep.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
                salerep.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
                salerep.AppendText("Sale Report Summary" + vbTab + vbTab + vbTab + vbTab + "       " + today + vbNewLine)
                salerep2.AppendText("--------------------------------------------------------------------------------------------------------" + vbNewLine)
            ElseIf sortcb.Text = "Month" Then
                Dim year = Date.Today.Year.ToString
                Dim toda = ComboBox1.Text
                salerep0.AppendText(vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
                salerep.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
                salerep.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
                salerep.AppendText("Sale Report Summary" + vbTab + vbTab + vbTab + vbTab + vbTab + "       " + toda + ", " + year + vbNewLine)
                salerep2.AppendText("---------------------------------------------------------------------------------------------------------" + vbNewLine)
            End If
            salerep2.AppendText("Transaction ID" + vbTab + vbTab + "Date" + vbTab + vbTab + "      Total Amount" + vbTab + vbTab + "Change" + vbNewLine)

            For i As Integer = 0 To datag1.Rows.Count() - 1
                Dim temp As Date
                temp = CType(datag1.Rows(i).Cells(1).Value, DateTime).ToShortDateString()
                salerep2.AppendText("        " + datag1.Rows(i).Cells(0).Value.ToString + vbTab + vbTab + "              " + temp + "   " + vbTab + vbTab + datag1.Rows(i).Cells(2).Value.ToString + vbTab + vbTab + "  " + datag1.Rows(i).Cells(3).Value.ToString + vbNewLine)
            Next

            salerep2.AppendText("---------------------------------------------------------------------------------------------------------" + vbNewLine)
            salerep2.AppendText(vbNewLine + "Total Transactions: " + sttotaltb.Text + vbNewLine + vbNewLine)
            salerep2.AppendText("Total Sales: " + stotaltb.Text + vbNewLine)



            Dim printdoc As New PrintDocument
            AddHandler printdoc.PrintPage, AddressOf Me.PrintText
            PrintPreviewDialog1.ShowDialog()
            'printdoc.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ev.Graphics.DrawString(salerep0.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 100)
            ev.Graphics.DrawString(salerep.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            ev.Graphics.DrawString(salerep2.Text, New Font("Times New Roman", 13, FontStyle.Regular), Brushes.Black, 100, 270)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(salerep0.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 100)
            e.Graphics.DrawString(salerep.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            e.Graphics.DrawString(salerep2.Text, New Font("Times New Roman", 13, FontStyle.Regular), Brushes.Black, 100, 270)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class