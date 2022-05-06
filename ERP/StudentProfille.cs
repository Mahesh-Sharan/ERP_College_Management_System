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
    public partial class StudentProfille : Form
    {
        public StudentProfille()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private void StudentProfille_Load(object sender, EventArgs e)
        {
            String str;
          
            

            SqlCommand cmd;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\ERP\ERP\erpDB.mdf;Integrated Security=True");
            con.Open();
            //Grab CurrentUSerID info
            str = "select * from CurrentUSerID Where id=1";
            cmd = new SqlCommand(str, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            idLB.Text = reader["currentuserID"].ToString();
            reader.Close();
            con.Close();

            //Execute  grab from studentDB

            con.Open();
            str = "Select * from StudentDB WHERE  username='" + idLB.Text.Trim() + "'";


            cmd = new SqlCommand(str,con) ;
            reader = cmd.ExecuteReader();
            reader.Read();
            idLB.Text=reader["username"].ToString();
            nameLB.Text = reader["name"].ToString();
            phLB.Text = reader["phone"].ToString();
            fatherLB.Text = reader["father"].ToString();
            motherLB.Text = reader["mother"].ToString();
            dobLB.Text = reader["dob"].ToString();
            courseLB.Text = reader["course"].ToString();
            markLB.Text = reader["marks"].ToString();
            yearLB.Text = reader["year"].ToString();
            emailLB.Text = reader["email"].ToString();
            byte[] img = (byte[])(reader["studentImg"]);  
            if (img == null)
                profilebox.Image = null;
            else
            {
                MemoryStream ms = new MemoryStream(img);
                profilebox.Image = Image.FromStream(ms);


            }
            reader.Close();

            con.Close(); // close main connection
                    }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin login = new StudentLogin();
            login.Show();
            

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin login = new StudentLogin();
            login.Show();
        }

       
    }
            }




        
               
       

