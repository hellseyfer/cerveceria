Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CerveceriaDataSet1.Cervezas' Puede moverla o quitarla según sea necesario.
        Me.CervezasTableAdapter1.Fill(Me.CerveceriaDataSet1.Cervezas)
        'TODO: esta línea de código carga datos en la tabla 'CerveceriaDataSet.Cervezas' Puede moverla o quitarla según sea necesario.
        'Me.CervezasTableAdapter.Fill(Me.CerveceriaDataSet.Cervezas)

    End Sub


End Class