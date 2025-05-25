using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DatabaseConnection
    {
        private static readonly string connectionString = @"Data Source=LAPTOP-K7S62OP5;Initial Catalog=dbMonitor;TrustServerCertificate=True;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
