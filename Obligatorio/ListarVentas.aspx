<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarVentas.aspx.cs" Inherits="Obligatorio.ListarVentas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listar Ventas</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Seleccione el vendedor"></asp:Label>
        <asp:DropDownList ID="DDLVendedores" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="BtnListar" runat="server" Text="Listar Ventas" OnClick="BtnListar_Click"/>
    </p>
    <p>
        <asp:ListBox ID="LstVentas" runat="server"></asp:ListBox>
    </p>
    <p>
        <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
    </p>

</asp:Content>
