Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class Bd_Usuario
    Public ReadOnly ConnectionString As String = ConfigurationManager.ConnectionStrings("Proyecto_ProgralllConnectionString").ConnectionString
    Public Function Create(usuario As Usuario) As Boolean
        Try

            Dim sql As String = "INSERT INTO Usuario (Nombre, Apellido1, Apellido2, Email, Telefono,FechaRegistro, Rol) VALUES (@Nombre, @Apellido1, @Apellido2, @Email, @Telefono, @FechaRegistro, @Rol)"

            Using connection As New SqlConnection(ConnectionString)
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre)
                    command.Parameters.AddWithValue("@Apellido1", usuario.Apellido1)
                    command.Parameters.AddWithValue("@Apellido2", usuario.Apellido2)
                    command.Parameters.AddWithValue("@Email", usuario.Email)
                    command.Parameters.AddWithValue("@Telefono", usuario.Telefono)
                    command.Parameters.AddWithValue("@FechaRegistro", DateTime.Now)
                    command.Parameters.AddWithValue("@Rol", usuario.Rol)



                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            Throw New Exception("Error al registrar el Usuario: " & ex.Message)
            Return False
        End Try

        Return True
    End Function

End Class
