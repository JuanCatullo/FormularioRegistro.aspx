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
            if (!Page.IsPostBack)
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

        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "EDITAR")
            {
                //Utils.ShowAlertAjax(this.Page, e.CommandArgument.ToString(), "");
                Response.Redirect("FormularioRegistro.aspx" + "?usuario_id=" + e.CommandArgument.ToString());
            }

            if (e.CommandName.ToString() == "ELIMINAR")
            {

            }
        }

        protected void gvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

    