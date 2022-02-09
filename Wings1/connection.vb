Imports MySql.Data.MySqlClient
Public Class connection
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=wings;Convert Zero Datetime=True")

    ReadOnly Property getconn() As MySqlConnection
        Get
            Return conn
        End Get
    End Property

    Sub openconn()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub closeconn()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class
