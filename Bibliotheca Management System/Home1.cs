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
    public partial class Home1 : Form
    {
        Connection lib;
        public Home1(string user_name)
        {
            InitializeComponent();
            lib = new Connection();
            textboxInfo();
            userinfo();
            username.Text = user_name;
            lblUsername.Text = user_name.Split(' ')[0];
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

        void userinfo()
        {
            foreach (string item in lib.MemFullName())
            {
                txtSuser.AutoCompleteCustomSource.Add(item);
                txtSuser.AutoCompleteCustomSource.Add(item);
            }
            foreach (string item in lib.memID())
            {
                txtSuser.AutoCompleteCustomSource.Add(item);
                txtSuser.AutoCompleteCustomSource.Add(item);
            }
        }

        private void Home1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Home1_Load(object sender, EventArgs e)
        {
            dgDueBooks.DataSource = lib.DueBooks();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearboth();
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            ProfileM obj = new ProfileM(username.Text);
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearboth();
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            Members obj = new Members();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            obj.Location = new Point(0, 0);
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearboth();
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            Books obj = new Books();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            obj.Location = new Point(0, 0);
        }

        private void circulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearboth();
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            Circulation obj = new Circulation();
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
            obj.Location = new Point(0, 0);
        }

        void loadBsearch()
        {
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            search obj = new search(txtSearch.Text);
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        void loadMsearch()
        {
            foreach (Form item in this.MdiChildren)
                item.Dispose();
            SearchM obj = new SearchM(txtSuser.Text);
            obj.MdiParent = this;
            obj.Dock = DockStyle.Fill;
            obj.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadBsearch();
            txtSuser.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadMsearch();
            txtSearch.Clear();
        }

        private void dgDueBooks_Click(object sender, EventArgs e)
        {
            dgDueBooks.DataSource = lib.DueBooks();
        }

        private void clearboth()
        {
            txtSuser.Clear();
            txtSearch.Clear();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            textboxInfo();
        }

        private void txtSuser_Click(object sender, EventArgs e)
        {
            userinfo();
        }
    }
}
