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
    public partial class ProfileM : Form
    {
        Connection lib;
        public ProfileM(string name)
        {
            InitializeComponent();
            lib = new Connection();
            LoadName(name);
        }

        void LoadName(string name)
        {
            txtCurr.Text = "";
            txtNew.Text = "";
            txtNewC.Text = "";
            string[] person = new string[4];
            person = lib.profile(name);
            lblName.Text = name;
            lblID.Text = Convert.ToString(lib.ID(name));
            rtbAddress.Text = person[1];
            lblRole.Text = person[2];
            txtEmail.Text = person[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadName(lblName.Text);
        }

        private void btnCancelP_Click(object sender, EventArgs e)
        {
            LoadName(lblName.Text);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNew.Text != txtNewC.Text)
            {
                MessageBox.Show("The new passwords are not identical !", "INFOTMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (txtCurr.Text != lib.password(lblName.Text))
            {
                MessageBox.Show("Current password is incorrect !", "INFOTMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool state = lib.UpdatePassword(Convert.ToInt32(lblID.Text), txtNew.Text);
                if (state)
                    MessageBox.Show("Operation Successfully Completed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An Error Has Occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadName(lblName.Text);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || rtbAddress.Text == "")
            {
                MessageBox.Show("Please enter e-mail and address !", "INFOTMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!txtEmail.Text.ToLower().Contains('@'))
            {
                MessageBox.Show("Invalid e-mail address !", "INFOTMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool state = lib.UpdateProfile(Int32.Parse(lblID.Text), txtEmail.Text, rtbAddress.Text);
                if (state)
                    MessageBox.Show("Operation Successfully Completed.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("An Error Has Occured !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadName(lblName.Text);
            }
        }

        private void txtNewC_TextChanged(object sender, EventArgs e)
        {
            if (txtNew.Text != txtNewC.Text) lblMatch.Visible = true;
            else lblMatch.Visible = false;
        }

        private void txtNewC_Click(object sender, EventArgs e)
        {
            if (txtNew.Text != txtNewC.Text) lblMatch.Visible = true;
            else lblMatch.Visible = false;
        }
    }
}
