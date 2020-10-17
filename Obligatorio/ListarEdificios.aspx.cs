using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class ListarEdificios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            Empresa emp = Empresa.Instancia;
            LstEdificios.DataSource = emp.ListarEdificiosAp(Convert.ToInt32(TxtMin.Text), Convert.ToInt32(TxtMax.Text), (Orientacion)Enum.Parse(typeof(Orientacion), DDLOrientacion.SelectedValue));
            LstEdificios.DataTextField = "Datos";
            LstEdificios.DataValueField = "Nombre";
            LstEdificios.DataBind();
        }
        
        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrarSistema.aspx");
        }
    }
}