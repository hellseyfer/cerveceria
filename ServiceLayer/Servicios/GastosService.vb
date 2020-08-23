Imports DataLayer

Public Class GastosService
    Dim objRepo As GastosRepo = New GastosRepo()

    Public Sub InsertarGasto(value1 As Date, checked As Boolean, value2 As Decimal, text As String)
        objRepo.InsertarGasto(value1, checked, value2, text)
    End Sub

    Public Function MostrarGastos() As Object
        Return objRepo.MostrarGastos()
    End Function
End Class
