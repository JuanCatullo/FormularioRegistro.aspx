﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;

namespace FormularioRegistro.Utilidades
{
    public class Datos
    {
        #region "combos"

        public static string ObtenerPaises(ref DataTable dt)
        {
            SqlConnection MyConnection = default(SqlConnection);
            SqlDataAdapter MyDataAdapter = default(SqlDataAdapter);

            try
            {
                MyConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringSQL"].ConnectionString);
                MyDataAdapter = new SqlDataAdapter("Paises", MyConnection);
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
                MyDataAdapter = new SqlDataAdapter("SPConocimientos", MyConnection);
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
                MyDataAdapter = new SqlDataAdapter("Cursos", MyConnection);
                MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                dt = new DataTable();
                MyDataAdapter.Fill(dt);
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            #endregion

        }
    }

}


