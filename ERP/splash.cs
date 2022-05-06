using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2ProgressBar1.Increment(1);
            if (guna2ProgressBar1.Value == 30)
            {
                label1.Visible = true;
            }

            if (guna2ProgressBar1.Value == 55)
            {
                label2.Visible = true;
            }

            if (guna2ProgressBar1.Value == 85)
            {
                label3.Visible = true;
            }
            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Dashboard frm = new Dashboard();
                frm.Show();
                

            }

        }

        private void splash_Load(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value = 0;
            label1.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
