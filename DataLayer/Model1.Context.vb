﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class CerveceriaEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CerveceriaEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Botellas() As DbSet(Of Botellas)
    Public Overridable Property Cervezas() As DbSet(Of Cervezas)
    Public Overridable Property Cliente() As DbSet(Of Cliente)
    Public Overridable Property Detalles_pedidos() As DbSet(Of Detalles_pedidos)
    Public Overridable Property Flete() As DbSet(Of Flete)
    Public Overridable Property Gastos() As DbSet(Of Gastos)
    Public Overridable Property Gastos_nombres() As DbSet(Of Gastos_nombres)
    Public Overridable Property Ins_varios() As DbSet(Of Ins_varios)
    Public Overridable Property Levaduras() As DbSet(Of Levaduras)
    Public Overridable Property Lupulos() As DbSet(Of Lupulos)
    Public Overridable Property Maltas() As DbSet(Of Maltas)
    Public Overridable Property Palets() As DbSet(Of Palets)
    Public Overridable Property Pedidos() As DbSet(Of Pedidos)
    Public Overridable Property Planchas() As DbSet(Of Planchas)
    Public Overridable Property Levadura() As DbSet(Of Levadura)
    Public Overridable Property Lupulo() As DbSet(Of Lupulo)

End Class
