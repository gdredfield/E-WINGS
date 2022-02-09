Public Class Inventoryform

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Dim p1 As Color
    Dim p2 As Color
    Dim p3 As Color
    Private Sub Inventoryform2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Panel2.BackColor = Color.FromArgb(170, 0, 0, 0)
            Panel4.BackColor = Color.FromArgb(170, 0, 0, 0)
            Panel10.BackColor = Color.FromArgb(170, 0, 0, 0)
            Panel11.BackColor = Color.FromArgb(180, 0, 0, 0)
            Panel12.BackColor = Color.FromArgb(180, 48, 58, 82)
            Panel13.BackColor = Color.FromArgb(180, 48, 58, 82)
            gett("select fname from users where user='" & LoginForm.UserTb.Text & "'", Label4)
            gett("select count(*) from product where prod_stock<=10", Label23)
            gett("select count(*) from ingredients where ing_stock<=10", Label24)
            Label21.Text = "- (" + Label23.Text + ") Products"
            Label22.Text = "- (" + Label24.Text + ") Ingredients"
            p1 = Panel3.BackColor
            p2 = Panel7.BackColor
            p3 = Panel8.BackColor
            Me.CenterToScreen()
            Timer1.Enabled = True
            gett("select count(*) from product where prod_status='Available'", Label14)
            gett("select count(*) from sales where month(sale_date)='" & DateTime.Now.ToString("MM") & "'", Label13)
            gett("select sum(stotal) from sales where month(sale_date)='" & DateTime.Now.ToString("MM") & "'", Label27)
            Label27.Text = Format(Val(Label27.Text), "0.00")
            Label20.Text = "₱" + Label27.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim ans As DialogResult
        ans = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ans = DialogResult.Yes Then
            Me.Close()
            LoginForm.UserTb.Text = "username"
            LoginForm.PasswordTb.Text = "password"
            LoginForm.ActiveControl = Nothing
            LoginForm.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim ans As DialogResult
        ans = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ans = DialogResult.Yes Then
            Me.Close()
            LoginForm.UserTb.Text = "username"
            LoginForm.PasswordTb.Text = "password"
            LoginForm.ActiveControl = Nothing
            LoginForm.Show()
        End If
    End Sub

    Private Sub order_Click(sender As Object, e As EventArgs) Handles order.Click
        Me.Hide()
        CustomerForm.Show()
    End Sub

    Private Sub sales_Click(sender As Object, e As EventArgs) Handles sales.Click
        Me.Hide()
        Salesform.Show()
    End Sub

    Private Sub product_Click(sender As Object, e As EventArgs) Handles product.Click
        Me.Hide()
        Productform.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Date.Now.ToString("yyyy/MM/dd hh:mm tt")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        editaccount.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim ans As DialogResult
        ans = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ans = DialogResult.Yes Then
            Me.Close()
            LoginForm.UserTb.Text = "username"
            LoginForm.PasswordTb.Text = "password"
            LoginForm.ActiveControl = Nothing
            LoginForm.Show()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Addingredient.Show()
    End Sub

    Private Sub Panel3_MouseHover(sender As Object, e As EventArgs) Handles Panel3.MouseHover
        Panel3.BackColor = Color.White
        Label14.ForeColor = p1
        Label15.ForeColor = p1
    End Sub

    Private Sub Panel7_MouseHover(sender As Object, e As EventArgs) Handles Panel7.MouseHover
        Panel7.BackColor = Color.White
        Label13.ForeColor = p2
        Label16.ForeColor = p2
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        Panel3.BackColor = p1
        Label14.ForeColor = Color.White
        Label15.ForeColor = Color.White
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave
        Panel7.BackColor = p2
        Label13.ForeColor = Color.White
        Label16.ForeColor = Color.White
    End Sub

    Private Sub Panel8_MouseHover(sender As Object, e As EventArgs) Handles Panel8.MouseHover
        Panel8.BackColor = Color.White
        Label20.ForeColor = p3
        Label19.ForeColor = p3
    End Sub

    Private Sub Panel8_MouseLeave(sender As Object, e As EventArgs) Handles Panel8.MouseLeave
        Panel8.BackColor = p3
        Label20.ForeColor = Color.White
        Label19.ForeColor = Color.White
    End Sub

    Private Sub Label14_MouseHover(sender As Object, e As EventArgs) Handles Label14.MouseHover
        Panel3.BackColor = Color.White
        Label14.ForeColor = p1
        Label15.ForeColor = p1
    End Sub

    Private Sub Label14_MouseLeave(sender As Object, e As EventArgs) Handles Label14.MouseLeave
        Panel3.BackColor = p1
        Label14.ForeColor = Color.White
        Label15.ForeColor = Color.White
    End Sub

    Private Sub Label15_MouseHover(sender As Object, e As EventArgs) Handles Label15.MouseHover
        Panel3.BackColor = Color.White
        Label14.ForeColor = p1
        Label15.ForeColor = p1
    End Sub

    Private Sub Label15_MouseLeave(sender As Object, e As EventArgs) Handles Label15.MouseLeave
        Panel3.BackColor = p1
        Label14.ForeColor = Color.White
        Label15.ForeColor = Color.White
    End Sub

    Private Sub Label13_MouseHover(sender As Object, e As EventArgs) Handles Label13.MouseHover
        Panel7.BackColor = Color.White
        Label13.ForeColor = p2
        Label16.ForeColor = p2
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles Label13.MouseLeave
        Panel7.BackColor = p2
        Label13.ForeColor = Color.White
        Label16.ForeColor = Color.White
    End Sub

    Private Sub Label16_MouseHover(sender As Object, e As EventArgs) Handles Label16.MouseHover
        Panel7.BackColor = Color.White
        Label13.ForeColor = p2
        Label16.ForeColor = p2
    End Sub

    Private Sub Label16_MouseLeave(sender As Object, e As EventArgs) Handles Label16.MouseLeave
        Panel7.BackColor = p2
        Label13.ForeColor = Color.White
        Label16.ForeColor = Color.White
    End Sub

    Private Sub Label20_MouseHover(sender As Object, e As EventArgs) Handles Label20.MouseHover
        Panel8.BackColor = Color.White
        Label20.ForeColor = p3
        Label19.ForeColor = p3
    End Sub

    Private Sub Label20_MouseLeave(sender As Object, e As EventArgs) Handles Label20.MouseLeave
        Panel8.BackColor = p3
        Label20.ForeColor = Color.White
        Label19.ForeColor = Color.White
    End Sub

    Private Sub Label19_MouseHover(sender As Object, e As EventArgs) Handles Label19.MouseHover
        Panel8.BackColor = Color.White
        Label20.ForeColor = p3
        Label19.ForeColor = p3
    End Sub

    Private Sub Label19_MouseLeave(sender As Object, e As EventArgs) Handles Label19.MouseLeave
        Panel8.BackColor = p3
        Label20.ForeColor = Color.White
        Label19.ForeColor = Color.White
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        AddSale.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        AddSale.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Addingredient.Show()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        Lowstockproduct.Show()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Lowstock.Show()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        Me.Hide()
        Salesreport.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Salesreport.Show()
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        Productreport.Show()
    End Sub
End Class