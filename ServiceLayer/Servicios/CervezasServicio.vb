Imports DataLayer

Public Class CervezasServicio
    Dim objRepo As CervezasRepo = New CervezasRepo()

    Public Function BuscarCervezas() As Object
        Return objRepo.BuscarCervezas()
    End Function

End Class
