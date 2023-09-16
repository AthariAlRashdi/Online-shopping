using Microsoft.Win32;
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
    public partial class Details : Form
    {SqlCommand cmd=new SqlCommand();
        SqlConnection con=new SqlConnection();

        SqlDataAdapter ads=new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Details()
        {
            InitializeComponent();
        }

        private void Details_Load(object sender, EventArgs e)
        {
            
           con.ConnectionString = "SERVER=DESKTOP-155VT4P\\SQLEXPRESS01;DATABASE=efahDB;TRUSTED_CONNECTION=TRUE";
            con.Open();

        }

        private void lbl_UserName_Click(object sender, EventArgs e)
        {

        }
    }
    
}
