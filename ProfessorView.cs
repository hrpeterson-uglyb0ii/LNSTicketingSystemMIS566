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
    public partial class ProfessorView : Form
    {
        public ProfessorView()
        {
            InitializeComponent();
        }

        private void logOffButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProfessorView_Load(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            stview stViewForm = new stview();
            stViewForm.Show();
        }

        private void viewButton2_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.Show();
        }
    }
}
