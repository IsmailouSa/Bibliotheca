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
    public partial class Books : Form
    {
        int ID = 0;
        Connection lib;
        public Books()
        {
            InitializeComponent();
            lib = new Connection();
        }

        private void dgBooks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gbDeleteUpdateBk.Enabled = true;
            ID = int.Parse(dgBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtEditBkTitle.Text = dgBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEditBkAuthor.Text = dgBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEditBkYr.Text = dgBooks.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEditBkQty.Text = dgBooks.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        void refresh()
        {
            dgBooks.DataSource = lib.allBooks();
        }

        void updateClean()
        {
            gbDeleteUpdateBk.Enabled = false;
            ID = 0;
            txtEditBkTitle.Clear();
            txtEditBkAuthor.Clear();
            txtEditBkYr.Clear();
            txtEditBkQty.Clear();
        }

        void addClean()
        {
            txtAddBkQty.Clear();
            txtAddBkAuthor.Clear();
            txtAddBkTitle.Clear();
            txtAddBkYr.Clear();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtAddBkTitle.Text != "" && txtAddBkAuthor.Text != "" && txtAddBkYr.Text != "" && txtAddBkQty.Text != "")
            {
                bool State = lib.AddBook(txtAddBkTitle.Text, txtAddBkAuthor.Text, txtAddBkYr.Text, int.Parse(txtAddBkQty.Text));
                if (State)
                {
                    addClean();
                    refresh();
                    MessageBox.Show("Book Has Been Added Successfully Completed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An Error Has Occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Fill All Fields !", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (txtEditBkTitle.Text != "" && txtEditBkAuthor.Text != "" && txtEditBkQty.Text != "" && txtEditBkYr.Text != "")
            {
                bool State = lib.UpdateBook(ID, txtEditBkTitle.Text, txtEditBkAuthor.Text, txtEditBkYr.Text, int.Parse(txtEditBkQty.Text));
                if (State)
                {
                    updateClean();
                    refresh();
                    MessageBox.Show("Operation Successfully Completed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An Error Has Occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Please Fill All Fields !", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemoveBk_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are You Sure You Want To Delete The Book ?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                bool State = lib.DeleteBook(ID);
                if (State)
                {
                    updateClean();
                    refresh();
                }
                else
                    MessageBox.Show("An Error has occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
