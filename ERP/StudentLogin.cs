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

namespace ERP
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        String constring = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\ERP\ERP\erpDB.mdf;Integrated Security=True");

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard frm = new Dashboard();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ForgotPswdMsg.Show();

        }
        
            private void LoginBT_Click(object sender, EventArgs e)
        {
            // SAVE CURRENT USER_ID TO TABLE
               con = new SqlConnection(constring);
               con.Open();
               cmd =new SqlCommand ("Update CurrentUSerID SET currentuserID= '"+idTB.Text+"' Where id=1",con);
            try
            {
                cmd.ExecuteNonQuery();
                CurrentuserID.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Not Updated");
            }
            finally
            {
                con.Close();
            }
            // LOGIN WITH FETCHING FROM StudentDB
            con = new SqlConnection(constring);
            con.Open();
            cmd = new SqlCommand("select * from StudentDB where username='" + idTB.Text + "' and password='" + passwordTB.Text + "'", con);
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    idTB.Text = dr["username"].ToString();
                    passwordTB.Text = dr["password"].ToString();
                    StudentProfille objFrmMain = new StudentProfille();
                    this.Hide();
                    objFrmMain.Show();
                }
                else
                {
                    Wrongpsswd.Show();
                    

                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Fill CORRECT INFORMATIONS");
            }
            finally
            {
                con.Close(); // close main connection here
            }
        }
        
      
    }
}
    

        

        
    
    

