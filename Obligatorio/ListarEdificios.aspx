<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarEdificios.aspx.cs" Inherits="Obligatorio.ListarEdificios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Listar Edificios</h1>
    <asp:Label ID="Label3" runat="server" Text="Ingrese un mínimo y un máximo de metros cuadrados:"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Min"></asp:Label>
    &nbsp;<asp:TextBox ID="TxtMin" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Máx"></asp:Label>
    &nbsp;<asp:TextBox ID="TxtMax" runat="server"></asp:TextBox>
&nbsp;<br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Seleccione una Orientación"></asp:Label>
&nbsp;<asp:DropDownList ID="DDLOrientacion" runat="server">
            <asp:ListItem>N</asp:ListItem>
            <asp:ListItem>NO</asp:ListItem>
            <asp:ListItem>NE</asp:ListItem>
            <asp:ListItem>S</asp:ListItem>
            <asp:ListItem>SO</asp:ListItem>
            <asp:ListItem>SE</asp:ListItem>
            <asp:ListItem>O</asp:ListItem>
            <asp:ListItem>E</asp:ListItem>
        </asp:DropDownList>

    <br />
    <br />
    <asp:Button ID="BtnListar" runat="server" Text="Listar Edificios" OnClick="BtnListar_Click" />
    <br />
    <br />
    <asp:ListBox ID="LstEdificios" runat="server"></asp:ListBox>
    <br />
    <br />
    <asp:Button ID="BtnVolver" runat="server"  Text="Volver" OnClick="BtnVolver_Click" />
    <br />
   

</asp:Content>
