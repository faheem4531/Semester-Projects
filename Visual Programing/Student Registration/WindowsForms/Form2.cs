using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsForms
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5ELQTU\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        CrystalReport1 rpt = new CrystalReport1();

        public Form2()
        {
            InitializeComponent();
        }


        private void dB_connectivity()
        {
            try
            {
                con.Open();
                cmd.Connection = con;

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from StudentInfo",con);
                sda.Fill(dt);
                rpt.SetDataSource(dt);
                crystalReportViewer1.ReportSource = rpt;
                crystalReportViewer1.Refresh();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dB_connectivity();
        }
    }
}
