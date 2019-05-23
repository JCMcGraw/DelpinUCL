using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DelpinCore
{
    static class DatabaseManager
    {
        static public string CreateUpdateDeleteInDatabase(string SQL)
        {
            try
            { 
                //initialize new SqlConnection with connectionstring from Utility Class
                using (SqlConnection connection = new SqlConnection(Utility.connectionString))
                {
                    //open connection
                    connection.Open();

                    //initialize SqlCommand
                    using (SqlCommand sqlCommand = new SqlCommand(SQL, connection))
                    {
                        //execute sql to server
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                //return success if query executed properly
                return "Success";
            }
            catch (Exception e)
            {
                //return error message if a problem arose
                return e.Message;
            }
        }

        static public DataTable ReadFromDatabase(string SQL)
        {
            try
            {
                //initialize new DataTable
                DataTable dataTable = new DataTable();

                //initialize new SqlConnection with connectionstring from Utility Class
                using (SqlConnection connection = new SqlConnection(Utility.connectionString))
                {
                    //open connection
                    connection.Open();

                    //initialize SqlCommand
                    using (SqlCommand command = new SqlCommand(SQL, connection))
                    {
                        //execute sql to server and fill dataTable with returned result
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                        sqlDataAdapter.Fill(dataTable);
                    }
                }

                //return dataTable
                return dataTable;
            }
            catch (Exception e)
            {
                //return DataTable with error message if problem arose
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ErrorMessage");

                DataRow dataRow = dataTable.NewRow();
                dataRow["ErrorMessage"] = e.Message;

                dataTable.Rows.Add(dataRow);

                return dataTable;
            }
        }
    }
}
