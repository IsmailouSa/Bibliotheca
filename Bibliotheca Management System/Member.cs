using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheca_Management_System
{
    public partial class Member : Form
    {
        Connection lib;
        public Member(string user_name)
        {
            InitializeComponent();
            lib = new Connection();
            username.Text = user_name;
            lblUsername.Text = user_name.Split(' ')[0];
            dgBookTaken.DataSource = lib.BooksTaken(lib.ID(user_name));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Member_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void textboxInfo()
        {
            foreach (string item in lib.AuthorName())
            {
                txtSearch.AutoCompleteCustomSource.Add(item);
                txtSearch.AutoCompleteCustomSource.Add(item);
            }
            foreach (string item in lib.BookName())
            {
                txtSearch.AutoCompleteCustomSource.Add(item);
                txtSearch.AutoCompleteCustomSource.Add(item);
            }
        }

        void loadsearch()
        {
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            search obj = new search(txtSearch.Text);
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
          //  MessageBox.Show(obj.Size.Width + ":" + obj.Size.Height);
        }

        private void Member_Load(object sender, EventArgs e)
        {
            textboxInfo();
            loadsearch();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadsearch();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            ProfileM obj = new ProfileM(username.Text);
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
           // MessageBox.Show(obj.Size.Width + ":" + obj.Size.Height);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
