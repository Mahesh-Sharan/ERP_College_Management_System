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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void LoginBT_Click(object sender, EventArgs e)
        {
           
            
                String username = "dheeraj";
                String password = "12345";

                if ((idTB.Text == username) && (passwordTB.Text == password))
                {
                    this.Hide();
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show(); this.Hide();
                 }
            
            else if (idTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("Please Provide ID & Password");

            }
            else
            {
                Wrongpsswd.Show();
            }
        }

        private void BackBT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
        }
    

