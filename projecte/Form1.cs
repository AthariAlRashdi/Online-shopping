using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login= new login();
            login.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Producat1 p1 = new Producat1();
            p1.Show();

        }

        private void bttn_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Producat1 p1 = new Producat1();
            p1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = login.SetValueForText1;
        }

        private void bbtnDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            Producat3 p1 = new Producat3();
            p1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Producat2 p1 = new Producat2();
            p1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Producat3 p1 = new Producat3();
            p1.Show();

        }

        private void bttnLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }
    }
}
