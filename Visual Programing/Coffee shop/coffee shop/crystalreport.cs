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

namespace coffee_shop
{
    public partial class crystalreport : Form
    {
        public crystalreport()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125;Initial Catalog=coffeeshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void DBconnectivity()
        {
            try
            {
                con.Open();
                cmd.Connection = con;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillreport()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Items", con);
                sda.Fill(dt);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void crystalreport_Load(object sender, EventArgs e)
        {
            DBconnectivity();
        }
    }
}
