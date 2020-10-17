<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarApartamentosPorPrecio.aspx.cs" Inherits="Obligatorio.ListarApartamentosPorPrecio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listar Apartamentos Por Precio</h1>
    <asp:Label ID="Label1" runat="server" Text="Precio menor a: "></asp:Label>
    <asp:TextBox ID="TxtPrecio" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="BtnListar" runat="server" Text="Listar" OnClick="BtnListar_Click" Height="26px" />
    <br />
    <br />
    <asp:ListBox ID="LstApartamentos" runat="server"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
</asp:Content>
