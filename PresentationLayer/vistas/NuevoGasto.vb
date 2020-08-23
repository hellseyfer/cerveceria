Imports ServiceLayer

Public Class NuevoGasto
    Private ReadOnly objService As GastosService = New GastosService()
    Public _editing As Boolean = False

    Private Sub NuevoGasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _editing = False Then
            'LlenarCamposConsulta()
            'BGuardar.Enabled = False
        Else
            'BGuardar.Enabled = True
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Try
            If _editing = False Then
                objService.InsertarGasto(DPfechaGasto.Value,
                                         CBesmensual.Checked,
                                         NMonto.Value, TBDesc.
                                         Text)
            End If
            Me.Close()
            'Gastos.Mostrar()

        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Revise los campos.")
        End Try

    End Sub


End Class