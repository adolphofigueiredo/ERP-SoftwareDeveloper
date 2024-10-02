using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class CheckConnectionUtility
    {
        public static bool CheckConnectionString(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException("Connection strign non valida");

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}
