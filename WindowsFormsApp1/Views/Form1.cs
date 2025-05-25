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
using WindowsFormsApp1.Conrollers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MonitorController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new MonitorController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                controller.AddMonitor(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text), textBox4.Text);
                MessageBox.Show("Data berhasil disimpan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan data: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                controller.UpdateMonitor(textBox1.Text, textBox2.Text, decimal.Parse(textBox3.Text), textBox4.Text);
                MessageBox.Show("Data berhasil diupdate!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                controller.DeleteMonitor(textBox1.Text);
                MessageBox.Show("Data berhasil dihapus!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = controller.GetAllMonitors();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
        }
    }
}
