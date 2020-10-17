<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FrmAdministrarSistema.aspx.cs" Inherits="Obligatorio.FrmAdministrarSistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color:red; font-family:Verdana"><u>Administración del Sitio:</u></h1>
    <h3 style="color:dodgerblue; font-family:Verdana">Elija una opción:</h3>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/FrmCliente.aspx">Agregar Cliente</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/ModificarCliente.aspx">Modificar Cliente</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/EliminarCliente.aspx">Eliminar Cliente</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/FrmEdificio.aspx">Agregar Edificio</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/FrmApartamento.aspx">Agregar Apartamento</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/ListarEdificios.aspx">Listar Edificios</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/ListarApartamentosPorPrecio.aspx">Listar Apartamentos Según Precio</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/ListarApartamentosPorMetraje.aspx">Listar Apartamentos Según Metraje</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink11" runat="server" NavigateUrl="~/VenderApartamento.aspx">Vender Apartamentos</asp:HyperLink>
    </p>
    <p style="font-family:Verdana">
        <asp:HyperLink ID="HyperLink12" runat="server" NavigateUrl="~/ListarVentas.aspx">Listar Ventas</asp:HyperLink>
    </p>
               
   
            
    </asp:Content>
