using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DelpinCore
{
    static class Utility
    {
        public static string connectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "den1.mssql8.gear.host";
                builder.UserID = "delpinucl";
                builder.Password = "delpin!";
                builder.InitialCatalog = "delpinucl";

                return builder.ConnectionString;
            }
            private set
            {
                connectionString = value;
            }
        }

        static public bool CheckForValidPostCode(string cprNumber)
        {
            if (cprNumber.All(char.IsNumber) && cprNumber.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
