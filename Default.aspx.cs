using FormularioRegistro.Utilidades;
using Newtonsoft.Json.Linq;
using ProyectoJuan.Utilidades;
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
        public int iUsuarioId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarPaises();
                CargarCurso();
                CargarConocimientos();

                if (!string.IsNullOrEmpty(Request.QueryString["usuario_id"]))


                {
                    iUsuarioId = Int32.Parse(Request.QueryString["usuario_id"]);
                    CargarDatosUsuario(iUsuarioId);
                    ViewState["ID_USUARIO"] = iUsuarioId;

                    ViewState["MODO"] = "MODIFICACION";
                }
                else
                {

                    ViewState["MODO"] = "ALTA";

                }
            }



        }

        void CargarDatosUsuario(int iId)
        {
            string sRet = "";
            DataTable dt = new DataTable();
            sRet = Utilidades.Datos.ObtenerUsuariosRegistrados(iId, ref dt);
            if (sRet == "")
            {
                if (dt.Rows.Count == 1)
                {

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["nombre"])))
                    {
                        txtname.Text = dt.Rows[0]["nombre"].ToString().Trim();

                    }

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["apellido"])))
                    {
                        txtlastname.Text = dt.Rows[0]["apellido"].ToString().Trim();

                    }

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["dni"])))
                    {
                        txtdni.Text = dt.Rows[0]["dni"].ToString().Trim();

                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["email"])))
                    {
                        email.Text = dt.Rows[0]["email"].ToString().Trim();

                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["fecha_nacimiento"]))) ///TODO: fijarse como se llama
                    {
                        Fechanac.Text = Convert.ToDateTime(dt.Rows[0]["fecha_nacimiento"]).ToString("yyyy-MM-dd");


                    }

                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["contraseña"])))

                    {
                        password.Text = dt.Rows[0]["contraseña"].ToString().Trim();
                    }


                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["id_pais"])))

                    {
                        ddlpais.SelectedValue = dt.Rows[0]["id_pais"].ToString().Trim();
                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["conocimientos"])))
                    {
                        CheckBoxList1.SelectedValue = dt.Rows[0]["conocimientos"].ToString().Trim();
                    }
                    if (!string.IsNullOrEmpty(Convert.ToString(dt.Rows[0]["curso_id"])))
                    {
                        miRadioButtonList.SelectedValue = dt.Rows[0]["curso_id"].ToString().Trim();
                    }

                }


            }
        }


            void CargarPaises()
            {
                string sRet = "";
                DataTable dt = new DataTable();

                sRet = Utilidades.Datos.ObtenerPaises(ref dt);



                if (sRet == "")
                {
                    ddlpais.DataValueField = "id_pais";
                    ddlpais.DataTextField = "pais";
                    ddlpais.DataSource = dt;
                    ddlpais.DataBind();
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, sRet, "");
                }

            }

            void CargarConocimientos()
            {
                string sRet = "";
                DataTable dt = new DataTable();

                sRet = Utilidades.Datos.ObtenerConocimientos(ref dt);

                if (sRet == "")
                {
                    CheckBoxList1.DataValueField = "id_concimientos";
                    CheckBoxList1.DataTextField = "conocimientos";
                    CheckBoxList1.DataSource = dt;
                    CheckBoxList1.DataBind();
                }

            }



            void CargarCurso()
            {
                string sRet = "";
                DataTable dt = new DataTable();

                sRet = Utilidades.Datos.ObtenerCursos(ref dt);

                if (sRet == "")
                {
                    miRadioButtonList.DataValueField = "curso_id";
                    miRadioButtonList.DataTextField = "nombre_curso";
                    miRadioButtonList.DataSource = dt;
                    miRadioButtonList.DataBind();
                }

            }

          
        

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {


            string sValidar = ValidarForm();
            if (sValidar != "")
            {
                Utils.ShowAlertAjax(this.Page, sValidar, "");
                return;
            }


            //for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            //{
            //if (CheckBoxList1.Items[i].Selected)
            //{
            //sCono0 += CheckBoxList1.Items[i].Value.ToString() + ",";
            //}

            //}

            if (ViewState["MODO"].ToString() == "MODIFICACION")
            {
                //LLAMO A LA FUNCION QUE ACTUALIZA AL USUARIO
                string sRetorno = "";
                sRetorno = Datos.ActualizarUsuario(Convert.ToInt32(ViewState["ID_USUARIO"]), txtname.Text.Trim(), txtlastname.Text.Trim(), txtdni.Text.Trim(), Convert.ToInt32(ddlpais.SelectedValue), Convert.ToInt32(miRadioButtonList.SelectedValue), email.Text.Trim(), Fechanac.Text.Trim(), CheckBoxList1.Text.Trim(), password.Text.Trim());

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Usuario actualizado exitosamente", "UsuariosRegistrados.aspx");
                    //Response.Redirect("UsuariosRegistrados.aspx");
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al modificar: " + sRetorno, "");
                }
            }
            else if (ViewState["MODO"].ToString() == "ALTA")
            {
                // ACA HAY QUE DAR DE ALTA
                //LLAMO A LA FUNCION QUE DA DE ALTA AL USUARIO
                string sRetorno = "";
                sRetorno = Datos.InsertarUsuario(Convert.ToInt32(ViewState["ID_USUARIO"]), txtname.Text.Trim(), txtlastname.Text.Trim(), txtdni.Text.Trim(), Convert.ToInt32(ddlpais.SelectedValue), Convert.ToInt32(miRadioButtonList.SelectedValue), email.Text.Trim(), Fechanac.Text.Trim(), CheckBoxList1.Text.Trim(), password.Text.Trim());

                if (sRetorno == "")
                {
                    Utils.ShowAlertAjax(this.Page, "Usuario agregado exitosamente", "UsuariosRegistrados.aspx");
                }
                else
                {
                    Utils.ShowAlertAjax(this.Page, "Error al insertar: " + sRetorno, "");
                }

            }
        }

            string ValidarForm()
            {
                string sRet = "";


                DateTime tempDate;
                if (!DateTime.TryParse(Fechanac.Text, out tempDate))
                {
                    sRet += "La fecha no es válida." + System.Environment.NewLine;
                }


                if (txtname.Text == "")
                {
                    sRet += "Debe completar el nombre." + System.Environment.NewLine;
                }

                if (txtlastname.Text == "")
                {
                    sRet += "Debe completar el apellido." + System.Environment.NewLine;
                }

                if (txtdni.Text == "")
                {
                    sRet += "Debe completar el dni." + System.Environment.NewLine;
                }




                return sRet;
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
