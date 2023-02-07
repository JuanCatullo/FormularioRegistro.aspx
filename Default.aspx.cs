using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
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
            sDL = DropDownList1.SelectedValue;

            string sRBL;
            sRBL = miRadioButtonList.SelectedValue;

            string sCono0;
            bool bConocimientos0;
            bConocimientos0 = CheckBoxList1.Items[0].Selected;

            if (bConocimientos0)
            {
                sCono0 = CheckBoxList1.Items[0].Value;
            }

            if (bConocimientos0)
            {
                Utilidades.ShowAlertAjax(this, "Seleccionada", "");
            }
            else
            {
                Utilidades.ShowAlertAjax(this, "NO Seleccionada", "");
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
