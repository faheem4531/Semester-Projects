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
    public partial class registerationform : Form
    {
        public registerationform()
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
               // MessageBox.Show("DB connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertDB()
        {
            try
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    cmd.CommandText = " insert into registeration(username,password) values ('" + txtusername.Text + "','" + txtpassword.Text + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your account has been successfullly created");
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtconfirmpassword.Clear();
                }
                else
                {
                    MessageBox.Show("Password does not match,Please re-enter");
                }
               
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
               if(checkBox1.Checked)
               {
                   txtpassword.PasswordChar = '\0';
                   txtconfirmpassword.PasswordChar = '\0';
               }
               else
               {
                   txtpassword.PasswordChar = '*';
                   txtconfirmpassword.PasswordChar = '*';
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
                txtconfirmpassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void registerationform_Load(object sender, EventArgs e)
        {
            DBconnectivity();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            insertDB();
            }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
             login form = new login();
                form.Show();
                this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkbox();
        }
        }
    }

