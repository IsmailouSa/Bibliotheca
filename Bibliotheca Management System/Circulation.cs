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
    public partial class Circulation : Form
    {
        int ID = 0;
        Connection lib;
        public Circulation()
        {
            InitializeComponent();
            lib = new Connection();
        }

        private void Circulation_Load(object sender, EventArgs e)
        {
            refresh();
            textboxInfo();
        }

        void addClean()
        {
            txtAddMemName.Clear();
            txtAddBookName.Clear();
            dtpAddReturnD.Value = DateTime.Now;
        }

        void updateClean()
        {
            ID = 0;
            gbCheckIn.Enabled = false;
            txtMemName.Clear();
            txtBookName.Clear();
            dtpReturnD.Value = DateTime.Now;
        }

        void textboxInfo()
        {
            foreach (string item in lib.MemFullName())
            {
                txtAddMemName.AutoCompleteCustomSource.Add(item);
                txtMemName.AutoCompleteCustomSource.Add(item);
            }
            foreach (string item in lib.BookName())
            {
                txtAddBookName.AutoCompleteCustomSource.Add(item);
                txtBookName.AutoCompleteCustomSource.Add(item);
            }
        }

        void refresh()
        {
            dgCirculation.DataSource = lib.allLending();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtAddBookName.Text != "" && txtAddMemName.Text != "")
            {
                int qty = lib.bookQty(txtAddBookName.Text);
                if (qty > 1)
                {
                    bool State = lib.BookIssue(txtAddMemName.Text, txtAddBookName.Text, DateTime.Now, dtpAddReturnD.Value, --qty);
                    if (qty == 1)
                        lib.statusUpdate(txtAddBookName.Text);
                    if (State)
                    {
                        addClean();
                        refresh();
                        MessageBox.Show("Issue Successfully Completed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Book Issue Unsuccessful !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (qty == 0)
                    MessageBox.Show("Invalid Book Title", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Cannot be given out. For use only in the Library", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Please Fill All Fields !", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgCirculation_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gbCheckIn.Enabled = true;
            ID = int.Parse(dgCirculation.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtBookName.Text = dgCirculation.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMemName.Text = dgCirculation.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpReturnD.Value = DateTime.Parse(dgCirculation.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMemName.Text != "" && txtBookName.Text != "")
            {
                bool State = lib.IssueUpdate(ID, txtMemName.Text, txtBookName.Text, dtpReturnD.Value);
                if (State)
                {
                    updateClean();
                    refresh();
                    MessageBox.Show("Operation Successfully Completed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An Error has occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please Fill All Fields !", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are You Sure You Want To Return The Book ?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                int fine = lib.fine(ID);
                if (fine > 0)
                { DialogResult dg1 = MessageBox.Show("Fine: " + fine + " Euro(s). Pay now? ", "PENALTY", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (dg1 == DialogResult.No) return;
                }
                int qty = lib.bookQty(txtBookName.Text);
                if (qty == 1)
                    lib.ReturnUpdate(txtBookName.Text);
                bool State = lib.DeleteIssue(ID, ++qty, txtBookName.Text);
                if (State)
                {
                    updateClean();
                    refresh();
                    MessageBox.Show("Operation Successfully Completed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("An Error has occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
