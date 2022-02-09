Public Class newitem
    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub newitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.CenterToScreen()
            weightAbv.Text = "kg"
            unittb.Text = "Pack"
            idate.Format = DateTimePickerFormat.Custom
            idate.CustomFormat = "dd/MM/yyyy"
            idate2.Format = DateTimePickerFormat.Custom
            idate2.CustomFormat = "dd/MM/yyyy"
            reload("select * from supplier", suppliertb)
            suppliertb.DisplayMember = "supp_name"
            suppliertb.ValueMember = "supp_name"
            Dim oldid As String
            Dim newid As String
            Dim year As String = Date.Today.Year
            gett("select * from ingredients ORDER BY ing_id DESC LIMIT 1", iidtb)
            oldid = iidtb.Text.Remove(0, 8)
            newid = oldid + 1
            iidtb.Text = "ITEM" + year + newid
            Dim datee As DateTime
            datee = DateTime.Now()
            idate.Value = DateTime.Now()
            idate2.Value = datee.AddDays(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'create ingredient'
        Dim unit As String
        unit = unittb.Text + "/" + weightN.Text + " " + weightAbv.Text
        Dim pricet, ratet, stockt As Integer
        Dim inamet As New DataTable
        gettable("select * from ingredients where ing_name='" & inametb.Text & "'", inamet)
        If inametb.Text = "" Then
            MessageBox.Show("Please enter a ingredient name.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf idesctb.Text = "" Then
            MessageBox.Show("Please enter a ingredient description.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ipricetb.Text = "" Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(ipricetb.Text, pricet) Then
            MessageBox.Show("Please enter a valid price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf ipricetb.Text < 1 Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf unittb.Text = "" Then
            MessageBox.Show("Please enter a ingredient price.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf istocktb.Text = "" Then
            MessageBox.Show("Please enter a stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(istocktb.Text, stockt) Then
            MessageBox.Show("Please enter a valid stock value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf istocktb.Text < 1 Then
            MessageBox.Show("Please enter a stock value.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf iratetb.Text = "" Then
            MessageBox.Show("Please enter a consumption rate.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Not Integer.TryParse(iratetb.Text, ratet) Then
            MessageBox.Show("Please enter a valid consumption rate value!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf iratetb.Text < 1 Then
            MessageBox.Show("Please enter number of servings.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf weightN.Text = "" Then
            MessageBox.Show("Please enter weight number.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf idate2.Value <= idate.Value Then
            MessageBox.Show("Expiration date must be set later than Receiving date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'validation to prevent duplicate ingredient names'
        ElseIf inamet.Rows.Count() > 0 Then
            MessageBox.Show(inametb.Text + " already exists." & vbCrLf & "Please enter different ingredient name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim istock As Integer
                Integer.TryParse(istocktb.Text, istock)
                'checking if stock is less than 1 to switch status to unavailable'
                If istock < 1 Then
                    create("insert into ingredients(ing_id,ing_name,ing_desc,ing_price,ing_status,ing_unit,ing_stock,ing_rate,rec_date,ex_date,supplier) values('" & iidtb.Text & "','" & inametb.Text & "','" & idesctb.Text & "','" & ipricetb.Text & "','Unavailable','" & unit & "','" & istocktb.Text & "','" & iratetb.Text & "','" & idate.Value.ToString("yyyy/MM/dd") & "','" & idate2.Value.ToString("yyyy/MM/dd") & "','" & suppliertb.Text & "')")
                Else
                    create("insert into ingredients(ing_id,ing_name,ing_desc,ing_price,ing_status,ing_unit,ing_stock,ing_rate,rec_date,ex_date,supplier) values('" & iidtb.Text & "','" & inametb.Text & "','" & idesctb.Text & "','" & ipricetb.Text & "','Available','" & unit & "','" & istocktb.Text & "','" & iratetb.Text & "','" & idate.Value.ToString("yyyy/MM/dd") & "','" & idate2.Value.ToString("yyyy/MM/dd") & "','" & suppliertb.Text & "')")
                End If
                reload("Select *, ing_stock*ing_price as totalInv from ingredients", Productform.dtglist2)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Addsupplier.Show()
    End Sub

    Private Sub weightN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles weightN.KeyPress, ipricetb.KeyPress, istocktb.KeyPress, iratetb.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class