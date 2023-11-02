using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManagementSystem
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public Form FormToShowOnClosing { get; set; }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var Form1 = new StudentView();
            Form1.FormToShowOnClosing = this;
            Form1.Show();
            this.Hide();
        }

        private void FrmGrpBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorView openProfessorView = new ProfessorView();
            openProfessorView.Show();
        }
    }
}
