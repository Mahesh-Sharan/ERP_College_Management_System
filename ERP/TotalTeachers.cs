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
    public partial class TotalTeachers : Form
    {
        public TotalTeachers()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard login = new AdminDashboard();
            login.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalStudents student = new TotalStudents();
            student.ShowDialog();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherRegister teacher = new TeacherRegister();
            teacher.ShowDialog();
        }
    }
    
    }

