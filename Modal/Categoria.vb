Public Class Categoria
    'Atributos'
    Private IdCategoria As Integer
    Private NombreCategoria As String

    'Constructor vacio
    Public Sub New()

    End Sub
    'Constructor con parametros
    Public Sub New(idCategoria As Integer, nombreCategoria As String)
        Me.IdCategoria1 = idCategoria
        Me.NombreCategoria1 = nombreCategoria

    End Sub
    'Propiedades de los atriubtos
    Public Property IdCategoria1 As Integer
        Get
            Return IdCategoria
        End Get
        Set(value As Integer)
            IdCategoria = value
        End Set
    End Property

    Public Property NombreCategoria1 As String
        Get
            Return NombreCategoria
        End Get
        Set(value As String)
            NombreCategoria = value
        End Set
    End Property
End Class
