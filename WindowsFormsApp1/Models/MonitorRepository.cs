using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class MonitorRepository
    {
        public void InsertMonitor(string merek, string cc, decimal harga, string jenis)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Monitor (MerekMonitor, CC, Harga, Jenis) VALUES (@MerekMonitor, @CC, @Harga, @Jenis)", con);
                cmd.Parameters.AddWithValue("@MerekMonitor", merek);
                cmd.Parameters.AddWithValue("@CC", cc);
                cmd.Parameters.AddWithValue("@Harga", harga);
                cmd.Parameters.AddWithValue("@Jenis", jenis);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateMonitor(string merek, string cc, decimal harga, string jenis)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Monitor SET CC=@CC, Harga=@Harga, Jenis=@Jenis WHERE MerekMonitor=@MerekMonitor", con);
                cmd.Parameters.AddWithValue("@MerekMonitor", merek);
                cmd.Parameters.AddWithValue("@CC", cc);
                cmd.Parameters.AddWithValue("@Harga", harga);
                cmd.Parameters.AddWithValue("@Jenis", jenis);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteMonitor(string merek)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Monitor WHERE MerekMonitor=@MerekMonitor", con);
                cmd.Parameters.AddWithValue("@MerekMonitor", merek);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllMonitors()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Monitor", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                return table;
            }
        }
    }
}
