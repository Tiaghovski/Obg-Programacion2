<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FrmApartamento.aspx.cs" Inherits="Obligatorio.FrmApartamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Agregar Apartamento</h1>
    <p>
        <asp:Label ID="Label10" runat="server" Text="Seleccione Edificio"></asp:Label>
        <asp:DropDownList ID="DDLEdificios" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label" runat="server" Text="Piso"></asp:Label>
        <asp:TextBox ID="TxtPiso" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Número"></asp:Label>
        <asp:TextBox ID="TxtNumero" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Metraje Total"></asp:Label>
        <asp:TextBox ID="TxtMetrajeTotal" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Precio Base"></asp:Label>
        <asp:TextBox ID="TxtPrecioBase" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Orientación"></asp:Label>
        
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
        
    </p>
    <p>
        <asp:RadioButton ID="rbtnOficina" runat="server" Checked="True" GroupName="Tipo" Text="Oficina"/>
        <asp:RadioButton ID="rbtnCasa" runat="server" GroupName="Tipo" Text="Casa-Habitación"/>
    </p>
    <asp:Panel ID="pnlOficina" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Cantidad de puestos"></asp:Label>
        <asp:TextBox ID="TxtCantPuestos" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="Label6" runat="server" Text="Equipamiento"></asp:Label>
        <asp:DropDownList ID="DDLEquipamiento" runat="server">
            <asp:ListItem Selected="True">SI</asp:ListItem>
            <asp:ListItem>NO</asp:ListItem>
        </asp:DropDownList>
        <br />

    </asp:Panel>
    <asp:Panel ID="pnlCasa" runat="server">
        <asp:Label ID="Label7" runat="server" Text="Cantidad de dormitorios"></asp:Label>
        <asp:TextBox ID="TxtCantDormitorios" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="Label12" runat="server" Text="Cantidad de baños"></asp:Label>
        <asp:TextBox ID="TxtCantBaños" runat="server"></asp:TextBox>
        &nbsp;<asp:Label ID="Label9" runat="server" Text="Garage"></asp:Label>
        <asp:DropDownList ID="DDLGarage" runat="server">
            <asp:ListItem Selected="True">SI</asp:ListItem>
            <asp:ListItem>NO</asp:ListItem>
        </asp:DropDownList>
        <br />
    </asp:Panel>
    <p>
        <asp:Button ID="BtnAgregar" runat="server" Text="Agregar" OnClick="BtnAgregar_Click" />
    </p>
    <p>
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label11" runat="server" Text="Lista de Apartamentos:"></asp:Label>
    </p>
    <p>
        <asp:ListBox ID="LstApartamentos" runat="server"></asp:ListBox>
    </p>
    <asp:Button ID="BtnVolver" runat="server" Text="Volver" OnClick="BtnVolver_Click" />

   <script>        
        window.onload = function () {
            if (document.getElementById("rbtnOficina").hasAttribute("checked")) {
                document.getElementById("pnlOficina").setAttribute("style", "display:block");
                document.getElementById("pnlCasa").setAttribute("style", "display:none");
            } else {
                document.getElementById("pnlCasa").setAttribute("style", "display:block");
                document.getElementById("pnlOficina").setAttribute("style", "display:none");
            }
            document.getElementById("rbtnCasa").onchange = function () {
                document.getElementById("pnlCasa").setAttribute("style", "display:block");
                document.getElementById("pnlOficina").setAttribute("style", "display:none");
            }
            document.getElementById("rbtnOficina").onchange = function () {
                document.getElementById("pnlOficina").setAttribute("style", "display:block");
                document.getElementById("pnlCasa").setAttribute("style", "display:none");
            }
        }
       
    </script> 
    
      
     

</asp:Content>
