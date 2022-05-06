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

    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }


        public String imgloc;

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void SignupBG_Click(object sender, EventArgs e)
        {

        }



        public String CurrentUSerID;

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

            //Main code 
            if (license_checkbox.Checked == false)
            {
                MessageBox.Show("Please Accept License & Policy");
            }
            else if (Rid.Text == "" || Rpassword.Text == "" || Rphone.Text == "" || Rfather.Text == "" || Rmother.Text == "" || Ryear.Text == "" || Rmarks.Text == "")
            {
                MessageBox.Show("Please fil all Entries");
            }
            else
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs); 
                img =br.ReadBytes((int)fs.Length);  

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\ERP\ERP\erpDB.mdf;Integrated Security=True");
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "Insert into StudentDB (username,password,phone,father,mother,year,marks,dob,course,gender,name,studentImg) values (@username,@password,@phone,@father,@mother,@year,@marks,@dob,@course,@gender,@name,@studentImg)";

                cmd.Parameters.AddWithValue("@username", this.Rid.Text);
                cmd.Parameters.AddWithValue("@password", this.Rpassword.Text);
                cmd.Parameters.AddWithValue("@phone", this.Rphone.Text);
                cmd.Parameters.AddWithValue("@mother", this.Rmother.Text);
                cmd.Parameters.AddWithValue("@father", this.Rfather.Text);
                cmd.Parameters.AddWithValue("@year", this.Ryear.Text);
                cmd.Parameters.AddWithValue("@marks", this.Rmarks.Text);
                cmd.Parameters.AddWithValue("@dob", DOB.Value.ToShortDateString()); // Add Values from DateTimePicker to Sql Database
                cmd.Parameters.AddWithValue("@name", this.Rname.Text);
                cmd.Parameters.AddWithValue("@studentImg",img);
                cmd.Parameters.AddWithValue("@course", this.courseCB.SelectedItem.ToString());
                if (maleRB.Checked)
                    cmd.Parameters.AddWithValue("@gender", "Male");
                else if (femaleRB.Checked)
                    cmd.Parameters.AddWithValue("@gender", "Female");

                try
                {
                    con.Open(); // Open Connection
                    cmd.ExecuteNonQuery();
                    successful.Show();
                    this.Hide();
                    StudentLogin login = new StudentLogin();
                    login.ShowDialog();

                }
               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close(); // Close the connection
                }
            }

        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit(); }

        private void uploadimg_Click(object sender, EventArgs e)
        {
            
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
                dlg.Title = "Select Student Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    MessageBox.Show("Profile Photo Updated");
                }


                
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentLogin login = new StudentLogin();
            login.ShowDialog();
        }
    }
    }
   
    

