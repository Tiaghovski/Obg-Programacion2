<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FrmEdificio.aspx.cs" Inherits="Obligatorio.FrmEdificio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Agregar Edificio</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TxtNomEdificio" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Direccion"></asp:Label>
        <asp:TextBox ID="TxtDirEdificio" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="BtnAgregarEdificio" runat="server" Text="Agregar" OnClick="BtnAgregarEdificio_Click" />
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Lista de Edificios:"></asp:Label>
    </p>
    <p>
        <asp:ListBox ID="LstEdificios" runat="server"></asp:ListBox>
    </p>
    <p>
        <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
    </p>
   
    
</asp:Content>
