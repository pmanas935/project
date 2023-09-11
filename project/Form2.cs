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
     string email = " ^[a-z0-9,!#\\$%&'\\*\\+/=\\?\\^_`\\{\\|}~-]+(\\.[a-z0-9,!#\\$%&'\\*\\+/=\\?\\^_`\\{\\|}~-]+)*@[a-z0-9-]+(\\.[a-z0-9-]+)*\\.([a-z]{2,})[ ]?:.*$";
 string password = "^.*(?=.{8,})(?=.*[a-zA-Z])(?=.*\\d)(?=.*[!#$%&? \"]).*$";
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
        private void textBox1_Leave(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(textBox1.Text) == true)
    {
        textBox1.Focus();
        errorProvider1.SetError(this.textBox1, "Fill your first name!");
    }
    else
    {
        errorProvider1.Clear();
    }
}
private void textBox2_TextChanged(object sender, EventArgs e)
{

}
private void textBox2_Leave(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(textBox2.Text) == true)
    {
        textBox2.Focus();
        errorProvider2.SetError(this.textBox2, "Fill your last name!");
    }
    else
    {
        errorProvider2.Clear();
    }
}
private void textBox3_Leave(object sender, EventArgs e)
{

    if (string.IsNullOrEmpty(textBox3.Text) == true)
    {
        textBox3.Focus();
        errorProvider3.SetError(this.textBox3, "Fill your company name");
    }
    else
    {
        errorProvider3.Clear();
    }
}
private void textBox4_Leave(object sender, EventArgs e)
{
    if (string.IsNullOrEmpty(textBox4.Text) == true)
    {
        textBox4.Focus();
        errorProvider4.SetError(this.textBox4, "Fill your Contact no!");
    }
    else
    {
        errorProvider4.Clear();
    }
}
private void textBox5_Leave(object sender, EventArgs e)
{

    if (Regex.IsMatch(textBox5.Text, email) == false)
    {
        textBox5.Focus();
        errorProvider5.SetError(this.textBox5, "fill your email");
    }
    else
    {
        errorProvider5.Clear();
    }
}
private void textBox6_Leave(object sender, EventArgs e)
{

    if (Regex.IsMatch(textBox6.Text, password) == false)
    {
        textBox6.Focus();
        errorProvider6.SetError(this.textBox6, "fill your password");
    }
    else
    {
        errorProvider6.Clear();
    }
}
private void textBox7_Leave(object sender, EventArgs e)
{
    if (textBox6.Text != textBox7.Text)
    {
        textBox7.Focus();
        errorProvider7.SetError(this.textBox7, "password is match");
    }
    else
    {
        errorProvider7.Clear();
    }
}
         private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
 {
     char ch = e.KeyChar;
     if (char.IsLetter(ch) == true)
     {
         e.Handled = false;
     }
     else
     {
         e.Handled = true;
     }
 }
 private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
 {
     char ch = e.KeyChar;
     if (char.IsLetter(ch) == true)
     {
         e.Handled = false;
     }

     else
     {
         e.Handled = true;
     }
 }

 private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
 {
     char ch = e.KeyChar;
     if (char.IsLetter(ch) == true)
     {
         e.Handled = false;
     }
     else
     {
         e.Handled = true;
     }
 }

 private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
 {
     char ch = e.KeyChar;
     if (char.IsDigit(ch) == true)
     {
         e.Handled = false;
     }

     else
     {
         e.Handled = true;
     }
 }
    }
}
