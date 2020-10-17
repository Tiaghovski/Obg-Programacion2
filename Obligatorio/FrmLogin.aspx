<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="Obligatorio.FrmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>   
    <asp:TextBox ID="TxtNombreUsuario" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
    <asp:TextBox ID="TxtClave" runat="server"></asp:TextBox> 
    <asp:Button ID="BtnIngresar" runat="server" OnClick="BtnIngresar_Click" Text="Ingresar" />
    <br />
    <asp:Label ID="LblMensaje" runat="server"></asp:Label>
    <h3 style="color:red; font-family:Verdana" >Para administrar el sistema debe loguearse</h3>
</asp:Content>
