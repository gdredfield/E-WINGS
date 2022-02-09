
Public Class Addsupplier

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Addsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
    Function IsValidEmailFormat(ByVal s As String) As Boolean
        Try
            Dim a As New System.Net.Mail.MailAddress(s)
        Catch
            Return False
        End Try
        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim checc As New DataTable
            Dim email, address, contact As String
            Dim checkemail As Boolean = IsValidEmailFormat(emailtb.Text)
            gettable("select * from supplier where supp_name='" & cattb.Text & "'", checc)
            If checc.Rows.Count() > 0 Then
                MessageBox.Show("This supplier already exists!", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf cattb.Text = "" Then
                MessageBox.Show("Please enter supplier name!", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf contpertb.Text = "" Then
                MessageBox.Show("Please enter a contact person!", "No Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf valPhoneNumber(contacttb.Text) = False Then
                MessageBox.Show("Please enter a valid contact number!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Not emailtb.Text = "" And checkemail = False Then
                MessageBox.Show("Please enter a valid email!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If emailtb.Text = "" Then
                    email = "N/A"
                Else
                    email = emailtb.Text
                End If
                If addresstb.Text = "" Then
                    address = "N/A"
                Else
                    address = addresstb.Text
                End If
                If contacttb.Text = "" Then
                    contact = "N/A"
                Else
                    contact = contacttb.Text
                End If
                create("INSERT into supplier(supp_name,contactNum,Address,contactPerson,emailAdd) values ('" & cattb.Text & "','" & contacttb.Text & "','" & address & "','" & contpertb.Text & "','" & email & "')")
                reload("select * from supplier", newitem.suppliertb)
                newitem.suppliertb.DisplayMember = "supp_name"
                newitem.suppliertb.ValueMember = "supp_name"
                reload("select * from supplier", AddOrder.supplier)
                AddOrder.supplier.DisplayMember = "supp_name"
                AddOrder.supplier.ValueMember = "supp_name"
                reload("select * from supplier", EditOrder.supplier)
                EditOrder.supplier.DisplayMember = "supp_name"
                EditOrder.supplier.ValueMember = "supp_name"
                reload("select * from supplier", edititem.suppliertb)
                edititem.suppliertb.DisplayMember = "supp_name"
                edititem.suppliertb.ValueMember = "supp_name"
                reload("select * from supplier where supp_name<>'N/A'", Supplierform.dtgsupp)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class