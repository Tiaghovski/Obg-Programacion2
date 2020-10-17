using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class FrmApartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarEdificios();
                ListarApartamentos();

            }
        }

        private void ListarApartamentos()
        {
            if (DDLEdificios.SelectedIndex > -1)
            {

                LstApartamentos.DataSource = Empresa.Instancia.ListarTodosLosApartamentos();
                LstApartamentos.DataTextField = "Datos";
                LstApartamentos.DataValueField = "Numero";
                LstApartamentos.DataBind();
            }
        }

        private void ListarEdificios()
        {
            DDLEdificios.DataSource = Empresa.Instancia.Edificios;
            DDLEdificios.DataTextField = "Datos";
            DDLEdificios.DataValueField = "Nombre";
            DDLEdificios.DataBind();
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

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (rbtnOficina.Checked)
            {
                Orientacion o = (Orientacion)Enum.Parse(typeof(Orientacion), DDLOrientacion.SelectedValue);
                string nomEdi = DDLEdificios.SelectedValue;
                Edificio edi = Empresa.Instancia.BuscarEdificio(nomEdi);
                Oficina ofi = new Oficina(Convert.ToInt32(TxtPiso.Text), Convert.ToInt32(TxtNumero.Text), Convert.ToInt32(TxtMetrajeTotal.Text), Convert.ToSingle(TxtPrecioBase.Text), o, Convert.ToInt32(TxtCantPuestos.Text), DDLEquipamiento.SelectedIndex == 0, edi);
                if (DDLEdificios.SelectedIndex > -1 && edi.BuscarApartamento(ofi.numero) == null)
                {
                    edi.AgregarApartamento(ofi);
                    MostarMensaje("Oficina agregada!", true);
                }
                else
                {
                    MostarMensaje("No se pudo agregar Oficina", false);
                }
            }
            else
            {
                Orientacion o = (Orientacion)Enum.Parse(typeof(Orientacion), DDLOrientacion.SelectedValue);
                string nomEdi = DDLEdificios.SelectedValue;
                Edificio edi = Empresa.Instancia.BuscarEdificio(nomEdi);
                Casa_Habitacion ch = new Casa_Habitacion(Convert.ToInt32(TxtPiso.Text), Convert.ToInt32(TxtNumero.Text), Convert.ToInt32(TxtMetrajeTotal.Text), Convert.ToSingle(TxtPrecioBase.Text), o, Convert.ToInt32(TxtCantDormitorios.Text), Convert.ToInt32(TxtCantBaños.Text), DDLGarage.SelectedIndex == 0, edi);
                if (DDLEdificios.SelectedIndex > -1 && edi.BuscarApartamento(ch.numero) == null)
                {
                    edi.AgregarApartamento(ch);
                    MostarMensaje("Casa-Habitación agregada!", true);
                }
                else
                {
                    MostarMensaje("No se pudo agregar Casa-Habitación", false);
                }
            }
            ListarApartamentos();
        }
                                                                

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrarSistema.aspx");
        }
        
    }
}

        
    


     

   