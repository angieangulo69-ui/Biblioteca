<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Mobile.Master" CodeBehind="FormUsuario.aspx.vb" Inherits="Biblioteca.FormUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-4">

        <h2 class="mb-3">Registro de Usuarios</h2>

        <!-- Campos del formulario -->
        <asp:TextBox ID="txtNombre" CssClass="form-control mb-2" placeholder="Nombre" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtApellido1" CssClass="form-control mb-2" placeholder="Primer Apellido" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtApellido2" CssClass="form-control mb-2" placeholder="Segundo Apellido" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtEmail" CssClass="form-control mb-2" placeholder="Correo Electrónico" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtTelefono" CssClass="form-control mb-2" placeholder="Teléfono" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtFechaRegistro" CssClass="form-control mb-2" TextMode="Date" placeholder="Fecha de Registro" runat="server"></asp:TextBox>

        <asp:TextBox ID="txtRol" CssClass="form-control mb-2" placeholder="Rol (Lector/Bibliotecario)" runat="server"></asp:TextBox>

        <!-- DropDownList  para rol -->
        <asp:DropDownList ID="ddlRol" CssClass="form-control mb-3" runat="server">
            <asp:ListItem Text="Seleccione un rol..." Value=""></asp:ListItem>
            <asp:ListItem Text="Lector" Value="Lector"></asp:ListItem>
            <asp:ListItem Text="Bibliotecario" Value="Bibliotecario"></asp:ListItem>
        </asp:DropDownList>

        <!-- Botones -->
        <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary me-2" Text="Registrar" OnClick="btnRegistrar_Click" />
     
        <!-- Mensaje -->
        <asp:Label ID="lblMensaje" runat="server" CssClass="d-block mt-3 text-success"></asp:Label>

        <!-- Tabla de resultados -->
        <
       
            <Columns>
                <asp:BoundField DataField="IdUsuario" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido1" HeaderText="Apellido1" />
                <asp:BoundField DataField="Apellido2" HeaderText="Apellido2" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
                <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha Registro" />
                <asp:BoundField DataField="Rol" HeaderText="Rol" />

                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Columns>

        </asp:GridView>

        <!-- Fuente de datos opcional -->
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"
            ConnectionString="<%$ ConnectionStrings:Proyecto_ProgralllConnectionString %>"
            SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>

    </div>

</asp:Content>
