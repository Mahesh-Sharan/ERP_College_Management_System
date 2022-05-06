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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.label1.Text = datetime.ToString();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Stop()
;           this.Hide();
            StudentLogin frm1 = new StudentLogin();
            frm1.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin admin = new AdminLogin();
            admin.Show();
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Needhelp.Show();
        }
    }
}
