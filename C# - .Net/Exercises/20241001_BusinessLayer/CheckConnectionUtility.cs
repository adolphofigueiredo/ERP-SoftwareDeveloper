using System;
using System.Data.SqlClient;

namespace _20241001_BusinessLayer
{
    public static class CheckConnectionUtility
    {
        public static bool CheckConnectionString(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentException("Invalid connection string!");

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
