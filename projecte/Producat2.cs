using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte
{
    public partial class Producat2 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public Producat2()
        {
            InitializeComponent();
        }

        private void buttonchoosecolor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;

                this.label6.Text.Normalize();
                label6.Text = str;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

            SqlCommand cmd = new SqlCommand("insertt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Size", SqlDbType.VarChar, 100);
            cmd.Parameters["@Size"].Value = this.comboBox1.SelectedItem;
            string Email = login.SetValueForText1;
            cmd.Parameters.Add("@Color", SqlDbType.VarChar, 100);
            cmd.Parameters["@Color"].Value = this.label6.Text;
            cmd.Parameters.AddWithValue("@Email", login.SetValueForText1);
            string price, ID;
            price = this.labelnoprice.Text.Trim();
            ID = this.label8.Text.Trim();
            cmd.Parameters.AddWithValue("@Price", price);
            ID = this.label8.Text.Trim();
            cmd.Parameters.AddWithValue("@ID", ID);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();


            this.labeshow.Text = "Saved Complted Successfully ";

            if (login.SetValueForText1 != string.Empty)
            {

                Email = login.SetValueForText1.Trim();

                string strcon = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

                string sqlLogin = "SELECT * FROM userregister WHERE Email =@Email";

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                {
                    SqlCommand CMD = new SqlCommand(sqlLogin, con);
                    CMD.Parameters.AddWithValue("@Email", login.SetValueForText1);

                    SqlDataReader SR;

                    try
                    {
                        SR = CMD.ExecuteReader();
                        if (SR.Read())
                        {
                            SetValueForText1 = comboBox1.Text;

                            SetValueForText2 = label6.Text;
                            SetValueForText5 = label8.Text;
                            SetValueForText4 = labelnoprice.Text;
                            this.Hide();
                            PaymentProducat2 fm = new PaymentProducat2();
                            fm.ShowDialog();
                            SR.Close();
                        }
                        else
                        {
                            this.labeshow.Text = "Invalid Email!Forget Your Password Or Sing-up ";

                        }
                    }
                    catch (Exception ex)
                    {
                        this.labeshow.Text = ex.Message;
                    }
                    finally { con.Close(); }


                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.ShowDialog();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (int)Keys.Enter && this.comboBox1.Text.Length > 0)
            {
                this.buttonchoosecolor.Focus();
            }
        }

        private void buttonchoosecolor_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (int)Keys.Enter && this.buttonchoosecolor.Text.Length > 0)
            {
                this.button1.Focus();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

