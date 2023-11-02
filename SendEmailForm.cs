using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TicketManagementSystem
{
    public partial class SendEmailForm : Form
    {
        private string creatorEmail;

        public SendEmailForm(string creatorEmail)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.creatorEmail = creatorEmail;
        }

        private void sendEmailButton_Click_1(object sender, EventArgs e)
        {
            string recipient = creatorEmail;
            string subject = subjectTextBox.Text;
            string body = bodyTextBox.Text;

            // Create a new SmtpClient with your SMTP server settings
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com")
            {
                Port = 587, // Port for your SMTP server
                Credentials = new NetworkCredential("Your outlook email here", "Your outlook password here"), //Outlook email credentials go here
                EnableSsl = true
            };

            MailMessage message = new MailMessage("rbiehler02@outlook.com", recipient)
            {
                Subject = subject,
                Body = body
            };

            try
            {
                client.Send(message);
                MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private void sendExit_Click(object sender, EventArgs e)
        {
            StudentView studentViewForm = new StudentView();
            studentViewForm.Show();
            this.Close();
        }
    }
}
