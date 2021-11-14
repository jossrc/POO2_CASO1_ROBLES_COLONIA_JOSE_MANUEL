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
    public class Policia_DAO
    {
        string sqlConnectionString = ConfigurationManager.ConnectionStrings["cnx"].ConnectionString;

        public List<usp_listar_policias> Policias()
        {
            List<usp_listar_policias> lista = new List<usp_listar_policias>();

            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("usp_listar_policias", connection);
            command.CommandType = CommandType.StoredProcedure;


            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                lista.Add(new usp_listar_policias()
                {
                    CODPOL = dataReader.GetString(0),
                    NOMPOL = dataReader.GetString(1),
                });
            }

            dataReader.Close();

            connection.Close();

            return lista;

        }
    }
}