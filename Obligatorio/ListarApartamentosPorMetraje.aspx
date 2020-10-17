<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarApartamentosPorMetraje.aspx.cs" Inherits="Obligatorio.ListarApartamentosPorMetraje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listar Apartamentos Por Metraje</h1>
    <asp:Label ID="Label1" runat="server" Text="Metraje menor a: "></asp:Label>
    <asp:TextBox ID="TxtMetraje" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="BtnListar" runat="server" Text="Listar" OnClick="BtnListar_Click" />
    <br />
    <br />
    <asp:ListBox ID="LstApartamentos" runat="server"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
</asp:Content>
