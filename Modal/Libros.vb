Public Class Libros
    Private IdLibro As Integer
    Private Titulo As String
    Private Autor As String
    Private Editorial As String
    Private Copaias As Integer

    'Constructor vacio
    Public Sub New()
    End Sub
    'Constructor con parametros
    Public Sub New(idLibro As Integer, titulo As String, autor As String, editorial As String, copaias As Integer)
        Me.IdLibro1 = idLibro
        Me.Titulo1 = titulo
        Me.Autor1 = autor
        Me.Editorial1 = editorial
        Me.Copaias1 = copaias
    End Sub
    'Propiedades de los atriubtos
    Public Property IdLibro1 As Integer
        Get
            Return IdLibro
        End Get
        Set(value As Integer)
            IdLibro = value
        End Set
    End Property

    Public Property Titulo1 As String
        Get
            Return Titulo
        End Get
        Set(value As String)
            Titulo = value
        End Set
    End Property

    Public Property Autor1 As String
        Get
            Return Autor
        End Get
        Set(value As String)
            Autor = value
        End Set
    End Property

    Public Property Editorial1 As String
        Get
            Return Editorial
        End Get
        Set(value As String)
            Editorial = value
        End Set
    End Property

    Public Property Copaias1 As Integer
        Get
            Return Copaias
        End Get
        Set(value As Integer)
            Copaias = value
        End Set
    End Property



End Class
