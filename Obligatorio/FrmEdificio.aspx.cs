using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class FrmEdificio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarEdificios();
        }

        private void ListarEdificios()
        {
            LstEdificios.DataSource = Empresa.Instancia.Edificios;
            LstEdificios.DataTextField = "Datos";
            LstEdificios.DataValueField = "Nombre";
            LstEdificios.DataBind();
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


        protected void BtnAgregarEdificio_Click(object sender, EventArgs e)
        {
            Edificio edi = new Edificio(TxtNomEdificio.Text, TxtDirEdificio.Text);
            if (Empresa.Instancia.AgregarEdificio(edi))
            {
                MostarMensaje("Edificio agregado!", true);
            }
            else
            {
                MostarMensaje("No se pudo agregar el edificio", false);
            }

            ListarEdificios();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrarSistema.aspx");        }

      
    }
}