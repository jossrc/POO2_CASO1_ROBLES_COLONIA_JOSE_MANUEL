using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

using POO2_CASO1_ROBLES_COLONIA_JOSE_MANUEL.Models;

namespace POO2_CASO1_ROBLES_COLONIA_JOSE_MANUEL.Controllers
{
    public class Papeletas_DAO
    {
        string sqlConnectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

        public List<usp_papeletas_por_anio> PapeletasPorAnio(int anio)
        {
            List<usp_papeletas_por_anio> list = new List<usp_papeletas_por_anio>();

            SqlConnection connection = new SqlConnection(sqlConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("usp_papeletas_por_anio", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@anio_papeleta", SqlDbType.Int).Value = anio;

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                list.Add(new usp_papeletas_por_anio()
                {
                    NROPAP = dataReader.GetInt32(0),
                    PAPFECHA = dataReader.GetDateTime(1),
                    NOMPRO = dataReader.GetString(2),
                    NROPLA = dataReader.GetString(3),
                    CODINF = dataReader.GetString(4)

                });
            }

            dataReader.Close();

            connection.Close();

            return list;
        }


        public List<usp_papeletas_por_policia_anio> PapeletasPorPoliciaAnio(string codipol, int anio)
        {
            List<usp_papeletas_por_policia_anio> list = new List<usp_papeletas_por_policia_anio>();

            SqlConnection connection = new SqlConnection(sqlConnectionString);

            connection.Open();

            SqlCommand command = new SqlCommand("usp_papeletas_por_policia_anio", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@codipol", SqlDbType.Char, 5).Value = codipol;
            command.Parameters.Add("@anio_papeleta", SqlDbType.Int).Value = anio;

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                list.Add(new usp_papeletas_por_policia_anio()
                {
                    NROPAP = dataReader.GetInt32(0),
                    PAPFECHA = dataReader.GetDateTime(1),
                    NOMPRO = dataReader.GetString(2),
                    NROPLA = dataReader.GetString(3),
                    CODINF = dataReader.GetString(4)

                });
            }

            dataReader.Close();

            connection.Close();

            return list;
        }

    }
}