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
    public partial class TeacherRegister : Form
    {
        public String imgloc;
        public TeacherRegister()
        {
            InitializeComponent();
        }

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

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //Main code 
            if (license_checkbox.Checked == false)
            {
                MessageBox.Show("Please Accept License & Policy");
            }
            else if (Rname.Text == "" || Rpassword.Text == "" || Rphone.Text == "" || Rage.Text == "" || Remail.Text == "")
            {
                MessageBox.Show("Please fil all Entries");
            }
            else
            {
                 
                    byte[] img = null;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\ERP\ERP\erpDB.mdf;Integrated Security=True");
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "Insert into TeacherDB (Age,Password,Phone,DOB,Gender,Name,TeacherImg,Email,Qualification) values (@age,@Password,@Phone,@DOB,@Gender,@Name,@TeacherImg,@Email,@Qualification)";

                    cmd.Parameters.AddWithValue("@age", this.Rage.Text);
                    cmd.Parameters.AddWithValue("@Password", this.Rpassword.Text);
                    cmd.Parameters.AddWithValue("@Phone", this.Rphone.Text);
                    cmd.Parameters.AddWithValue("@Email", this.Remail.Text);
                    cmd.Parameters.AddWithValue("@DOB", DOB.Value.ToShortDateString()); // Add Values from DateTimePicker to Sql Database
                    cmd.Parameters.AddWithValue("@name", this.Rname.Text);
                    cmd.Parameters.AddWithValue("@TeacherImg", img);
                    cmd.Parameters.AddWithValue("@Qualification", this.QualificationCB.SelectedItem.ToString());
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
                        Dashboard dash = new Dashboard();
                        dash.ShowDialog();

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
        }
    }


