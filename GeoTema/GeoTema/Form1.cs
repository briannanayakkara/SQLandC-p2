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

namespace GeoTema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString;
                SqlConnection cnn;

                connectionString = "Data Source = 10.0.5.109; database =GeoTema; User ID=Admin; Password=Passw0rd;";

                cnn = new SqlConnection(connectionString);

                cnn.Open();
                FormShowDatabaseAdmin F2 = new FormShowDatabaseAdmin();
                F2.Show();
                this.Hide();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        // disable the connect button
        private void textBox1User_TextChanged(object sender, EventArgs e)
        {
            if (textBox1User.Text == "Admin" && textBox2Pass.Text == "Passw0rd")
            {
                Connect.Enabled = true;
            }

            else
            {
                Connect.Enabled = false;
            }

        }

        private void textBox2Pass_TextChanged(object sender, EventArgs e)
        {
            if (textBox1User.Text == "Admin" && textBox2Pass.Text == "Passw0rd")
            {
                Connect.Enabled = true;
            }

            else
            {
                Connect.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2Pass.UseSystemPasswordChar = true;

        }

    }
}
