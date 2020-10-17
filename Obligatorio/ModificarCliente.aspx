<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ModificarCliente.aspx.cs" Inherits="Obligatorio.ModificarCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Modificar Cliente</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Ingrese C.I del cliente a modificar"></asp:Label>
        <asp:TextBox ID="TxtDocumento" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Ingrese nuevo nombre"></asp:Label>
        <asp:TextBox ID="TxtNuevoNombre" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Ingrese nuevo apellido"></asp:Label>
        <asp:TextBox ID="TxtNuevoApellido" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Ingrese nueva dirección"></asp:Label>
        <asp:TextBox ID="TxtNuevaDireccion" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Ingrese nuevo teléfono"></asp:Label>
        <asp:TextBox ID="TxtNuevoTelefono" runat="server"></asp:TextBox>
    </p>
    <p>
    <asp:Button ID="BtnModificar" runat="server" Text="Modificar Cliente" OnClick="BtnModificar_Click"/>
    &nbsp;&nbsp;</p>
    <p>
    <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>

    </p>
    <asp:Label ID="Label2" runat="server" Text="Lista de Clientes"></asp:Label>
   <asp:DropDownList ID="DDLClientes" runat="server">
    </asp:DropDownList>
      <br />
    <br />
    <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
    <br />
    
</asp:Content>
