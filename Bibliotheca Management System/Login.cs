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
using System.Net.Mail;


namespace Bibliotheca_Management_System
{
    public partial class Login : Form
    {   
        SqlConnection con = new SqlConnection("Data Source =.\\sqlexpress; Initial Catalog = Bibliotheca; Integrated Security = True");

        public Login()
        {
            InitializeComponent();
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            Guest obj = new Guest();
            obj.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fPasswordLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password_Recovery obj = new Password_Recovery();
            obj.Show();
        }

        private void fPasswordLbl_MouseHover(object sender, EventArgs e)
        {
            fPasswordLbl.LinkColor = Color.Brown;
        }

        private void fPasswordLbl_MouseLeave(object sender, EventArgs e)
        {
            fPasswordLbl.LinkColor = Color.FromArgb(0, 0, 225);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Members where Mem_Name = '" + textBox1.Text + "' and Mem_password = '" + textBox2.Text + "' COLLATE Latin1_General_CS_AS and Mem_Role = 'Administrator'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SqlDataAdapter sda1 = new SqlDataAdapter("select * from Members where Mem_Name = '" + textBox1.Text + "' and Mem_password = '" + textBox2.Text + "' COLLATE Latin1_General_CS_AS and Mem_Role = 'Member'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            if (dt.Rows.Count == 1)
            {
                Home1 obj = new Home1(textBox1.Text);
                obj.Show();
                this.Hide();
            }
            else if (dt1.Rows.Count == 1)
            {
                Member obj = new Member(textBox1.Text);
                obj.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid Username and/or Password !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
