'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Botellas
    Public Property id As Integer
    Public Property pet As String
    Public Property costo_fabrica As Integer
    Public Property fk_cant_palet As Integer
    Public Property descrip As String

    Public Overridable Property Palets As Palets
    Public Overridable Property Flete As ICollection(Of Flete) = New HashSet(Of Flete)

End Class
