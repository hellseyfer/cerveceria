Imports System.Data.SqlClient

Public MustInherit Class ConnectionToSql
    Private connectionString As String

    Protected Sub New()
        'connectionString = "Server=JOSE-PC; DataBase=obstetriciaDB; integrated security = true"
        connectionString = "Server=DESKTOP-ANE968Q\SQLEXPRESS; DataBase=Cerveceria; integrated security = true"
    End Sub

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function

    Protected Function OpenConnection() As SqlConnection
        If GetConnection.State = ConnectionState.Closed Then GetConnection.Open()
        Return GetConnection()
    End Function

    Protected Function CloseConnection() As SqlConnection
        If GetConnection.State = ConnectionState.Open Then GetConnection.Close()
        Return GetConnection()
    End Function

End Class