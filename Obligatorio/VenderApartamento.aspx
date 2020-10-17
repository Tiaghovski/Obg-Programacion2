<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VenderApartamento.aspx.cs" Inherits="Obligatorio.VenderApartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Vender Apartamentos</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Seleccione Cliente"></asp:Label>
        <asp:DropDownList ID="DDLClientes" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Seleccione Edificio"></asp:Label>
        <asp:DropDownList ID="DDLEdificios" runat="server" OnSelectedIndexChanged="DDLEdificios_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Button ID="BtnBuscar" runat="server" Text="Buscar Apartamentos" OnClick="BtnBuscar_Click" />
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Seleccione Apartamento"></asp:Label>
        <asp:DropDownList ID="DDLApartamentos" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="BtnVender" runat="server" Text="Vender" OnClick="BtnVender_Click" />
        &nbsp;<asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
