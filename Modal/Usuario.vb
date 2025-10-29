Public Class Usuario
    'Atributos'
    Private _IdUsuario As Integer
    Private _Nombre As String
    Private _Apellido1 As String
    Private _Apellido2 As String
    Private _Email As String
    Private _Telefono As String
    Private _Rol As String

    'Constructor vacio
    Public Sub New()
    End Sub

    'Constructor con parametros
    Public Sub New(idUsuario As Integer, nombre As String, apellido1 As String, apellido2 As String, email As String, telefono As String, rol As String)
        Me.IdUsuario = idUsuario
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.Email = email
        Me.Telefono = telefono
        Me.Rol = rol
    End Sub

    Public Property IdUsuario As Integer
        Get
            Return _IdUsuario
        End Get
        Set(value As Integer)
            _IdUsuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    'Propiedades de los atriubtos
    Public Property Apellido1 As String
        Get
            Return _Apellido1
        End Get
        Set(value As String)
            _Apellido1 = value
        End Set
    End Property

    Public Property Apellido2 As String
        Get
            Return _Apellido2
        End Get
        Set(value As String)
            _Apellido2 = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Rol As String
        Get
            Return _Rol
        End Get
        Set(value As String)
            _Rol = value
        End Set
    End Property
    'Propiedades'



End Class
