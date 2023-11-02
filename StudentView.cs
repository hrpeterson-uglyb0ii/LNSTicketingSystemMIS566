using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TicketManagementSystem
{
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public Form FormToShowOnClosing { get; set; }
        private void mainFrm_Load(object sender, EventArgs e)
        {

        }

        private void StudentViewLabel_Click(object sender, EventArgs e)
        {

        }

        private void logOffButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            createTicket createTicketForm = new createTicket();
            createTicketForm.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            stview stViewForm = new stview();
            stViewForm.Show();
        }
    }
}
