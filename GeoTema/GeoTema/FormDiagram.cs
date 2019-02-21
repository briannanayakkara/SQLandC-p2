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
    public partial class FormDiagram : Form
    {
        public FormDiagram()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FormDiagram_Load(object sender, EventArgs e)
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
            DataView dv = dt.DefaultView;
            dv.Sort = "Birthrate DESC";
            chart1.DataSource = dv;
            chart1.Series["Series1"].XValueMember = "Country_Name";
            chart1.Series["Series1"].YValueMembers = "Birthrate";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;


            cnn.Close();
            
        }
    }
}
