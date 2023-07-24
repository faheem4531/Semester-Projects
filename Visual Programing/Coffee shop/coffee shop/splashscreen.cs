using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar.Increment(2);
            if (progressBar.Value == 100)
            {
                timer1.Enabled = false;
               // Dashboard form = new Dashboard();
                registerationform form = new registerationform();
                form.Show();
                this.Hide();
            }
        }

        private void splashscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
