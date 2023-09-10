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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
       SqlConnection conn=new SqlConnection(@"Data Source=DESKTOP-3BKFBOP\SQLEXPRESS;Initial Catalog=stone;Integrated Security=True");




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username,password;

            username = textBox1.Text;
            password=textBox2.Text;

            try
            {
                string querry = "select * from registration where username ='" + textBox1.Text + "'  AND password ='" + textBox2.Text + "'";
                SqlDataAdapter sda=new SqlDataAdapter(querry,conn);
                

                DataTable dtable=new DataTable();
                sda.Fill(dtable);


                if (dtable.Rows.Count>0)
                {
                    username = textBox1.Text;
                    password= textBox2.Text;

                    Form2 frm2 = new Form2();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaild login deails","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();

                
                }

            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            { 
                conn.Close();
            }

            //if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            //{
            //    errorProvider2.SetError(textBox1, "username is required");
            //    return;
            //}
            //else
            //{
            //    errorProvider1.SetError(textBox1, string.Empty);
            //}
            //if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            //{
            //    errorProvider2.SetError(textBox2, "Password is required");
            //    return;
            //}
            //else
            //{
            //    errorProvider2.SetError(textBox2, string.Empty);
            //}
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}