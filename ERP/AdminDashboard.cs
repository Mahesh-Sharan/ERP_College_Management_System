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
using System.IO;

namespace ERP
{
    public partial class AdminDashboard : Form
    {
        String str;



        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\ERP\ERP\erpDB.mdf;Integrated Security=True");
        public AdminDashboard()
        {
            InitializeComponent();
        }


        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin form = new AdminLogin();
            form.Show();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalStudents form1 = new TotalStudents();
            form1.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            //Display Total Students
            con.Open();
            str = "select count(*)  from StudentDB";
            cmd = new SqlCommand(str, con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                studentTotal.Text = Convert.ToString(count.ToString());
                StudentPB.Value = Int32.Parse(studentTotal.Text);

            }
            else
            {
                studentTotal.Text = "0";
            }


            con.Close();

            //Display Total Teachers
            con.Open();
            str = "select count(*)  from TeacherDB";
            cmd = new SqlCommand(str, con);
            Int32 count1 = Convert.ToInt32(cmd.ExecuteScalar());
            if (count1 > 0)
            {
               TeacherTotal.Text = Convert.ToString(count1.ToString());
                TeacherPB.Value = Int32.Parse(TeacherTotal.Text);

            }
            else
            {
                TeacherTotal.Text = "0";
            }


            con.Close();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalTeachers form2 = new TotalTeachers();
            form2.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalStudents student = new TotalStudents();
            student.ShowDialog();
        }
    }
}
