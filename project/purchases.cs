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
using System.Windows.Forms;
{

}

namespace project
{
    public partial class purchases : Form
    {
        public purchases()
        {
            InitializeComponent();
        }

        private void purchases_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=MICROLENT\SQLEXPRESS;Initial Catalog=stone;Integrated Security=True"))
            using (var cmd = new SqlDataAdapter())
            using (var insertCommand = new SqlCommand(@"INSERT INTO [dbo].[stock] ([bill],[name],[address],[orderdate],[phno],[purchasedate],[itemname],[quantity],[itemprice],[total],[gstno],[subtotal],[vehicalno]) VALUES
      ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + textBox16.Text + "','" + textBox14.Text + "','" + textBox15.Text + "')"))
            {
                insertCommand.Connection = connection;
                cmd.InsertCommand = insertCommand;
                connection.Open();
                cmd.InsertCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(" Successful");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //set the connection string
            string connString = @"Data Source=MICROLENT\SQLEXPRESS;Initial Catalog=stone;Integrated Security=True";


            try
            {
                //sql connection object
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //retrieve the SQL Server instance version
                    string query = @"SELECT * FROM tblstock";

                    //define the SqlCommand object
                    SqlCommand cmd = new SqlCommand(query, conn);


                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    dataGridView1.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    dataGridView1.DataSource = ds.Tables[0];


                    //close connection
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                //display error message
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
