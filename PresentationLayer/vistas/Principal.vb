Imports System.Runtime.InteropServices
Imports System.Windows.Forms


Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirFomEnPanel(Form1)

    End Sub

    Public Sub AbrirFomEnPanel(ByVal Formhijo As Object)
        While Me.PanelContenedor.Controls.Count > 0
            Me.PanelContenedor.Controls.RemoveAt(0)
        End While

        'Dim fh As Form = TryCast(Formhijo, Form)
        Formhijo.TopLevel = False
        Formhijo.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Formhijo.Dock = Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Controls.Add(Formhijo)
        Me.PanelContenedor.Tag = Formhijo
        Formhijo.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        AbrirFomEnPanel(Gastos)
        'Gastos.MostrarCampos()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        AbrirFomEnPanel(Form1)
    End Sub
End Class