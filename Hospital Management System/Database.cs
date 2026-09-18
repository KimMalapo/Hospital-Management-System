using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    public static class Database
    {
        private static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["HospitalDatabase"].ConnectionString;

        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static async Task<bool> TestConnectionAsync()
        {
            try
            {
                using (SqlConnection connection = CreateConnection())
                {
                    await connection.OpenAsync();
                    return true;
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}