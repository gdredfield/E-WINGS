Imports System
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Printing


Public Class BadOrder

    Dim Pos As Point
    Dim defaultQuery As String =
        "select b.or_id, o.ord_name, b.qty, o.ord_price, (o.ord_price * b.qty) total_price, o.ord_recdate, o.ord_exdate
        from badorders b
        inner join orderhistory o on o.ord_id = b.or_id"

    Public Sub RefreshTable()
        Try
            reload(defaultQuery, badordersdt)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub BadOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        searchbycb.Text = "Name"
        reload(defaultQuery, badordersdt)
        ' + " where year(o.ord_recdate)='" & Date.Now.Year & "' and month(o.ord_recdate)='" & Date.Now.Month & "'"
        sortcb.Text = "Month"
        dater.Format = DateTimePickerFormat.Custom
        dater.CustomFormat = "yyyy/MM/dd"
        ComboBox1.SelectedIndex = DateTime.Now.Month - 1
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles search.TextChanged
        Try
            If searchbycb.Text = "Order ID" Then
                reload(defaultQuery & " where concat(o.ord_id) like '%" & search.Text & "%'", badordersdt)
            ElseIf searchbycb.Text = "Name" Then
                reload(defaultQuery & " where concat(o.ord_name) like '%" & search.Text & "%'", badordersdt)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If badordersdt.SelectedCells.Count = 0 Or badordersdt.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from badorders where or_id='" & badordersdt.CurrentRow.Cells(0).Value & "'")
                    RefreshTable()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If badordersdt.SelectedCells.Count = 0 Or badordersdt.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            BadOrderQty.Show()
        End If

    End Sub

    Private Sub IconPictureBox3_Click(sender As Object, e As EventArgs) Handles IconPictureBox3.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If badordersdt.Rows.Count() < 1 Then
            MessageBox.Show("No record to print!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            rtb1.Text = ""
            rtb2.Text = ""
            rtb3.Text = ""
            If sortcb.Text = "Date" Then
                Dim today = dater.Value.ToLongDateString
                rtb1.AppendText(vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
                rtb2.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
                rtb2.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
                rtb2.AppendText("Bad Orders Slip" + vbTab + vbTab + vbTab + vbTab + "            " + today + vbNewLine)
                rtb3.AppendText("----------------------------------------------------------------------------------------------------------" + vbNewLine)
                rtb3.AppendText("Order ID" + vbTab + vbTab + vbTab + "Item" + vbTab + vbTab + vbTab + vbTab + "  Total Value" + vbNewLine + vbNewLine)
                For i As Integer = 0 To badordersdt.Rows.Count() - 1
                    'Dim temp As Date
                    'temp = CType(badordersdt.Rows(i).Cells(1).Value, DateTime).ToShortDateString()
                    rtb3.AppendText(badordersdt.Rows(i).Cells(0).Value.ToString + vbTab + vbTab + badordersdt.Rows(i).Cells(1).Value.ToString + " " + badordersdt.Rows(i).Cells(2).Value.ToString + "(pcs) " + vbTab + vbTab + badordersdt.Rows(i).Cells(4).Value.ToString + " (" + badordersdt.Rows(i).Cells(3).Value.ToString + " each)" + vbNewLine)
                Next
            ElseIf sortcb.Text = "Month" Then
                Dim year = Date.Today.Year.ToString
                Dim toda = ComboBox1.Text
                rtb1.AppendText(vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
                rtb2.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
                rtb2.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
                rtb2.AppendText("Bad Orders Slip" + vbTab + vbTab + vbTab + vbTab + vbTab + "                   " + toda + ", " + year + vbNewLine)
                rtb3.AppendText("---------------------------------------------------------------------------------------------------------" + vbNewLine)
                rtb3.AppendText("Order ID" + vbTab + vbTab + "Item" + vbTab + vbTab + vbTab + "Total Value" + vbTab + "    Order Date" + vbNewLine + vbNewLine)
                For i As Integer = 0 To badordersdt.Rows.Count() - 1
                    Dim temp As Date
                    temp = CType(badordersdt.Rows(i).Cells(5).Value, DateTime).ToShortDateString()
                    rtb3.AppendText(badordersdt.Rows(i).Cells(0).Value.ToString + vbTab + badordersdt.Rows(i).Cells(1).Value.ToString + " " + badordersdt.Rows(i).Cells(2).Value.ToString + "(pcs)" + vbTab + badordersdt.Rows(i).Cells(4).Value.ToString + " (" + badordersdt.Rows(i).Cells(3).Value.ToString + " each)" + vbTab + "    " + temp + vbNewLine)
                Next
            End If

            If sortcb.Text = "Date" Then
                rtb3.AppendText("--------------------------------------------------------------------------------------------------------------" + vbNewLine)
            ElseIf sortcb.Text = "Month" Then
                rtb3.AppendText("---------------------------------------------------------------------------------------------------------" + vbNewLine)
            End If
            rtb3.AppendText(vbTab + vbTab + vbTab + logo.Text + vbNewLine)
            Dim printdoc As New PrintDocument
            AddHandler printdoc.PrintPage, AddressOf Me.PrintText
            PrintPreviewDialog1.ShowDialog()
            'printdoc.Print()
        End If
    End Sub
    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ev.Graphics.DrawString(rtb1.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 130)
            ev.Graphics.DrawString(rtb2.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            ev.Graphics.DrawString(rtb3.Text, New Font("Times New Roman", 13, FontStyle.Regular), Brushes.Black, 100, 270)
            ev.Graphics.DrawImage(Me.logo.Image, 380, 35, logo.Width - 15, logo.Height - 25)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(rtb1.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 130)
            e.Graphics.DrawString(rtb2.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            e.Graphics.DrawString(rtb3.Text, New Font("Times New Roman", 13, FontStyle.Regular), Brushes.Black, 100, 270)
            e.Graphics.DrawImage(Me.logo.Image, 380, 35, logo.Width - 15, logo.Height - 25)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dater_ValueChanged(sender As Object, e As EventArgs) Handles dater.ValueChanged
        reload(defaultQuery + " where o.ord_recdate='" & dater.Value.ToString("yyyy/MM/dd") & "'", badordersdt)
    End Sub

    Private Sub sortcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles sortcb.SelectionChangeCommitted
        If sortcb.Text = "Date" Then
            ComboBox1.Enabled = False
            dater.Enabled = True
            reload(defaultQuery + " where o.ord_recdate='" & dater.Value.ToString("yyyy/MM/dd") & "'", badordersdt)
        ElseIf sortcb.Text = "Month" Then
            ComboBox1.Enabled = True
            dater.Enabled = False
            ComboBox1.SelectedIndex = DateTime.Now.Month - 1
            reload(defaultQuery + " where year(o.ord_recdate)='" & Date.Now.Year & "' and month(o.ord_recdate)='" & Date.Now.Month & "'", badordersdt)
        End If
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        reload(defaultQuery + " where year(o.ord_recdate)='" & Date.Now.Year & "' and month(o.ord_recdate)='" & ComboBox1.SelectedIndex() + 1 & "'", badordersdt)
    End Sub
End Class