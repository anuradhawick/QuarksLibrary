using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuarksLibrary
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
            //initializing the avaiability to enter proxy values
            proxy.Enabled = false;
            proxyport.Enabled = false;
            
        }

        private void mailerTest_Click(object sender, EventArgs e)
        {
            try
            {
                sendTestMail();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid data","Error");
            }
        }

        private void useProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (useProxy.Checked)
            {
                proxy.Enabled = true;
                proxyport.Enabled = true;
            }
            else
            {
                proxy.Enabled = false;
                proxyport.Enabled = false;
            }
        }
        private void sendTestMail()
        {
            MailAddress from = new MailAddress("no-reply@quarkslibrary.com");
            MailAddress to = new MailAddress(Microsoft.VisualBasic.Interaction.InputBox("Enter an email address for testing", "Mailer test", null, -1, -1));
            if (to == null)
            {
                return;
            }
            MailMessage testMail = new MailMessage(from, to);
            testMail.Subject = "Testing the mailer";
            testMail.Body = "Mailing function worked successfully";
            SmtpClient client;
            if (useProxy.Checked)
            {
                //code for proxied mailing
            }
            else
            {
                //code for non proxy mailing
            }
            client = new SmtpClient(smtpClient.Text, Int32.Parse(smtpPort.Text));
            client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text);
            client.EnableSsl = true;
            try
            {
                client.Send(testMail);
                MessageBox.Show("Sending mail success", "Mailer test");
            }
            catch (Exception)
            {
                MessageBox.Show("Sending mail failed. Re-check your settings", "Mailer test");
            }            
        }
    }
}
