using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class FrmAdministrarSistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["Usuario"] == null || !(Session["Usuario"] is Administrador))
                {
                    Response.Redirect("FrmLogin.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmCliente.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarCliente.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEdificio.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEdificio.aspx");
        }
    }
}