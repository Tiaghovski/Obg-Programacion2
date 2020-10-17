using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class VenderApartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarClientes();
                ListarEdificios();
            }
        }

         private void MostarMensaje(string mensaje, bool correcto)
        {
            lblMensaje.Text = mensaje;
            if (correcto)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void DDLEdificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DDLEdificios.SelectedIndex > -1)
            {
                string nomEdi = DDLEdificios.SelectedValue;
                Edificio edi = Empresa.Instancia.BuscarEdificio(nomEdi);
                DDLApartamentos.DataSource = edi.colApartamentos;
                DDLApartamentos.DataTextField = "Datos";
                DDLApartamentos.DataValueField = "Numero";
                DDLApartamentos.DataBind();
            }
        }

        private void ListarClientes()
        {
            DDLClientes.DataSource = Empresa.Instancia.ClientesEm;
            DDLClientes.DataTextField = "Datos";
            DDLClientes.DataValueField = "Documento";
            DDLClientes.DataBind();
        }

        private void ListarEdificios()
        {
            DDLEdificios.DataSource = Empresa.Instancia.Edificios;
            DDLEdificios.DataTextField = "Datos";
            DDLEdificios.DataValueField = "Nombre";
            DDLEdificios.DataBind();
        }

       
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
           

        }


        protected void BtnVender_Click(object sender, EventArgs e)
        {
            Edificio edi = Empresa.Instancia.BuscarEdificio(DDLEdificios.SelectedValue);
            Apartamento apa = edi.BuscarApartamento(Convert.ToInt32(DDLApartamentos.SelectedValue));
            Usuario usu = (Usuario)Session["Usuario"];
            ClienteEm cli = Empresa.Instancia.BuscarCliente(DDLClientes.SelectedValue);
            Venta ven = new Venta(apa.CalcularPrecio(), usu, apa, cli);
            if (usu.BuscarVenta(apa) == null)
            {
                usu.AgregarVenta(ven);
                MostarMensaje("Venta Realizada!", true);
            }
            else
            {
                MostarMensaje("Ese apartamento ya está vendido", false);
            }
           
        }

       

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrarSistema.aspx");
        }

       
    }
}
    
