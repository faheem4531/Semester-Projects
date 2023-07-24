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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125;Initial Catalog=coffeeshop;Integrated Security=True");
            SqlCommand cmd= new SqlCommand();

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

            private void selectDB()
            {
                try
                {
                    cmd.CommandText = " select * from registeration where username= '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'";
                   // cmd.ExecuteNonQuery();
                    SqlDataReader dr=cmd.ExecuteReader();

                    if(dr.Read() == true)
                    {
                          MessageBox.Show("Your account has been successfullly loged in");
                          Dashboard form = new Dashboard();
                          form.Show();
                          this.Hide();                      
                    }
                    else
                    {
                          MessageBox.Show("Invalid username or password,Please try again");
                          txtusername.Clear();
                          txtpassword.Clear();                     
                    }
                          dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void checkbox()
            {
                try
                {
                    if (checkBox1.Checked)
                    {
                        txtpassword.PasswordChar = '\0';                     
                    }
                    else
                    {
                        txtpassword.PasswordChar = '*';                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void clear()
            {
                try
                {
                    txtusername.Clear();
                    txtpassword.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void login_Load(object sender, EventArgs e)
        {
            DBconnectivity();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            selectDB();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkbox();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            registerationform form = new registerationform();
            form.Show();
            this.Hide();
        }
    }
}
