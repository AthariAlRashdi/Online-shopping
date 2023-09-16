using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace projecte
{
    public partial class Admin : Form
    {

        SqlConnection con;
        public Admin()
        {
            InitializeComponent();
        }



        private void bbttnDELETE_Click(object sender, EventArgs e)
        {



            if (this.txtPhone.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "Please Double Click on the Row you want Delete..!";
                return;
            }
            else
            {
                this.lblInfo.Text = "";
            }
            string sqlDELETEQuery;
            sqlDELETEQuery = " DELETE from userregister Where Phone ="+Convert.ToInt32(this.txtPhone.Text);
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmd = new SqlCommand(sqlDELETEQuery, con);
            int cnt = 0;
            try
            {
                cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    this.lblInfo.Text = "Record of Phone " + Convert.ToInt32(this.txtPhone.Text) + " Deleted Succesfully!";
                    clearControls();
                    showAllRecords();
                }
                else
                {
                    this.lblInfo.Text = "Process Aborted...!";
                }
            }
            catch (Exception ex)
            {
                this.lblInfo.Text = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }


        private void bttnUPDATE_Click(object sender, EventArgs e)
        {

            //// Ensure All Mandatory fields are entered

            //FirstName
            if (this.txtFirstName.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "Please type FirstName..!";
                this.txtFirstName.Focus();
                return;
            }
            else
            {
                this.lblInfo.Text = "";
            }

            //LastName
            if (this.txtLastName.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "Please type LastName..!";
                this.txtLastName.Focus();
                return;
            }
            else
            {
                this.lblInfo.Text = "";
            }

            //Email
            if (this.txtEmail.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "Please Email..!";
                this.txtEmail.Focus();
                return;
            }
            else
            {
                this.lblInfo.Text = "";
            }

            //Address
            if (this.txtEmail.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "Please Type Address..!";
                this.txtEmail.Focus();
                return;
            }
            else
            {
                this.lblInfo.Text = "";
            }


            //Password
            if (this.txtPassword.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "Please Enter Password..!";
                this.txtPassword.Focus();
                return;
            }
            else
            {
                this.lblInfo.Text = "";
            }


            //Phone
            if (this.txtPhone.Text.Trim().Length == 0)


            {
                this.lblInfo.Text = "Please Enter Phone Number..!";
                this.txtPhone.Focus();
                return;
            }
           
            
            else
            {
                this.lblInfo.Text = "";
            }


            string FirstName, LastName, Email, Address, Password, Proudect_id;
            int Phone;
            FirstName = this.txtFirstName.Text.Trim().Replace("'", "''");
            LastName = this.txtLastName.Text.Trim().Replace("'", "''");
            Email = this.txtEmail.Text.Trim().Replace("'", "''");
            Address = this.txtAddress.Text.Trim().Replace("'", "''");
            Password = this.txtPassword.Text.Trim().Replace("'", "''");
            Phone = Convert.ToInt32(this.txtPhone.Text);
           //Proudect_id = this.textID.Text.Trim().Replace("'", "''");
            string sqlUPDATEQuery;
            sqlUPDATEQuery = "UPDATE userregister SET FirstName ='" + FirstName + "', LastName = '" + LastName + "',Address = '" + Address + "', Email = '" + "',Password= '" + Password + "' Where Phone = "+ Convert.ToInt32(this.txtPhone.Text);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(sqlUPDATEQuery, con);
            int cnt = 0;
            try
            {
                cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    this.lblInfo.Text = " Updated Succesfully!";
                    clearControls();
                    showAllRecords();
                }
                else
                {
                    this.lblInfo.Text = "Process Aborted...!";
                }
            }
            catch (Exception ex)
            {
                this.lblInfo.Text = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }

        }


        private void Admin_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);
            showAllRecords();
            //showAllRecords1();

        }

        private void showAllRecords1()
        {
            throw new NotImplementedException();
        }

        private void bttnSHOW_Click(object sender, EventArgs e)
        {
            showAllRecords();
        }

        void showAllRecords()
        {
            if (con.State == ConnectionState.Closed)
            { con.Open(); }
            string sql = "  Select[FirstName] ,[LastName],[userregister].Email,[Password],[Address],[Phone],[Size],[Color],[ID],[Price] from [dbo].[userregister] INNER JOIN [dbo].[producto] on\r\n  [dbo].[userregister].Email=[dbo].[producto].Email";

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet DS = new DataSet();
            try
            {
                da.Fill(DS, "Tr");
                this.dataGridView1.DataSource = DS;
                this.dataGridView1.DataMember = "Tr";
            }
            catch (Exception ex)
            {
                this.lblInfo.Text = ex.Message;









            }
            finally
            {
                con.Close();
                da.Dispose();
                DS.Dispose();

            }
            this.lblInfo.Text = this.dataGridView1.Rows.Count - 1 + "Record(s)Found..!";
        }

        void clearControls()
        {
            this.txtFind.Text = "";

            this.txtFirstName.Clear();
            this.txtLastName.Clear();
            this.txtEmail.Clear();
            this.txtAddress.Clear();
            this.txtPassword.Clear();
            this.txtPhone.Clear();

            this.txtFirstName.Focus();
           


        }

        private void bttnFind_Click(object sender, EventArgs e)
        {
            this.label8.Text = "Type Customer Email 's  to Search...";
            //if (this.bttFind.Text.Trim().Length == 0)
            //    this.label8.Text = "Type Few number of phone 's  to Search...";
            //this.bttFind.Focus();
            //}

            {
                showAllRecords1();
            }

            void showAllRecords1()
            {
                if (con.State == ConnectionState.Closed)
                { con.Open(); }
                String Email=this.txtFind.Text;
                string sql = "SELECT * FROM userregister WHERE Email='"+Email+"'";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet DS = new DataSet();
                try
                {
                    da.Fill(DS, "Tr");
                    this.dataGridView1.DataSource = DS;
                    this.dataGridView1.DataMember = "Tr";
                }
                catch (Exception ex)
                {
                    this.lblInfo.Text = ex.Message;

                }
                finally
                {
                    con.Close();
                    da.Dispose();
                    DS.Dispose();

                }
                this.lblInfo.Text = this.dataGridView1.Rows.Count - 1 + "Record(s)Found..!";
            }

            void clearControls2()
            {
                this.txtFind.Text = "";

                this.txtFirstName.Clear();
                this.txtLastName.Clear();
                this.txtEmail.Clear();
                this.txtAddress.Clear();
                this.txtPassword.Clear();
                this.txtPhone.Clear();

                this.txtFirstName.Focus();



            }


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //this.lblID.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.txtFirstName.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString().Trim();
            this.txtLastName.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString().Trim();
            this.txtEmail.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString().Trim();
            this.txtPassword.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim();
            this.txtAddress.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim();
            this.txtPhone.Text = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString().Trim();
            //this.textID.Text = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString().Trim();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {

            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtPhone.Text.Trim().Length == 0)
            {
                this.lblInfo.Text = "Please Double Click on the Row you want Delete..!";
                return;
            }
            else
            {
                this.lblInfo.Text = "";
            }
            string sqlDELETEQuery;
            sqlDELETEQuery = " DELETE from userregister Where Phone =" + Convert.ToInt32(this.txtPhone.Text);
            if (con.State == ConnectionState.Closed) { con.Open(); }
            SqlCommand cmd = new SqlCommand(sqlDELETEQuery, con);
            int cnt = 0;
            try
            {
                cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    this.lblInfo.Text = "Record of Phone " + Convert.ToInt32(this.txtPhone.Text) + " Deleted Succesfully!";
                    clearControls();
                    showAllRecords();
                }
                else
                {
                    this.lblInfo.Text = "Process Aborted...!";
                }
            }
            catch (Exception ex)
            {
                this.lblInfo.Text = ex.Message;
            }
            finally
            {
                con.Close();
                cmd.Dispose();
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtFirstName.Text.Length > 0)
            {
                this.txtLastName.Focus();
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtLastName.Text.Length > 0)
            {
                this.txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtEmail.Text.Length > 0)
            {
                this.txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtPassword.Text.Length > 0)
            {
                this.txtAddress.Focus();
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtAddress.Text.Length > 0)
            {
                this.txtPhone.Focus();
            }
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter && this.txtFind.Text.Length > 0)
            {
                this.bttFind.Focus();
            }
        }
    }
    }


