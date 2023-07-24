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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125;Initial Catalog=coffeeshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        string SN;

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

        private void combofillcoffee()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from coffee", con);
                sda.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "coffee_name";
                comboBox1.ValueMember = "coffee_price";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectDBcoffee()
        {
            try
            {
                cmd.CommandText = " select coffee_price  from coffee where coffee_name= '" + comboBox1.Text + "'";
                SN = Convert.ToString(cmd.ExecuteScalar());
                textprice.Text = SN;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void combofilldesert()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter("select * from desert", con);
                sda.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "desert_name";
                comboBox1.ValueMember = "desert_price";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectDBdesert()
        {
            try
            {
                cmd.CommandText = " select desert_price  from desert where desert_name= '" + comboBox1.Text + "'";
                SN = Convert.ToString(cmd.ExecuteScalar());
                textprice.Text = SN;

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
                for (int i = 0; i<dataGridView1.Rows.Count ;i++ )
                {
                    cmd.CommandText = "insert into Items values('" + dataGridView1.Rows[i].Cells[0].Value + "' , '" + dataGridView1.Rows[i].Cells[1].Value + "' , '" + dataGridView1.Rows[i].Cells[2].Value + "' , '" + dataGridView1.Rows[i].Cells[3].Value + "' , '" + dataGridView1.Rows[i].Cells[4].Value + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfull insert data");
                }                                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(COFFEE.Checked==true)
            {                     
                selectDBcoffee();
            }
        
            else
            {
                 selectDBdesert();
            }
          

            /*if (comboBox1.SelectedItem.ToString() == "Cappuccino")
            {
                textprice.Text = "850";
            }
            else if (comboBox1.SelectedItem.ToString() == "Mocha")
            {
                textprice.Text = "340";
            }
            else if (comboBox1.SelectedItem.ToString() == "Affogato")
            {
                textprice.Text = "350";
            }
            else if (comboBox1.SelectedItem.ToString() == "Cold Coffee")
            {
                textprice.Text = "250";
            }
            else if (comboBox1.SelectedItem.ToString() == "Latte")
            {
                textprice.Text = "350";
            }
            else if (comboBox1.SelectedItem.ToString() == "Tea")
            {
                textprice.Text = "150";
            }
            else if (comboBox1.SelectedItem.ToString() == "Black Coffee")
            {
                textprice.Text = "200";
            }
            else if (comboBox1.SelectedItem.ToString() == "Espresso")
            {
                textprice.Text = "300";
            }
            else if (comboBox1.SelectedItem.ToString() == "Brownie")
            {
                textprice.Text = "600";
            }
            else if (comboBox1.SelectedItem.ToString() == "LavaCake")
            {
                textprice.Text = "700";
            }
            else if (comboBox1.SelectedItem.ToString() == "Donuts")
            {
                textprice.Text = "400";
            }
            else if (comboBox1.SelectedItem.ToString() == "RedVelvet Cake")
            {
                textprice.Text = "650";
            }
            else if (comboBox1.SelectedItem.ToString() == "Chocolate Cake")
            {
                textprice.Text = "500";
            }
            else if (comboBox1.SelectedItem.ToString() == "Pudding")
            {
                textprice.Text = "450";
            }
            else if (comboBox1.SelectedItem.ToString() == "Ice Cream")
            {
                textprice.Text = "300";
            }
            else if (comboBox1.SelectedItem.ToString() == "Apple Pie")
            {
                textprice.Text = "450";
            }
            else
            {
                textprice.Text = "0";
            }*/
            textQuantity.Text = "";
            textAmount.Text = "";
        }

        private void textprice_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DBconnectivity();
        }

        private void COFFEE_CheckedChanged(object sender, EventArgs e)
        {

            combofillcoffee();



            COFFEE.ForeColor = System.Drawing.Color.BlueViolet;
            DESSERTS.ForeColor = System.Drawing.Color.RosyBrown;
          
            /*comboBox1.Items.Add("Cappuccino");
            comboBox1.Items.Add("Mocha");
            comboBox1.Items.Add("Affogato");
            comboBox1.Items.Add("Cold Coffee");
            comboBox1.Items.Add("Latte");
            comboBox1.Items.Add("Tea");
            comboBox1.Items.Add("Black Coffee");
            comboBox1.Items.Add("Espresso");*/

        }

        private void DESSERTS_CheckedChanged(object sender, EventArgs e)
        {

            combofilldesert();

            COFFEE.ForeColor = System.Drawing.Color.RosyBrown;
            DESSERTS.ForeColor = System.Drawing.Color.BlueViolet;
           /* comboBox1.Items.Clear();
            comboBox1.Items.Add("Brownie");
            comboBox1.Items.Add("LavaCake");
            comboBox1.Items.Add("Donuts");
            comboBox1.Items.Add("RedVelet Cake");
            comboBox1.Items.Add("Cheese Cake");
            comboBox1.Items.Add("Chocolate Cake");
            comboBox1.Items.Add("Ice Cream");
            comboBox1.Items.Add("Apple Pie");*/

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Add data to dataGridView
            dataGridView1.Rows.Add(comboBox1.Text, textprice.Text, textQuantity.Text, textAmount.Text, dateTimePicker.Text);
            //Sum Amount
            texttotalamount.Text = (Convert.ToInt16(texttotalamount.Text) + Convert.ToInt16(textAmount.Text)).ToString();
            //clear data
            textprice.Text = "";
            textQuantity.Text = "";
            textAmount.Text = "";
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //delete data from datagridview
            if(dataGridView1.SelectedRows.Count>0)
            {
                for(int i=0; i< dataGridView1.Rows.Count;i++)
                {
                    if(dataGridView1.Rows[i].Selected)
                    {
                        texttotalamount.Text = (Convert.ToInt16(texttotalamount.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }

        private void textpaylamount_TextChanged(object sender, EventArgs e)
        {
            if(textpaylamount.Text.Length>0)
            {
                textrepaylamount.Text = (Convert.ToInt16(texttotalamount.Text) - Convert.ToInt16(textpaylamount.Text)).ToString();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            texttotalamount.Text = "0";
            textpaylamount.Text = "";
            textrepaylamount.Text = "";

        }

        private void buttonsave_Click(object sender, EventArgs e)
        {
            insertDB();
        }

        private void buttonload_Click(object sender, EventArgs e)
        {
            load form = new load();
            form.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textQuantity_TextChanged(object sender, EventArgs e)
        {
            if (textQuantity.Text.Length > 0)
            {
                textAmount.Text = (Convert.ToInt64(textprice.Text) * Convert.ToInt64(textQuantity.Text)).ToString();
            }
        }
    }
}
