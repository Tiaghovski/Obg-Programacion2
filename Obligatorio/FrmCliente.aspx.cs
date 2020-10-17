using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class FrmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            LstClientes.DataSource = Empresa.Instancia.ClientesEm;
            LstClientes.DataTextField = "Datos";
            LstClientes.DataValueField = "Documento";
            LstClientes.DataBind();
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
       

        protected void AgregarCliente_Click(object sender, EventArgs e)
        {
            ClienteEm cli = new ClienteEm(TxtNom.Text, TxtApe.Text, TxtDoc.Text, TxtDir.Text, TxtTel.Text);
            if (Empresa.Instancia.AgregarCliente(cli))
            {
                MostarMensaje("Cliente agregado!", true);
            }
            else
            {
                MostarMensaje("No se pudo agregar el cliente", false);
            }

            ListarClientes();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrarSistema.aspx");
        }

       
    }
}