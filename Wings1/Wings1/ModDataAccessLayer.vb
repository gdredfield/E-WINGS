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
    Public Sub delete(ByVal sql As String)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                result = comms.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("No record selected!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Delete successful!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

    'get value'
    Public Sub gett(ByVal sql As String, ByVal datas As Object)
        Try
            coni.Open()
            With comms
                .Connection = coni
                .CommandText = sql

                datas.text = comms.ExecuteScalar()
            End With
        Catch ex As Exception
            MessageBox.Show("No record available!")
        Finally
            coni.Close()
        End Try
    End Sub

    Public Sub gettable(ByVal sql As String, ByVal dtg As DataTable)
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
                chart.series(serie).points.addxy(dt.Rows(i)(x), dt.Rows(i)(y))
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
            chart.series(serie).points.addxy(x, dt.Rows(0)(y))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            coni.Close()
        End Try
    End Sub

End Module
