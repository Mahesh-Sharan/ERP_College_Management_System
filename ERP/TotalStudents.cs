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
    public partial class TotalStudents : Form
    {
        String str;
        
        
       
        SqlCommand cmd;
        SqlDataReader reader;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\ERP\ERP\erpDB.mdf;Integrated Security=True");
        public TotalStudents()
        {
            InitializeComponent();
        }
        

       
        private void TotalStudents_Load(object sender, EventArgs e)
        {
           
           
            // This line of code loads data into the 'studentCourse.TotalStudentsperCourse' table.
            this.totalStudentsperCourseTableAdapter.Fill(this.studentCourse.TotalStudentsperCourse);
            //  This line of code loads data into the 'erpDBDataSet1.StudentDB' table. 
            this.studentDBTableAdapter.Fill(this.erpDBDataSet1.StudentDB);

            //Grab Courses from StdentDB into ComboBox
            
            con.Open();
            str = "select course from StudentDB";
            cmd = new SqlCommand(str, con);
             reader = cmd.ExecuteReader();
            reader.Read();
            ComboBox1.Items.Add(reader["course"].ToString());
            reader.Close();
            con.Close();
           

            //Grab Values for TotalStudents Label
            con.Open();
            str = "select count(*)  from StudentDB";
            cmd = new SqlCommand(str, con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                studentTotal.Text=Convert.ToString(count.ToString());

            }
            else
            {
                studentTotal.Text = "0";
            }
                
    
            con.Close();



        }
        


      
        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin login = new AdminLogin();
            login.ShowDialog();
        }
      

        public void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Get Values in DataGrid using Combox Box Selections
            con.Open();

            str = "SELECT username,name, phone,email,year,gender From StudentDB WHERE course='" + ComboBox1.SelectedItem + "'";
            cmd = new SqlCommand(str, con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);

            guna2DataGridView1.DataSource = dt;
            reader.Close();
            con.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard login = new AdminDashboard();
            login.ShowDialog();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegister register = new StudentRegister();
            register.ShowDialog();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalTeachers teacher = new TotalTeachers();
            teacher.ShowDialog();
        }
    }
    }
