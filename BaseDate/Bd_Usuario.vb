Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Bd_Usuario
    Public ReadOnly ConnectionString As String = ConfigurationManager.ConnectionStrings("Proyecto_ProgralllConnectionString").ConnectionString
    Public Function create(Usuario As Usuario) As Boolean
        Try

            Dim sql As String = "INSERT INTO Usuario (Nombre, Apellido1, Apellido2, Email, Telefono,FechaRegistro, Rol) VALUES (@Nombre, @Apellido1, @Apellido2, @Email, @Telefono, @FechaRegistro, @Rol)"
            Dim Parametros As New List(Of SqlParameter) From {
            New SqlParameter("@Nombre", Usuario.Nombre),
             New SqlParameter("@Apellido1", Usuario.Apellido1),
            New SqlParameter("@Apellido2", Usuario.Apellido2),
            New SqlParameter("@Email", Usuario.Email),
             New SqlParameter("@Telefono", Usuario.Telefono),
             New SqlParameter("@FechaRegistro", DateTime.Now),
            New SqlParameter("@Rol", Usuario.Rol)
            }
            Using connetion As New SqlConnection(ConnectionString)
                Using command As New SqlCommand(sql, connetion)
                    command.Parameters.AddRange(Parametros.ToArray())
                    connetion.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using


        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

End Class
