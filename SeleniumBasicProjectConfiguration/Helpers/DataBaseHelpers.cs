using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasicProjectConfiguration.Helpers
{
    public static class DataBaseHelpers
    {
        public static SqlConnection DBConnect(this SqlConnection sqlConnection, string connectionString)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                // Abro a conexão com o banco de dados
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                LogHelpers.Write("Erro ::" + e.Message);
            }

            return null;
        }

        // Fecho a conexã com o banco de dados
        public static void DBCloseConnection(this SqlConnection sqlConnection)
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                LogHelpers.Write("Erro ::" + e.Message);
            }

        }

        public static DataTable ExecuteQuery(this SqlConnection sqlConnection, string queryString)
        {
            DataSet dataSet;
            try
            {
                // verifico se a conexão está fechada, caso esteja, inicio a conexão
                if (sqlConnection == null || ((sqlConnection != null && (sqlConnection.State == ConnectionState.Closed || sqlConnection.State == ConnectionState.Broken))))
                    sqlConnection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand(queryString, sqlConnection);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;

                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "table");
                sqlConnection.Close();
                return dataSet.Tables["tables"];
            }
            catch (Exception e)
            {
                dataSet = null;
                sqlConnection.Close();
                LogHelpers.Write("Erro ::" + e.Message);
                return null;
            }
            finally
            {
                dataSet = null;
                sqlConnection.Close();
            }
        }
    }
}
