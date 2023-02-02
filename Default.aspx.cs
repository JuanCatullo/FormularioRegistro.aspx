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
            return ""; //para que no de error la funcion
            string sRetorno = "";

            if (txtdni.Text.Trim() == "")
            {
                sRetorno += "Falta DNI";
                txtdni.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;

            }
            if (txtname.Text.Trim() == "")
            {
                sRetorno += "Falta Nombre";
                txtdni.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;

            }
            if (txtlastname.Text.Trim() == "")
            {
                sRetorno += "Falta Apellido";
                txtdni.BorderColor = Color.Red;
                lblerror.BackColor = Color.Red;

                return sRetorno;
        }   }


    }    
}
