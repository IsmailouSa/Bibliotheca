using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Bibliotheca_Management_System
{
    public partial class Password_Recovery : Form
    {
        public Password_Recovery()
        {
            InitializeComponent();
        }

        private void BtnRecover_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();
            try
            {
                string pass = con.Recpassword(txtEmail.Text);
                if (pass == "meere")
                {
                    MessageBox.Show("Invalid E-mail address", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                MailMessage objeto_mail = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                objeto_mail.From = new MailAddress("ismailou.sa@gmail.com");
                objeto_mail.To.Add(txtEmail.Text);
                objeto_mail.Body = "Your password is " + pass;
                objeto_mail.Subject = "Password Recovery";
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                //if (pass != "")
                //{
                //    objeto_mail.Attachments.Add(new Attachment("Your password is " + pass));
                //}
                client.Credentials = new System.Net.NetworkCredential("ismailou.sa@gmail.com", "jmonster114");
                client.Send(objeto_mail);
                objeto_mail = null;
                MessageBox.Show("Password sent.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to send password !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
