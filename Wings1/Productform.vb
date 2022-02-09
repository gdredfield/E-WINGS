Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.ComponentModel

Public Class Productform

    Public forview As New DataTable
    Public expireden As New List(Of String)

    Dim defingquery = "Select *, ing_stock*ing_price as totalInv from ingredients"
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        prodcb.Text = "Default"
        ingcb.Text = "Default"
        searchcb.Text = "Name"
        searchcb2.Text = "Name"
        Try
            gettable("select exid,it_id from expired where it_status='unchecked'", forview)
            If forview.Rows.Count > 0 Then
                For i As Integer = 0 To forview.Rows.Count - 1
                    Dim inidd As String = forview(i)(1).ToString
                    expireden.Add(inidd)
                Next
            End If
            'checking availability of ingredients'
            Dim checkingge As New DataTable
            gettable("select * from ingredients where ing_stock>0 and ex_date>'" & Date.Now.ToString("yyyy/MM/dd") & "' and ing_status='Unavailable'", checkingge)
            If checkingge.Rows.Count > 0 Then
                updated2("update ingredients set ing_status='Available' where ing_stock>0 and ex_date>'" & Date.Now.ToString("yyyy/MM/dd") & "' and ing_status='Unavailable'")
            End If
            Dim checkingg As New DataTable
            gettable("select * from ingredients where ing_stock<1 or ex_date<='" & Date.Now.ToString("yyyy/MM/dd") & "'", checkingg)
                If checkingg.Rows.Count > 0 Then
                updated2("update ingredients set ing_status='Unavailable' where ing_stock<1 OR ex_date<='" & Date.Now.ToString("yyyy/MM/dd") & "'")
            End If
            'load all table data'
            reload("Select * from product", dtglist)
            reload(defingquery, dtglist2)
            'search textboxes'
            reload("select * from product where concat(prod_id, prod_name, prodesc, prod_price, prod_stock) like '%" & searchbox.Text & "%'", dtglist)
            reload(defingquery + " where concat(ing_id, ing_name, ing_desc, ing_price, ing_stock) like '%" & isearch.Text & "%'", dtglist2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'delete product'
        If dtglist.SelectedCells.Count = 0 Or dtglist.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete product record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from product where prod_id='" & dtglist.CurrentRow.Cells(0).Value & "'")
                    reload("Select * from product", dtglist)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click_1(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dtglist.SelectedCells.Count = 0 Or dtglist.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            editproduct.Show()
        End If

    End Sub

    Private Sub searchbox_TextChanged(sender As Object, e As EventArgs) Handles searchbox.TextChanged
        'search by cb'
        Try
            If searchcb.Text = "ID" Then
                reload("select * from product where concat(prod_id) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Name" Then
                reload("select * from product where concat(prod_name) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Price" Then
                reload("select * from product where concat(prod_price) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Type" Then
                reload("select * from product where concat(prod_type) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Stocks" Then
                reload("select * from product where concat(prod_stock) like '%" & searchbox.Text & "%'", dtglist)
            ElseIf searchcb.Text = "Date" Then
                reload("select * from product where concat(prod_date) like '%" & searchbox.Text & "%'", dtglist)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnadd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        newitem.Show()
    End Sub


    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        'delete ingredient'
        If dtglist2.SelectedCells.Count = 0 Or dtglist2.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim ans As DialogResult
                ans = MessageBox.Show("Are you sure to delete ingredient record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If ans = DialogResult.Yes Then
                    delete("delete from ingredients where ing_id='" & dtglist2.CurrentRow.Cells(0).Value & "'")
                    reload(defingquery, dtglist2)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEdit2_Click(sender As Object, e As EventArgs) Handles btnEdit2.Click
        If dtglist2.SelectedCells.Count = 0 Or dtglist2.Rows.Count = 0 Then
            MessageBox.Show("No record selected!", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            edititem.Show()
        End If
    End Sub

    Private Sub prodcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles prodcb.SelectionChangeCommitted
        If prodcb.Text = "Name" Then
            reload("select * from product ORDER BY prod_name ASC", dtglist)
        ElseIf prodcb.Text = "Price" Then
            reload("select * from product ORDER BY prod_price ASC", dtglist)
        ElseIf prodcb.Text = "Date" Then
            reload("select * from product ORDER BY prod_date desc", dtglist)
        ElseIf prodcb.Text = "Stock" Then
            reload("select * from product ORDER BY prod_stock ASC", dtglist)
        ElseIf prodcb.Text = "Default" Then
            reload("select * from product", dtglist)
        End If
    End Sub

    Private Sub ingcb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ingcb.SelectionChangeCommitted
        If ingcb.Text = "Name" Then
            reload(defingquery + " ORDER BY ing_name ASC", dtglist2)
        ElseIf ingcb.Text = "Price" Then
            reload(defingquery + " ORDER BY ing_price ASC", dtglist2)
        ElseIf ingcb.Text = "Date" Then
            reload(defingquery + " ORDER BY rec_date desc", dtglist2)
        ElseIf ingcb.Text = "Stock" Then
            reload(defingquery + " ORDER BY ing_stock ASC", dtglist2)
        ElseIf ingcb.Text = "Default" Then
            reload(defingquery, dtglist2)
        End If
    End Sub

    Private Sub isearch_TextChanged(sender As Object, e As EventArgs) Handles isearch.TextChanged
        If searchcb2.Text = "ID" Then
            reload(defingquery + " where concat(ing_id) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Name" Then
            reload(defingquery + " where concat(ing_name) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Price" Then
            reload(defingquery + " where concat(ing_price) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Type" Then
            reload(defingquery + " where concat(ing_type) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Stocks" Then
            reload(defingquery + " where concat(ing_stock) like '%" & isearch.Text & "%'", dtglist2)
        ElseIf searchcb2.Text = "Date" Then
            reload(defingquery + " where concat(rec_date) like '%" & isearch.Text & "%'", dtglist2)
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        addproduct.Show()
    End Sub

    Private Sub dtglist2_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dtglist2.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim checker As New DataTable
            gettable("select * from subitem where in_id='" & dtglist2.CurrentRow.Cells(0).Value.ToString & "'", checker)
            If checker.Rows.Count > 0 Then
                Dim RC As Rectangle = Me.RectangleToScreen(Me.ClientRectangle)
                Dim bmp As New Bitmap(RC.Width, RC.Height)
                Using G As Graphics = Graphics.FromImage(bmp)
                    G.CopyFromScreen(RC.Location, New Point(0, 0), RC.Size)
                    Using brsh As New SolidBrush(Color.FromArgb(128, Color.Black))
                        G.FillRectangle(brsh, Me.ClientRectangle)
                    End Using
                End Using
                subexpdates.Show()
            Else
                MessageBox.Show("All stocks of this product are up to the latest date.", "Up to date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

    Private Sub dtglist2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dtglist2.CellFormatting
        Try

            Dim todd As Date = Date.Now.ToString("M/dd/yyyy")
            Dim sum1, sum2 As Integer

            'If e.ColumnIndex = 6 And e.Value IsNot Nothing Then
            '    Dim sum1 As Integer = Convert.ToInt32(e.Value)
            '    If (sum1 * sum2) >= 70 Then
            '        e.CellStyle.BackColor = ColorTranslator.FromHtml("#669900")
            '        e.CellStyle.ForeColor = Color.White
            '    ElseIf (sum1 * sum2) < 70 And (sum1 * sum2) > 30 Then
            '        e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900")
            '        e.CellStyle.ForeColor = Color.White
            '    ElseIf (sum1 * sum2) <= 30 Then
            '        e.CellStyle.BackColor = ColorTranslator.FromHtml("#990000")
            '        e.CellStyle.ForeColor = Color.White
            '    End If
            'Else
            'End If

            For j = 0 To dtglist2.Rows.Count - 1
                sum1 = dtglist2.Rows(j).Cells("Column13").Value
                sum2 = dtglist2.Rows(j).Cells("Column18").Value
                If (sum1 * sum2) >= 70 Then
                    If e.ColumnIndex = 6 And e.RowIndex = j Then
                        e.CellStyle.BackColor = ColorTranslator.FromHtml("#669900")
                        e.CellStyle.ForeColor = Color.White
                    End If
                ElseIf (sum1 * sum2) < 70 And (sum1 * sum2) > 30 Then
                    If e.ColumnIndex = 6 And e.RowIndex = j Then
                        e.CellStyle.BackColor = ColorTranslator.FromHtml("#FF9900")
                        e.CellStyle.ForeColor = Color.White
                    End If
                ElseIf (sum1 * sum2) <= 30 Then
                    If e.ColumnIndex = 6 And e.RowIndex = j Then
                        e.CellStyle.BackColor = ColorTranslator.FromHtml("#990000")
                        e.CellStyle.ForeColor = Color.White
                    End If
                End If

            Next

            Dim stats As String
            Dim expd As Date
            Dim idd As String


            For i = 0 To dtglist2.Rows.Count - 1
                stats = dtglist2.Rows(i).Cells(4).Value
                expd = dtglist2.Rows(i).Cells(9).Value
                idd = dtglist2.Rows(i).Cells(0).Value
                If expd <= todd Then
                    dtglist2.Rows(i).DefaultCellStyle.BackColor = Color.Brown
                    dtglist2.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    If e.ColumnIndex = 6 And e.RowIndex = i Then
                        e.CellStyle.ForeColor = Color.White
                        e.CellStyle.BackColor = Color.Brown
                    End If
                ElseIf stats = "Unavailable" Then
                    dtglist2.Rows(i).DefaultCellStyle.BackColor = Color.Brown
                    dtglist2.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    If e.ColumnIndex = 6 And e.RowIndex = i Then
                        e.CellStyle.ForeColor = Color.White
                        e.CellStyle.BackColor = Color.Brown
                    End If
                ElseIf expireden.Contains(idd) Then
                    dtglist2.Rows(i).DefaultCellStyle.BackColor = Color.Brown
                    dtglist2.Rows(i).DefaultCellStyle.ForeColor = Color.White
                    If e.ColumnIndex = 6 And e.RowIndex = i Then
                        e.CellStyle.ForeColor = Color.White
                        e.CellStyle.BackColor = Color.Brown
                    End If
                Else
                    dtglist2.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(52, 52, 52)
                    dtglist2.Rows(i).DefaultCellStyle.ForeColor = Color.Gainsboro
                End If
                'marking those who are set as -unchecked- yet in exp table'
                'If forview.Rows.Count() > 0 Then
                '    For j As Integer = 0 To forview.Rows.Count - 1
                '        If idd = forview.Rows(j)(1).ToString Then
                '            dtglist2.Rows(i).DefaultCellStyle.BackColor = Color.Brown
                '            dtglist2.Rows(i).DefaultCellStyle.ForeColor = Color.White
                '            If e.ColumnIndex = 6 And e.RowIndex = i Then
                '                e.CellStyle.ForeColor = Color.White
                '                e.CellStyle.BackColor = Color.Brown
                '            End If
                '        End If
                '    Next
                'End If
            Next

            'dtglist2.Columns(9).DefaultCellStyle.Format = "m/dd/yyyy"
            'For Each row As DataGridViewRow In dtglist2.Rows
            '    'Dim foundrow As DataRow() = forview.Select("it_id='" & row.Cells(0).Value.ToString & "'")
            '    If expireden.Contains(row.Cells(0).Value.ToString) Then
            '        row.DefaultCellStyle.BackColor = Color.Brown
            '        row.DefaultCellStyle.ForeColor = Color.White
            '    End If
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Expiredform.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles suppButton.Click
        Supplierform.Show()
    End Sub
End Class