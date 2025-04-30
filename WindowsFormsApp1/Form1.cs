using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;Initial Catalog=dbMonitor;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Monitor (MerekMonitor, CC, Harga, Jenis) VALUES (@MerekMonitor, @CC, @Harga, @Jenis)", con);
            cmd.Parameters.AddWithValue("@MerekMonitor", textBox1.Text);
            cmd.Parameters.AddWithValue("@CC", textBox2.Text);
            cmd.Parameters.AddWithValue("@Harga", decimal.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Jenis", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil disimpan!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;Initial Catalog=dbMonitor;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Monitor SET MerekMonitor=@MerekMonitor, CC=@CC, Harga=@Harga, Jenis=@Jenis WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@MerekMonitor", textBox1.Text);
            cmd.Parameters.AddWithValue("@CC", textBox2.Text);
            cmd.Parameters.AddWithValue("@Harga", decimal.Parse(textBox3.Text));
            cmd.Parameters.AddWithValue("@Jenis", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil diupdate!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;Initial Catalog=dbMonitor;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Monitor WHERE MerekMonitor=@MerekMonitor", con);
            cmd.Parameters.AddWithValue("@MerekMonitor", int.Parse(textBox1.Text)); // Hapus berdasarkan Id
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data berhasil dihapus!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-K7S62OP5;Initial Catalog=dbMonitor;TrustServerCertificate=True;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Monitor", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            con.Close();
        }
    }
}
