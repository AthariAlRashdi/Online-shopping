using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projecte
{
    public partial class login : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string strConnString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        string str;
        SqlCommand com;

        public login()
        {
            InitializeComponent();

           
            
               
            

        }

        private void button1_Click(object sender, EventArgs e)
        { if(txtUserName.Text=="Admin2023" && txtPassword.Text=="2023")
            {
                this.Hide();
                Admin A = new Admin();
                A.ShowDialog();
            }
            else if (txtUserName.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                string Email, Password;
                Email = this.txtUserName.Text.Trim();
                Password = this.txtPassword.Text.Trim();
                
                string strcon = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                SqlConnection con = new SqlConnection(strcon);
                string sqlLogin = "SELECT * FROM userregister WHERE Email =@Email AND Password =@Password ";

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }   
                {
                    SqlCommand CMD = new SqlCommand(sqlLogin, con);
                    CMD.Parameters.AddWithValue("@Email", Email);
                    CMD.Parameters.AddWithValue("@Password", Password);

                    SqlDataReader SR;

                    try
                    {
                        SR = CMD.ExecuteReader();
                        if (SR.Read())
                        {
                            
                            SetValueForText1 = txtUserName.Text;
                            //Close();
                            this.Hide();
                           Form1 form1 = new Form1();
                            form1.ShowDialog();
                            
                            Close();
                            SR.Close();
                        }

                       
                    }
                    catch (Exception ex)
                    {
                        this.labelshow.Text = ex.Message;
                    }

                    finally { con.Close();
                        MessageBox.Show("The userName OR Password combination you enterd does not correspond to registerd user ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }




                }
            }
           
             else 
            {
                //this.labelshow.Text = "The userName and Password combination you enterd does not correspond to registerd user ";
                MessageBox.Show("The userName and Password should not be Empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtPassword.Focus();
            }
          
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgetPassword ForgetPassword = new ForgetPassword();
            ForgetPassword.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registercs Registercs = new Registercs();
            Registercs.ShowDialog();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtUserName.Text.Length > 0) 
            {
                this.txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtPassword.Text.Length > 0)
            {
                this.button1.Focus();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
