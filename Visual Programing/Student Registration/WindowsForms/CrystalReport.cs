using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsForms
{
    public partial class CrystalReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5ELQTU\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public CrystalReport()
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 to = new  Form2();
            to.Show();
        }

        private void CrystalReport_Load(object sender, EventArgs e)
        {
            dB_connectivity();
        }
    }
}
