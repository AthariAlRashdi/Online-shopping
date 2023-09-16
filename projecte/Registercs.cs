using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte
{
    public partial class Registercs : Form
    {
        public static string SetValueForText1 = "";
        public Registercs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(textBox5.Text.Trim());
            if (isValid)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

                SqlCommand cmd = new SqlCommand("insertINTOuserregister", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 100);
                cmd.Parameters["@FirstName"].Value = this.textBox1.Text;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100);
                cmd.Parameters["@Email"].Value = this.textBox5.Text;
                cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 100);
                cmd.Parameters["@LastName"].Value = this.textBox2.Text;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar, 100);
                cmd.Parameters["@Password"].Value = this.textBox4.Text;
                cmd.Parameters.Add("@Address", SqlDbType.VarChar, 100);
                cmd.Parameters["@Address"].Value = this.textBox7.Text;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 100);
                cmd.Parameters["@Phone"].Value = this.textBox3.Text;


                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                SetValueForText1 = textBox1.Text;
                this.messageParagraph.Text = "Registerd Complted Successfully ";

                this.Hide();
                login login = new login();
                login.ShowDialog();
            }
            if (!isValid )
            {
                MessageBox.Show("Invalid Email.!");
            }
            
               

            
        }

        private void Registercs_Load(object sender, EventArgs e)
        {

        }

        private void messageParagraph_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.textBox1.Text.Length > 0)
            {
                this.textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.textBox2.Text.Length > 0)
            {
                this.textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.textBox3.Text.Length > 0)
            {
                this.textBox7.Focus();
            }

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.textBox7.Text.Length > 0)
            {
                this.textBox5.Focus();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.textBox5.Text.Length > 0)
            {
                this.textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

           
            //We only want to allow numeric style chars
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox3.Text = textBox3.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox2.Text.Remove(textBox2.Text.Length - 1);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}