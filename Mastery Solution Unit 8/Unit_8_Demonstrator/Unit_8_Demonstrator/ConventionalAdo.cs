using System;
using System.Data;
using System.Data.SqlClient;

namespace Unit_8_Demonstrator
{
    public class ConventionalAdo
    {
        public DataTable RunQueryTable (string sqlConnectionString, string dataTableQueryString)
        {
            DataTable dataTable;

            using (var sqlConnection = new SqlConnection(sqlConnectionString))
            {
                sqlConnection.Open(); 
                using (var sqlDataAdapter = new SqlDataAdapter(dataTableQueryString, sqlConnection))
                {
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
