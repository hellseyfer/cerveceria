Imports ServiceLayer
Imports System.Windows.Forms
'Imports CommonComponents

Public Class Gastos
    'Private gastosService As GastosService = New GastosService()

    Private Sub Gastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CerveceriaDataSet1.Gastos' Puede moverla o quitarla según sea necesario.
        Me.GastosTableAdapter1.Fill(Me.CerveceriaDataSet1.Gastos)
        'TODO: esta línea de código carga datos en la tabla 'CerveceriaDataSet.Gastos' Puede moverla o quitarla según sea necesario.
        'Me.GastosTableAdapter.Fill(Me.CerveceriaDataSet.Gastos)

    End Sub

    Friend Sub Mostrar()
        Dim objeto As GastosService = New GastosService()
        DGgastos.DataSource = objeto.MostrarGastos()
    End Sub

    Private Sub BNuevoGasto_Click(sender As Object, e As EventArgs) Handles BNuevoGasto.Click
        NuevoGasto.Show()
    End Sub


End Class