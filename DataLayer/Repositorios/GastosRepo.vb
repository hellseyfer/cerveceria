Imports System.Data.SqlClient

Public Class GastosRepo
    Inherits ConnectionToSql
    Private tabla As DataTable = New DataTable()

    Public Sub InsertarGasto(p_fecha As Date, p_esmensual As Boolean, p_monto As Decimal, p_desc As String)
        'insert new gestacion
        Try
            Using connection = GetConnection()
                connection.Open()
                Using command = New SqlCommand()
                    command.Connection = connection
                    command.CommandText = "INSERT INTO Gastos (fecha_ini, esmensual, monto, descrip, fk_nombre)
                                           VALUES (@p_facha_ini, @p_esmensual, @p_monto, @p_desc, 1)
                                        "  ' respetar orden de las columnas
                    command.CommandType = CommandType.Text
                    command.Parameters.AddWithValue("@p_facha_ini", p_fecha)
                    command.Parameters.AddWithValue("@p_esmensual", p_esmensual)
                    command.Parameters.AddWithValue("@p_monto", p_monto)
                    command.Parameters.AddWithValue("@p_desc", p_desc)
                    command.ExecuteNonQuery()
                    command.Parameters.Clear()
                    MsgBox("Guardado correctamente")

                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function MostrarGastos() As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                'command.CommandText = "MostrarProductos" '
                command.CommandText = "SELECT 'id' AS 'ID', 'fecha_ini' AS Fecha, 'esmensual' AS Mensual, 'monto' AS Monto, 'descrip' as Descripcion
                                        FROM Gastos"

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
