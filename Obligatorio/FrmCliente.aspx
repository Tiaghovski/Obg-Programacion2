<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FrmCliente.aspx.cs" Inherits="Obligatorio.FrmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Agregar Cliente</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TxtNom" runat="server"></asp:TextBox>        
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="TxtApe" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Documento"></asp:Label>
        <asp:TextBox ID="TxtDoc" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Dirección"></asp:Label>
        <asp:TextBox ID="TxtDir" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Teléfono"></asp:Label>
        <asp:TextBox ID="TxtTel" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnAgregarCliente" runat="server" Text="Agregar" OnClick="AgregarCliente_Click" />
        
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Lista de Clientes:"></asp:Label>
    </p>
    <p>
        <asp:ListBox ID="LstClientes" runat="server"></asp:ListBox>
    </p>
    <p>
       <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
    </p>

 
</asp:Content>
