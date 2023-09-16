using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Data.SqlClient;
namespace projecte
{
    public partial class ForgetPassword : Form
    {
        String randomeCode;
        public static string to;
        MailMessage obj = new MailMessage();
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            string Email = string.Empty;
            string Password = string.Empty;
            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Email, [Password] FROM userregister WHERE Email = @Email"))
                {
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.Read())
                        {
                            Email = sdr["Email"].ToString();
                            Password = sdr["Password"].ToString();
                        }
                    }
                    con.Close();
                }
            }
            if (!string.IsNullOrEmpty(Password))
            {
                MailMessage mm = new MailMessage("sender@gmail.com", txtEmail.Text.Trim());
                mm.Subject = "Password Recovery";
                mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Appreciate your cooperation<br /><br\r\nKind Regards,<br />EFAH Team.", Email, Password);
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential();
                NetworkCred.UserName = "efah2023@gmail.com";
                NetworkCred.Password = "bxitpyyuuzunbsfv";
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Password has been sent to your email address.";

                MessageBox.Show("Maile was Sent To Your Email With Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                login login = new login();
                login.ShowDialog();
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "This email address does not match our records.";
            }
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == (int)Keys.Enter && this.txtEmail.Text.Length > 0))

            {
                this.button2.Focus();
            }
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
