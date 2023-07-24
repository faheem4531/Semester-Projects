using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5ELQTU\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True");


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textusername.Text=="admin" && textpassword.Text=="admin")
            {
                new Main().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                textusername.Clear();
                textpassword.Clear();
                textusername.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
