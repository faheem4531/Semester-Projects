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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5ELQTU\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True");
        public int PaymentID;
       
        private void GetPaymentData()
        {
            SqlCommand cmd = new SqlCommand("Select * from payment1", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewpayment.DataSource = dt;


        }

       

        private void payment_Load(object sender, EventArgs e)
        {
            GetPaymentData();
        }

        private void dataGridViewpayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PaymentID = Convert.ToInt32(dataGridViewpayment.SelectedRows[0].Cells[0].Value);
            texts1.Text = dataGridViewpayment.SelectedRows[0].Cells[1].Value.ToString();
            texts2.Text = dataGridViewpayment.SelectedRows[0].Cells[2].Value.ToString();
          
            textp.Text = dataGridViewpayment.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into payment1 values(@subject1,@subject2,@payment)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@subject1", texts1.Text);
                cmd.Parameters.AddWithValue("@subject2", texts2.Text);
               
                cmd.Parameters.AddWithValue("@payment", textp.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Subject is Successfully Saved in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetPaymentData();
                ResetFormControls();
            }
        }

        private bool IsValid()
        {
            if (texts1.Text == string.Empty)
            {
                MessageBox.Show("subject1 is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ResetFormControls()
        {

            texts1.Clear();
            texts2.Clear();
          
            textp.Clear();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (PaymentID > 0)
            {
                SqlCommand cmd = new SqlCommand("update payment1 set Subject1=@subject1,Subject2=@subject2,Payment=@payment  where PaymentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@subject1", texts1.Text);
                cmd.Parameters.AddWithValue("@subject2", texts2.Text);
               
                cmd.Parameters.AddWithValue("@payment", textp.Text);
                cmd.Parameters.AddWithValue("@ID", this.PaymentID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("payment Information is Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetPaymentData();
                ResetFormControls();
            }
            else
            {
                MessageBox.Show("Please select a subject to update his information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (PaymentID > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete from payment1 where PaymentID = @ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.PaymentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Subject Information is deleted successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetPaymentData();
                ResetFormControls();

            }
            else
            {
                MessageBox.Show("Please select a subject to delete his information", "delete?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
