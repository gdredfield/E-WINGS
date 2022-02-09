Imports System.Drawing.Printing

Public Class changewindow

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub changewindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        changelbl.Text = PaymentWindow.Label2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddSale.idtb.Text = "No product selected"
        AddSale.nametb.Text = "-"
        AddSale.pricetb.Text = "-"
        AddSale.stocktb.Text = "-"
        AddSale.quantitytb.Text = ""
        AddSale.statuscb.Text = "-"
        AddSale.typecb.Text = "-"
        AddSale.totaltb.Text = ""
        AddSale.custommcb.Text = "10"
        AddSale.table.Clear()
        Dim custt As New DataTable()
        gettable("select fname,lname from customer where custom_id='" & AddSale.custommcb.Text & "'", custt)
        AddSale.custname.Text = custt.Rows(0)(0).ToString() + " " + custt.Rows(0)(1).ToString()
        Me.Close()
        PaymentWindow.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            e.Graphics.DrawString(rtb1.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 100)
            e.Graphics.DrawString(rtb2.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            e.Graphics.DrawString(rtb3.Text, New Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, 100, 270)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Try
            ev.Graphics.DrawString(rtb1.Text, New Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, 100)
            ev.Graphics.DrawString(rtb2.Text, New Font("Calibri", 13, FontStyle.Bold), Brushes.Black, 100, 180)
            ev.Graphics.DrawString(rtb3.Text, New Font("Times New Roman", 15, FontStyle.Regular), Brushes.Black, 100, 270)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rtb1.Text = ""
        rtb2.Text = ""
        rtb3.Text = ""
        Try
            rtb1.Text = ""
            Dim today = Date.Now.ToLongDateString
            rtb1.AppendText(vbTab + vbTab + "  Wings By 8:25" + vbNewLine)
            rtb2.AppendText(vbTab + vbTab + "Savor flavorful wings at the comfort of your home" + vbNewLine)
            rtb2.AppendText(vbTab + vbTab + vbTab + "Made to order | Imus, Cavite" + vbNewLine + vbNewLine)
            rtb2.AppendText("Order Summary" + vbTab + vbTab + vbTab + vbTab + vbTab + today + vbNewLine)
            rtb3.AppendText("------------------------------------------------------------------------------------------" + vbNewLine)

            For i As Integer = 0 To AddSale.prodq.Rows.Count() - 1
                rtb3.AppendText("Product Name:   " + vbTab + vbTab + vbTab + vbTab + vbTab + AddSale.prodq.Rows(i).Cells(1).Value.ToString + vbNewLine + "Order Quantity:  " + vbTab + vbTab + vbTab + vbTab + vbTab + AddSale.prodq.Rows(i).Cells(2).Value.ToString + " (pcs) " + vbNewLine + "Amount:  " + vbTab + vbTab + vbTab + vbTab + vbTab + AddSale.prodq.Rows(i).Cells(3).Value.ToString + vbNewLine + vbNewLine)
            Next
            rtb3.AppendText("------------------------------------------------------------------------------------------" + vbNewLine)
            rtb3.AppendText("Total Bill: " + vbTab + vbTab + vbTab + vbTab + vbTab + PaymentWindow.sum.ToString("N2") + vbNewLine)
            rtb3.AppendText("Amount Paid: " + vbTab + vbTab + vbTab + vbTab + vbTab + PaymentWindow.cash.ToString("N2") + vbNewLine)
            rtb3.AppendText("Total Change: " + vbTab + vbTab + vbTab + vbTab + vbTab + changelbl.Text + vbNewLine)
            Dim printdoc As New PrintDocument
            AddHandler printdoc.PrintPage, AddressOf Me.PrintText
            PrintPreviewDialog1.ShowDialog()
            'printdoc.Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class