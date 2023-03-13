using FormularioRegistro.Utilidades;
using ProyectoJuan.Utilidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

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
            string sRett = "";
            DataTable dt = new DataTable();

            sRett = Utilidades.Datos.ObtenerUsuariosRegistrados(ref dt);

            if (sRett == "")
            {
                //cono.DataValueField = "id";
                //cono.DataTextField = "descripcion";
                //cono.DataSource = dt;
                //cono.DataBind();
                gvUsuarios.DataSource = dt;
                gvUsuarios.DataBind();
            }




        }

        protected void gvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.ToString() == "EDITAR")
            {
                //Utils.ShowAlertAjax(this.Page, e.CommandArgument.ToString(), "");
                Response.Redirect("Default.aspx" + "?usuario_id=" + e.CommandArgument.ToString());

            }

            if (e.CommandName.ToString() == "ELIMINAR")
            {
                //LLAMO A LA FUNCION QUE ELIMINA AL USUARIO
                string sRetorno = "";
                sRetorno = Datos.EliminarUsuario(Convert.ToInt32(ViewState["ID_USUARIO"]), txtname.Text.Trim(), txtlastname.Text.Trim(), txtdni.Text.Trim(), Convert.ToInt32(ddlpais.SelectedValue), Convert.ToInt32(miRadioButtonList.SelectedValue), email.Text.Trim(), Fechanac.Text.Trim(), CheckBoxList1.Text.Trim(), password.Text.Trim());

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Usuario eliminado exitosamente", "");
                    //RECARGO LA GRILLA ASI MUESTRA LOS CAMBIOS
                    CargarUsuariosRegistrados();
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al borrar: " + sRetorno, "");
                }
            }

            

        }


            

    }

}
    

    