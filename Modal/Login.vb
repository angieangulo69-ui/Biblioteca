Public Class Login
    'Atributos'
    Private IdLogin As Integer
    Private Correo As String
    Private Contrasena As String
    Private FechaRegistro As DateTime


    'Constructor vacio
    Public Sub New()
    End Sub

    'Constructor con parametros
    Public Sub New(idLogin As Integer, correo As String, contrasena As String, fechaRegistro As Date)
        Me.IdLogin1 = idLogin
        Me.Correo1 = correo
        Me.Contrasena1 = contrasena
        Me.FechaRegistro1 = fechaRegistro
    End Sub
    'Propiedades de los atriubtos
    Public Property IdLogin1 As Integer
        Get
            Return IdLogin
        End Get
        Set(value As Integer)
            IdLogin = value
        End Set
    End Property

    Public Property Correo1 As String
        Get
            Return Correo
        End Get
        Set(value As String)
            Correo = value
        End Set
    End Property

    Public Property Contrasena1 As String
        Get
            Return Contrasena
        End Get
        Set(value As String)
            Contrasena = value
        End Set
    End Property

    Public Property FechaRegistro1 As Date
        Get
            Return FechaRegistro
        End Get
        Set(value As Date)
            FechaRegistro = value
        End Set
    End Property
End Class
