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
    public partial class FormShowDatabaseAdmin : Form
    {
        public FormShowDatabaseAdmin()
        {
            InitializeComponent();
            DisplayData();
        }

 
        public void DisplayData()
        {
            SqlCommand scmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            String sql, connetionSrting;
            SqlConnection cnn = new SqlConnection();
            DataTable dt = new DataTable();

            connetionSrting = "Data Source = 10.0.5.109; database =GeoTema; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();
            sda = new SqlDataAdapter("select Country.ID, Country.Country_Name, Country.Continent, Ranks.Ranks, Ranks.Birthrate from Country inner join Ranks on Country.ID = Ranks.ID", cnn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               
        }

        // Gain access to admin user 

        private void Admin_login_Click(object sender, EventArgs e)
        {
            
            SqlCommand scmd = new SqlCommand();
          
            String sql, connetionSrting;
            SqlConnection cnn = new SqlConnection();
            DataTable dt = new DataTable();
            connetionSrting = "Data Source = 10.0.5.109; database =GeoTema; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();

            string query = "select * from AdminUser Where UserId = '"+ textBoxUserID.Text + "' and Pass = '" + textBoxPassw0rd.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                textBoxSearch.Enabled = true;
                buttonDiagram.Enabled = true;
            }
            else
            {
                textBoxSearch.Enabled = false;
                buttonDiagram.Enabled = false;
                MessageBox.Show("Check user name or password");
            }
            cnn.Close();
        }

        // Gain access to super user 

        private void Super_login_Click(object sender, EventArgs e)
        {
            SqlCommand scmd = new SqlCommand();

            String sql, connetionSrting;
            SqlConnection cnn = new SqlConnection();
            DataTable dt = new DataTable();
            connetionSrting = "Data Source = 10.0.5.109; database =GeoTema; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();

            string query = "select * from SuperUser Where UserId = '" + textBoxUserID.Text + "' and Pass = '" + textBoxPassw0rd.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                textBoxSearch.Enabled = true;
                buttonDiagram.Enabled = true;
            }
            else
            {
                textBoxSearch.Enabled = false;
                buttonDiagram.Enabled = false;
                MessageBox.Show("Check user name or password");
            }
            cnn.Close();
        }

        // Gain accress to standed user 

        private void Standed_login_Click(object sender, EventArgs e)
        {
            SqlCommand scmd = new SqlCommand();

            String sql, connetionSrting;
            SqlConnection cnn = new SqlConnection();
            DataTable dt = new DataTable();
            connetionSrting = "Data Source = 10.0.5.109; database =GeoTema; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();

            string query = "select * from StandedUser Where UserId = '" + textBoxUserID.Text + "' and Pass = '" + textBoxPassw0rd.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                buttonDiagram.Enabled = false;
                textBoxSearch.Enabled = true;
            }
            else
            {
                textBoxSearch.Enabled = false;
                buttonDiagram.Enabled = false;
                MessageBox.Show("Check user name or password");
            }
            cnn.Close();
        }

        // enabeling the buttons 
        private void textBoxUserID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "" || textBoxPassw0rd.Text == "")
            {
                Admin_login.Enabled = false;
                Super_login.Enabled = false;
                Standed_login.Enabled = false;
            }

            else
            {
                Admin_login.Enabled = true;
                Super_login.Enabled = true;
                Standed_login.Enabled = true;
            }
        }
        private void textBoxPassw0rd_TextChanged(object sender, EventArgs e)
        {

            if (textBoxUserID.Text == "" || textBoxPassw0rd.Text == "")
            {
                Admin_login.Enabled = false;
                Super_login.Enabled = false;
                Standed_login.Enabled = false;
            }

            else
            {
                Admin_login.Enabled = true;
                Super_login.Enabled = true;
                Standed_login.Enabled = true;
            }
        }

        // search box
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand scmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter();
            String sql, connetionSrting;
            SqlConnection cnn = new SqlConnection();
            DataTable dt = new DataTable();

            connetionSrting = "Data Source = 10.0.5.109; database =GeoTema; User ID=Admin; Password=Passw0rd;";
            cnn = new SqlConnection(connetionSrting);
            cnn.Open();
            sda = new SqlDataAdapter("select Country.ID, Country.Country_Name, Country.Continent, Ranks.Ranks, Ranks.Birthrate from Country inner join Ranks on Country.ID = Ranks.ID where Country_Name like'%"+ textBoxSearch.Text +"%'", cnn);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        // Diagram button
        private void buttonDiagram_Click(object sender, EventArgs e)
        {
            FormDiagram Diagram = new FormDiagram();
            Diagram.Show();
        }

        private void FormShowDatabaseAdmin_Load(object sender, EventArgs e)
        {
            textBoxPassw0rd.UseSystemPasswordChar = true;
        }
    }
}
