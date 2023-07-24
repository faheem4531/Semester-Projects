using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class course : Form
    {
        public course()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-U5ELQTU\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True");
        public int CourseID;
       

        private void GetStudentsData()
        {

            SqlCommand cmd = new SqlCommand("Select * from course1", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridViewCourse.DataSource = dt;

           

        }

       
      


        private void Insert_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                SqlCommand cmd = new SqlCommand("Insert into course1 values(@coursecode,@coursetitle,@credithours)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@coursecode", textcoursecode.Text);
                cmd.Parameters.AddWithValue("@coursetitle", textcoursetitle.Text);
                cmd.Parameters.AddWithValue("@credithours", textcredithours.Text);
               

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Student is Successfully Saved in database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsData();
                ResetFormControls();
            }
        }



        private bool IsValid()
        {
            if (textcoursecode.Text == string.Empty)
            {
                MessageBox.Show("CourseCode is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void ResetFormControls()
        {

            textcoursecode.Clear();
            textcoursetitle.Clear();
            textcredithours.Clear();
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CourseID > 0)
            {
                SqlCommand cmd = new SqlCommand("update course1 set CourseCode=@coursecode,CourseTitle=@coursetitle,CreditHours=@credithour  where CourseID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@coursecode", textcoursecode.Text);
                cmd.Parameters.AddWithValue("@coursetitle", textcoursetitle.Text);
                cmd.Parameters.AddWithValue("@credithours", textcredithours.Text);
                cmd.Parameters.AddWithValue("@ID", this.CourseID);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Course Information is Updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsData();
                ResetFormControls();
            }else
            {
                MessageBox.Show("Please select a course to update his information", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CourseID > 0)
            {
                SqlCommand cmd = new SqlCommand("Delete from course1 where CourseID = @ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.CourseID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("course Information is deleted successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetStudentsData();
                ResetFormControls();

            }
            else
            {
                MessageBox.Show("Please select a course to delete his information", "delete?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void course_Load_1(object sender, EventArgs e)
        {
            GetStudentsData();
        }

        private void dataGridViewCourse_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CourseID = Convert.ToInt32(dataGridViewCourse.SelectedRows[0].Cells[0].Value);
            textcoursecode.Text = dataGridViewCourse.SelectedRows[0].Cells[1].Value.ToString();
            textcoursetitle.Text = dataGridViewCourse.SelectedRows[0].Cells[2].Value.ToString();
            textcredithours.Text = dataGridViewCourse.SelectedRows[0].Cells[3].Value.ToString();

        }
    }
}
