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
    public partial class Guest : Form
    {
        Connection lib;
        public Guest()
        {
            InitializeComponent();
            lib = new Connection();
        }

        private void Guest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
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

        private void Guest_Load(object sender, EventArgs e)
        {
            textboxInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") dgGuest.DataSource = lib.allBooks();
            else dgGuest.DataSource = lib.guestBooks(txtSearch.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}

