Imports MySql.Data.MySqlClient

Public Class PaymentWindow

    Public sum As Double
    Public cash As Double
    Private Sub PaymentWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        confirmbut.Enabled = False
        For i As Integer = 0 To AddSale.prodq.Rows.Count() - 1
            sum += AddSale.prodq.Rows(i).Cells(3).Value
        Next
        receipt.AppendText(vbTab + vbTab + "Order Summary" + vbNewLine + vbNewLine)
        If AddSale.prodq.Rows.Count() <= 4 Then
            receipt.AppendText("------------------------------------------" + vbNewLine)
        Else
            receipt.AppendText("----------------------------------------" + vbNewLine)
        End If
        For i As Integer = 0 To AddSale.prodq.Rows.Count() - 1
            '& vbTab & AddSale.prodq.Rows(i).Cells(3).Value.ToString'
            receipt.AppendText("  " + AddSale.prodq.Rows(i).Cells(1).Value.ToString + " x " + AddSale.prodq.Rows(i).Cells(2).Value.ToString + " = ₱" + AddSale.prodq.Rows(i).Cells(3).Value.ToString + vbNewLine)
        Next
        If AddSale.prodq.Rows.Count() <= 4 Then
            receipt.AppendText("------------------------------------------" + vbNewLine + vbNewLine)
        Else
            receipt.AppendText("----------------------------------------" + vbNewLine + vbNewLine)
        End If
        receipt.AppendText(vbTab + " Total Bill: " + vbTab + vbTab + "₱" + sum.ToString("N2") + vbNewLine)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
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

        Dim count As Integer
        Dim change As Double
        count = receipt.Lines.Count - 4
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

            For ii As Integer = 0 To AddSale.prodq.Rows.Count() - 1
                create2("insert into sales(prodid,proname,squantity,stotal,sale_date,schange, customer_id) values('" & AddSale.prodq.Rows(ii).Cells(0).Value.ToString & "','" & AddSale.prodq.Rows(ii).Cells(1).Value.ToString & "','" & AddSale.prodq.Rows(ii).Cells(2).Value.ToString & "','" & AddSale.prodq.Rows(ii).Cells(3).Value.ToString & "','" & timestamp & "','" & Label2.Text & "', '" & AddSale.custommcb.Text & "')")
                updated2("update product set prod_stock=prod_stock-'" & AddSale.prodq.Rows(ii).Cells(2).Value.ToString & "' where prod_id='" & AddSale.prodq.Rows(ii).Cells(0).Value.ToString & "'")
                'selecting all ingredients for the selected product'
                Dim table1 As New DataTable()
                gettable("select * from prodsettings where proid='" & AddSale.prodq.Rows(ii).Cells(0).Value.ToString & "'", table1)
                'deducting ingredient stocks for the selected product by consume rate * quantity'
                For i As Integer = 0 To table1.Rows.Count() - 1
                    updated2("update ingredients set ing_stock=ing_stock-(ing_rate*'" & AddSale.prodq.Rows(ii).Cells(2).Value.ToString & "') where ing_id='" & table1.Rows(i)(2) & "'")
                Next
            Next

            'checking all products and ingredients that have 0 stocks'
            Dim prod As New DataTable()
            Dim ingd As New DataTable()
            gettable("select * from product where prod_stock<1", prod)
            gettable("select * from ingredients where ing_stock<1", ingd)
            'updating all products and ingredients that have 0 stocks to status unavailable'
            If prod.Rows.Count() > 0 Then
                updated2("update product set prod_status='Unavailable' where prod_stock<1")
            End If
            If ingd.Rows.Count() > 0 Then
                updated2("update ingredients set ing_status='Unavailable' where ing_stock<1")
            End If
            reload("Select * from product where prod_status='Available'", AddSale.dtglist4)
            reload("select sales.sale_code, sales.prodid, sales.proname, sales.squantity, sales.stotal, sales.sale_date, sales.schange, sales.customer_id, product.prod_price, product.prod_stock from sales INNER JOIN product on product.prod_id=sales.prodid", Salesform.dtglist3)
            Me.Hide()
            changewindow.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class