Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient

Module ModDataAccessLayer
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost; username=root; password=; database=wings")
    End Function
    Public coni As MySqlConnection = strconnection()

    Public result As String
    Public comms As New MySqlCommand
    Public adap As New MySqlDataAdapter
    Public dt As New DataTable
    Public da As New DataSet

    'create/insert'
    Public Sub create(ByVal sql As String)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
                result = comms.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save the data!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Data has been saved successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub create2(ByVal sql As String)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
                result = comms.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Failed to save the data!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub
    'retrieving database data'
    Public Sub reload(ByVal sql As String, ByVal dtg As Object)
        Try
            dt = New DataTable
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
            End With
            adap.SelectCommand = comms
            adap.Fill(dt)
            dtg.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
            adap.Dispose()
        End Try
    End Sub
    'update data'
    Public Sub updated(ByVal sql As String)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                result = comms.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Update Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Update successful!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub updated2(ByVal sql As String)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                result = comms.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Update Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub
    'delete data'
    Public Sub delete(ByVal sql As String, Optional hasMsg As Boolean = True)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                result = comms.ExecuteNonQuery

                If hasMsg Then
                    If result = 0 Then
                        MessageBox.Show("No record selected!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Delete successful!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub delete2(ByVal sql As String, Optional hasMsg As Boolean = True)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                result = comms.ExecuteNonQuery

                If hasMsg Then
                    If result = 0 Then
                        MessageBox.Show("No record selected!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    'get value'
    Public Sub gett(ByVal sql As String, ByVal datas As Object, Optional hasMsg As Boolean = True)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                result = comms.ExecuteScalar()
                If hasMsg Then
                    If Not IsDBNull(result) Then
                        datas.text = comms.ExecuteScalar()
                    End If
                End If

            End With
        Catch ex As Exception
            MessageBox.Show("No record available!")
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub gett2(ByVal sql As String, ByVal datas As Object)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                datas.text = comms.ExecuteScalar()
            End With
        Catch ex As Exception
            MessageBox.Show("No sale records yet for this month! Let's get to business!")
        Finally
            coni.Close()
        End Try
    End Sub


    Public Sub gettable(ByVal sql As String, ByVal dtg As DataTable)
        coni.Close()
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
            End With
            adap.SelectCommand = comms
            adap.Fill(dtg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
            adap.Dispose()
        End Try
    End Sub

    Public Sub getset(ByVal sql As String, ByVal dtg As DataSet)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
            End With
            adap.SelectCommand = comms
            adap.Fill(dtg)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
            adap.Dispose()
        End Try
    End Sub

    Public Sub getchart(ByVal sql As String, ByVal serie As String, ByVal x As Integer, ByVal y As Integer, ByVal chart As Object)
        Try
            dt = New DataTable
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
            End With
            adap.SelectCommand = comms
            adap.Fill(dt)
            For i As Integer = 0 To dt.Rows.Count() - 1
                If Not DBNull.Value.Equals(dt.Rows(i)(y)) Then
                    chart.series(serie).points.addxy(dt.Rows(i)(x), dt.Rows(i)(y))
                Else
                    chart.series(serie).points.addxy(dt.Rows(i)(x), 0)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub getchart2(ByVal sql As String, ByVal serie As String, ByVal serie2 As String, ByVal x As Integer, ByVal y As Integer, ByVal y2 As Integer, ByVal chart As Object)
        Try
            dt = New DataTable
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
            End With
            adap.SelectCommand = comms
            adap.Fill(dt)
            For i As Integer = 0 To dt.Rows.Count() - 1
                If Not DBNull.Value.Equals(dt.Rows(i)(y)) Then
                    chart.series(serie).points.addxy(dt.Rows(i)(x), dt.Rows(i)(y))
                Else
                    chart.series(serie).points.addxy(dt.Rows(i)(x), 0)
                End If
                If Not DBNull.Value.Equals(dt.Rows(i)(y2)) Then
                    chart.series(serie2).points.addxy(dt.Rows(i)(x), dt.Rows(i)(y2))
                Else
                    chart.series(serie2).points.addxy(dt.Rows(i)(x), 0)
                End If

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub getchartm(ByVal sql As String, ByVal serie As String, ByVal x As String, ByVal y As Integer, ByVal chart As Object)
        Try
            dt = New DataTable
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql
            End With
            adap.SelectCommand = comms
            adap.Fill(dt)
            If Not DBNull.Value.Equals(dt.Rows(0)(0)) Then
                chart.series(serie).points.addxy(x, dt.Rows(0)(y))
            Else
                chart.series(serie).points.addxy(x, 0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub roundPanel(pnl As Panel)
        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'left top
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, pnl.Width - 20, 0)
        'right top
        radius.AddArc(New Rectangle(pnl.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(pnl.Width, 20, pnl.Width, pnl.Height - 10)
        'right bottom
        radius.AddArc(New Rectangle(pnl.Width - 25, pnl.Height - 25, 25, 25), 0, 90)
        'left bottom
        radius.AddLine(pnl.Width - 10, pnl.Width, 20, pnl.Height)

        radius.AddArc(New Rectangle(0, pnl.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()

        pnl.Region = New Region(radius)

    End Sub

    Public Sub roundBtn(pnl As Button)
        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'left top
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, pnl.Width - 20, 0)
        'right top
        radius.AddArc(New Rectangle(pnl.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(pnl.Width, 20, pnl.Width, pnl.Height - 10)
        'right bottom
        radius.AddArc(New Rectangle(pnl.Width - 25, pnl.Height - 25, 25, 25), 0, 90)
        'left bottom
        radius.AddLine(pnl.Width - 10, pnl.Width, 20, pnl.Height)

        radius.AddArc(New Rectangle(0, pnl.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()

        pnl.Region = New Region(radius)

    End Sub

    Public Sub roundForm(pnl As Form)
        Dim radius As New Drawing2D.GraphicsPath
        radius.StartFigure()

        'left top
        radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        radius.AddLine(10, 0, pnl.Width - 20, 0)
        'right top
        radius.AddArc(New Rectangle(pnl.Width - 20, 0, 20, 20), -90, 90)
        radius.AddLine(pnl.Width, 20, pnl.Width, pnl.Height - 10)
        'right bottom
        radius.AddArc(New Rectangle(pnl.Width - 25, pnl.Height - 25, 25, 25), 0, 90)
        'left bottom
        radius.AddLine(pnl.Width - 10, pnl.Width, 20, pnl.Height)

        radius.AddArc(New Rectangle(0, pnl.Height - 20, 20, 20), 90, 90)
        radius.CloseFigure()

        pnl.Region = New Region(radius)

    End Sub

    Function valPhoneNumber(ByVal phoneNumber As String) As Boolean
        Return phoneNumber(0) = "0" And phoneNumber(1) = "9" And phoneNumber.Length = 11 And Regex.IsMatch(phoneNumber, "^[0-9 ]+$")

    End Function

End Module
