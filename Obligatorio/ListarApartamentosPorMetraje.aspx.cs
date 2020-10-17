using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class ListarApartamentosPorMetraje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            Empresa emp = Empresa.Instancia;
            LstApartamentos.DataSource = emp.ListarApartamentosPorMetrajeX(Convert.ToSingle(TxtMetraje.Text));
            LstApartamentos.DataTextField = "Datos";
            LstApartamentos.DataValueField = "Numero";
            LstApartamentos.DataBind();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrarSistema.aspx");
        }
    }
}