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
    public partial class SearchM : Form
    {
        Connection lib;
        public SearchM(string searchdata)
        {
            InitializeComponent();
            lib = new Connection();
            if (searchdata == "") dgMembers.DataSource = lib.allUsers();
            else
            {
                try
                {
                    int ID = Convert.ToInt32(searchdata);
                    dgMembers.DataSource = lib.searchUserID(ID);
                }
                catch (Exception)
                {
                    dgMembers.DataSource = lib.searchUser(searchdata);
                }
            }
        }
    }
}
