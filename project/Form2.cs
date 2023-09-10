using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Drawing;
using System;
using System.Data.SqlClient;

namespace project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3BKFBOP\SQLEXPRESS;Initial Catalog=stone;Integrated Security=True");
                //                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[registraion]

                //      ([firstname]
                //      ,[lastname]
                //      ,[companyname]
                //      ,[contactnumber]
                //      ,[email]
                //      ,[username]
                //      ,[password])
                //VALUES
                //      ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')");
                //                con.Open();
                //                cmd.ExecuteNonQuery();
                //                con.Close();
                //                MessageBox.Show("Register Successful");


                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3BKFBOP\SQLEXPRESS;Initial Catalog=stone;Integrated Security=True"))
                using (var cmd = new SqlDataAdapter())
                using (var insertCommand = new SqlCommand(@"INSERT INTO [dbo].[registration] ([firstname],[lastname],[companyname],[contactnumber],[email],[username],[password]) VALUES
      ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')"))
                {
                    insertCommand.Connection = connection;
                    cmd.InsertCommand = insertCommand;
                    connection.Open();
                    cmd.InsertCommand.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Register Successful");
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salesinformation frm2 = new salesinformation();
            frm2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purchases frm3 = new purchases();
            frm3.Show();
            this.Hide();
        }
    }
}
