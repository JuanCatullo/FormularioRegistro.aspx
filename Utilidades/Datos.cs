using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI.WebControls;

namespace FormularioRegistro.Utilidades
{
    public class Datos
    {

        #region "combos"

        public static string ObtenerUsuariosRegistrados(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerUsuariosRegistrados", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ObtenerPaises(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spPaises", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ObtenerCursos(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spCursos", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string ObtenerConocimientos(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("spObtenerConocimientos", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
                #endregion          
            }

                public static string EliminarUsuario(int iId)
                {
                SqlConnection MyConnection = default(SqlConnection);
                SqlCommand MyCommand = default(SqlCommand);

                try
                {
                    MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                    MyCommand = new SqlCommand("spEliminarUsuario", MyConnection);
                    MyCommand.CommandType = CommandType.StoredProcedure;

                    //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO
                    MyCommand.Parameters.AddWithValue("@id", iId);

                    //ACCIONES A MANO
                    MyConnection.Open(); //ABRO CONEXION
                    MyCommand.ExecuteNonQuery(); //EJECUTO COMANDO
                    MyConnection.Close(); //CIERRO CONEXION
                    MyConnection.Dispose(); //DESCARTO CONEXION

                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

                }


            public static string ActualizarUsuario(int iId, string txtname, string txtlastname, int txtdni, string ddlpais, string miRadioButtonList, string email, DateTime Fechanac, string otros, string password, string confirm_password)
            {
                SqlConnection MyConnection = default(SqlConnection);
                SqlCommand MyCommand = default(SqlCommand);

                try
                {
                    MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                    MyCommand = new SqlCommand("spActualizarUsuario", MyConnection);
                    MyCommand.CommandType = CommandType.StoredProcedure;

                    //AGREGO EL PARAMETRO CON EL VALOR DEL PARAMETRO AL COMANDO
                    MyCommand.Parameters.AddWithValue("@id", iId);

                    MyCommand.Parameters.AddWithValue("@nombre", txtname);

                    MyCommand.Parameters.AddWithValue("@apellido", txtlastname);

                    MyCommand.Parameters.AddWithValue("@dni", txtdni);

                    MyCommand.Parameters.AddWithValue("@pais", ddlpais);

                    MyCommand.Parameters.AddWithValue("@curso", miRadioButtonList);

                    MyCommand.Parameters.AddWithValue("@email", email);

                    MyCommand.Parameters.AddWithValue("@fecha", Fechanac);

                    MyCommand.Parameters.AddWithValue("@otrosconocimientos", otros);

                    MyCommand.Parameters.AddWithValue("@password", password);

                    MyCommand.Parameters.AddWithValue("@confirm_password", confirm_password);

                    //ACCIONES A MANO
                    MyConnection.Open(); //ABRO CONEXION
                    MyCommand.ExecuteNonQuery(); //EJECUTO COMANDO
                    MyConnection.Close(); //CIERRO CONEXION
                    MyConnection.Dispose(); //DESCARTO CONEXION

                    return "";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }












        }

        internal static string EliminarUsuario(int v)
        {
            throw new NotImplementedException();
        }
    }