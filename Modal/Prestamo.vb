Public Class Prestamo
    'Atributos'
    Private IdPrestamo As Integer
    Private IdUsuario As Integer
    Private IdLibro As Integer
    Private FechaPrestamo As DateTime
    Private FechaDevolucion As DateTime
    'Constructor vacio
    Public Sub New()
    End Sub
    'Constructor con parametros 
    Public Sub New(idPrestamo As Integer, idUsuario As Integer, idLibro As Integer, fechaPrestamo As Date, fechaDevolucion As Date)
        Me.IdPrestamo1 = idPrestamo
        Me.IdUsuario1 = idUsuario
        Me.IdLibro1 = idLibro
        Me.FechaPrestamo1 = fechaPrestamo
        Me.FechaDevolucion1 = fechaDevolucion
    End Sub

    Public Property IdPrestamo1 As Integer
        Get
            Return IdPrestamo
        End Get
        Set(value As Integer)
            IdPrestamo = value
        End Set
    End Property

    Public Property IdUsuario1 As Integer
        Get
            Return IdUsuario
        End Get
        Set(value As Integer)
            IdUsuario = value
        End Set
    End Property

    Public Property IdLibro1 As Integer
        Get
            Return IdLibro
        End Get
        Set(value As Integer)
            IdLibro = value
        End Set
    End Property

    Public Property FechaPrestamo1 As Date
        Get
            Return FechaPrestamo
        End Get
        Set(value As Date)
            FechaPrestamo = value
        End Set
    End Property

    Public Property FechaDevolucion1 As Date
        Get
            Return FechaDevolucion
        End Get
        Set(value As Date)
            FechaDevolucion = value
        End Set
    End Property
    'Propiedades de los atriubtos

End Class
