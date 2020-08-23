Imports System.Data.SqlClient

Public Class CervezasRepo
    Inherits ConnectionToSql
    Private tabla As DataTable = New DataTable()

    Public Function BuscarCervezas() As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                'command.CommandText = "MostrarProductos" '
                command.CommandText = "SELECT 'id' AS 'ID', 'descrip' AS Nombre
                                        FROM Cervezas"

                'command.Parameters.AddWithValue("@id", p_id)
                'command.CommandType = CommandType.StoredProcedure '
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                tabla.Load(reader)
                reader.Dispose()
                Return tabla
            End Using
        End Using
    End Function
End Class
