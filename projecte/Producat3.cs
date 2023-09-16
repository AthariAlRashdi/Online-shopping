using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte
{
    public partial class Producat3 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        public static string SetValueForText5 = "";
        public Producat3()
        {
            InitializeComponent();
        }

        private void bttbChooesColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string str = null;
                str = dlg.Color.Name;
               
                this.label7.Text.Normalize();
                label7.Text = str;
            }

        }

        private void Producat3_Load(object sender, EventArgs e)
        {

        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;

            SqlCommand cmd = new SqlCommand("insertt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Size", SqlDbType.VarChar, 100);
            cmd.Parameters["@Size"].Value = this.comboBox1.SelectedItem;
            string Email = login.SetValueForText1;
            cmd.Parameters.Add("@Color", SqlDbType.VarChar, 100);
            cmd.Parameters["@Color"].Value = this.label7.Text;
            cmd.Parameters.AddWithValue("@Email", login.SetValueForText1);
            string price, ID;
            price = this.labelnoprice.Text.Trim();
            ID = this.labelnoprice.Text.Trim();
            cmd.Parameters.AddWithValue("@Price", price);
            ID = this.labelnoprice.Text.Trim();
            cmd.Parameters.AddWithValue("@ID", ID);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();


            this.labelshow.Text = "Saved Complted Successfully ";

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

                            SetValueForText2 = label7.Text;
                            SetValueForText5 = label10.Text;
                            SetValueForText4 = labelnoprice.Text;
                            this.Hide();
                            PaymentProducat3cs fm = new PaymentProducat3cs();
                            fm.ShowDialog();
                            SR.Close();
                        }
                        else
                        {
                            this.labelshow.Text = "Invalid Email!Forget Your Password Or Sing-up ";

                        }
                    }
                    catch (Exception ex)
                    {
                        this.labelshow.Text = ex.Message;
                    }
                    finally { con.Close(); }


                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void Producat3_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form = new Form1();
            Form.ShowDialog();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.comboBox1.Text.Length > 0)
            {
                this.bttbChooesColor.Focus();
            }
        }

        private void bttbChooesColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.bttbChooesColor.Text.Length > 0)
            {
                this.bttnSave.Focus();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
