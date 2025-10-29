Public Class FormUsuario
    Inherits System.Web.UI.Page

    'Atributos'
    Public Pesona As New Usuario()
    Protected BtnRegistrar As New Button()

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub BtnRegistrar_Click(sender As Object, e As EventArgs)
        'Asignar valores a los atributos del objeto Usuario
        Pesona.Nombre = Request.Form("txtNombre")
        Pesona.Apellido1 = Request.Form("txtApellido1")
        Pesona.Apellido2 = Request.Form("txtApellido2")
        Pesona.Email = Request.Form("txtEmail")
        Pesona.Telefono = Request.Form("txtTelefono")
        Pesona.Rol = Request.Form("ddlRol")

        'Mostrar mensaje de confirmacion
        ClientScript.RegisterStartupScript(Me.GetType(), "alert", "alert('Usuario registrado exitosamente!');", True)
    End Sub

End Class