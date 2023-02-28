using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormularioRegistro.aspx
{
    public partial class UsuariosRegistrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                CargarUsuariosRegistrados();
            }
        }

        void CargarUsuariosRegistrados()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.ObtenerUsuariosRegistrados(ref dt);



            if (sRet == "")
            {

                gvUsuarios.DataSource= dt;
                gvUsuarios.DataBind();

            }
            else
            {
                Utilidades.Utils.ShowAlertAjax(this.Page, sRet, "");
            }



        }
    }
}