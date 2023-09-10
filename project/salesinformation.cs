using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class salesinformation : Form
    {
        public salesinformation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-IR2US1VL\SQLEXPRESS01;Initial Catalog=stone;Integrated Security=True"))
            using (var cmd = new SqlDataAdapter())
            using (var insertCommand = new SqlCommand(@"INSERT INTO [dbo].[sales] ([bill no],[name],[address],[order date],[delivery date],[driver name],[gaddi no],[gst no],[item no],[quantity],[item price],[total]) VALUES
      ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox16.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')"))
            {
                insertCommand.Connection = connection;
                cmd.InsertCommand = insertCommand;
                connection.Open();
                cmd.InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(" Successful");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
