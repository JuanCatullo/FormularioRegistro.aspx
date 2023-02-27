using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;


namespace FormularioRegistro.aspx
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) {
                CargarPaises();
                CargarCurso();
                CargarConocimientos();
            }

                
        }

        void CargarPaises()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.spPaises(ref dt);

            

            if (sRet == "")
            {
                ddlpais.DataValueField = "id_pais";
                ddlpais.DataTextField = "pais";
                ddlpais.DataSource = dt;
                //ddlpais.DataBind();
            }
            else
            {
                Response.Write(sRet);
            }

        }

        void CargarConocimientos()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.spObtenerConocimientos(ref dt);

            if (sRet == "")
            {
                ddlpais.DataValueField = "id_concimientos";
                ddlpais.DataTextField = "conocimientos";
                ddlpais.DataSource = dt;
                //ddlpais.DataBind();
            }

        }

        void CargarCurso()
        {
            string sRet = "";
            DataTable dt = new DataTable();

            sRet = Utilidades.Datos.spCursos(ref dt);

            if (sRet == "")
            {
                ddlpais.DataValueField = "curso_id";
                ddlpais.DataTextField = "nombre_curso";
                ddlpais.DataSource = dt;
                //ddlpais.DataBind();
            }

        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }

        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {

            string sDL;
            sDL = ddlpais.SelectedValue;

            string sRBL;
            sRBL = miRadioButtonList.SelectedValue;

            string sCono0 = "";

            //for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            //{
            	//if (CheckBoxList1.Items[i].Selected)
            	//{
            		//sCono0 += CheckBoxList1.Items[i].Value.ToString() + ",";
            	//}

            //}

            foreach (ListItem item in CheckBoxList1.Items)
            {
            	if (item.Selected)
            	{
                    sCono0 += item.Value.ToString() + ",";
            	}

            }
            if (sCono0 != "")
            {
            	 //Utilidades.ShowAlertAjax(this, sCono0, "");
            	// Utilidades.ShowAlertAjax(this, sCono0.Remove(sCono0.LastIndexOf(",")), "");
            }

            if (sCono0 != "")
            {

            	String[] separator = { "," };
            	String[] strlist = sCono0.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            	foreach (String s in strlist)
            	{
            		// Utilidades.ShowAlertAjax(this, s, "");
            	}
            }



            string sRet = "";
            sRet = ValidarControles();

            if (sRet == "")
            {

            }
            else
            {
                lblerror.Text = sRet;
            }
        }

        string ValidarControles()
        {
            
            string sRetorno = "";

            if (txtdni.Text.Trim() == "")
            {
                sRetorno += "Falta DNI" + System.Environment.NewLine; 
                txtdni.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;

            }
            if (txtname.Text.Trim() == "")
            {
                sRetorno += "Falta Nombre" + System.Environment.NewLine; 
                txtdni.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;

            }
            if (txtlastname.Text.Trim() == "")
            {
                sRetorno += "Falta Apellido" + System.Environment.NewLine; 
                txtdni.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;

                
            }
            if (email.Text.Trim() == "")
            {
                sRetorno += "Falta email" + System.Environment.NewLine ;
                email.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;
            }
            if (Fechanac.Text.Trim() == "")
            {
                sRetorno += "Falta Fecha de Nacimiento" + System.Environment.NewLine ;
                Fechanac.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;
            }
            if (password.Text.Trim() == "")
            {
                sRetorno += "Falta Contraseña" + System.Environment.NewLine ;
                password.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;
            }

            if (password.Text != confirm_password.Text)
            {
                lblerror.Text = "Las contraseñas no coinciden.";

            }

            return sRetorno;

            


















        }



    }    
}
