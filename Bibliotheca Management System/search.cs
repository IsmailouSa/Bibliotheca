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
    public partial class search : Form
    {
        Connection lib;
        public search(string searchdata)
        {
            InitializeComponent();
            lib = new Connection();
            if (searchdata == "") dgMember.DataSource = lib.allBooks();
            else dgMember.DataSource = lib.guestBooks(searchdata);
        }
    }
}
