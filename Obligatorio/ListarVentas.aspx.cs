using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Obligatorio
{
    public partial class ListarVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarVendedores();
        }

        private void ListarVendedores()
        {
            DDLVendedores.DataSource = Empresa.Instancia.Usuarios;
            DDLVendedores.DataTextField = "Datos";
            DDLVendedores.DataValueField = "NombreUsuario";
            DDLVendedores.DataBind();
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            Empresa emp = Empresa.Instancia;
            LstVentas.DataSource = emp.ListarVentas();
            LstVentas.DataTextField = "Datos";
            LstVentas.DataValueField = "Apartamento";
            LstVentas.DataBind();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdministrarSistema.aspx");
        }
    }
}