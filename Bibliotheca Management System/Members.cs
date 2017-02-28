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
    public partial class Members : Form
    {
        int ID = 0;
        Connection lib;
        public Members()
        {
            InitializeComponent();
            lib = new Connection();
        }

        void refresh()
        {
            dgMembers.DataSource = lib.allUsers();
        }

        void updateClean()
        {
            gbDeleteUpdateMem.Enabled = false;
            ID = 0;
            txtEditName.Clear();
            txtEditEmail.Clear();
            rtbEditAddress.Clear();
            cbxEditRole.Items.Clear();
            cbxEditRole.Items.Add("Member");
            cbxEditRole.Items.Add("Administrator");
        }

        void addClean()
        {
            txtMemName.Clear();
            txtMemAddress.Clear();
            rtbAddress.Clear();
            cbxRole.Items.Clear();
            cbxRole.Items.Add("Member");
            cbxRole.Items.Add("Administrator");
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (txtMemName.Text != "" && txtMemAddress.Text != "" && rtbAddress.Text != "" && cbxRole.Text != "")
            {
                bool State = lib.AddMember(txtMemName.Text, txtMemAddress.Text, cbxRole.Text, rtbAddress.Text);
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

        private void btnRemoveMem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are You Sure You Want To Delete The User ?", "INFORMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dg == DialogResult.Yes)
            {
                bool State = lib.DeleteMember(ID);
                if (State)
                {
                    updateClean();
                    refresh();
                }
                else
                    MessageBox.Show("An Error Has Occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateMem_Click(object sender, EventArgs e)
        {
            if (txtEditName.Text != "" && txtEditEmail.Text != "" && rtbEditAddress.Text != "" && cbxEditRole.Text != "")
            {
                bool State = lib.UpdateMember(ID, txtEditName.Text, txtEditEmail.Text, cbxEditRole.Text, rtbEditAddress.Text);
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

        private void Members_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void dgMembers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            gbDeleteUpdateMem.Enabled = true;
            ID = int.Parse(dgMembers.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtEditName.Text = dgMembers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEditEmail.Text = dgMembers.Rows[e.RowIndex].Cells[3].Value.ToString();
            rtbEditAddress.Text = dgMembers.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxEditRole.Text = dgMembers.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
