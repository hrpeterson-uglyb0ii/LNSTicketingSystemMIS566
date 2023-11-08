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
    public partial class Leaderboard : Form
    {
        public Form CloseProfessor { get; set; }

        public Leaderboard()
        {
            InitializeComponent();
        }

        private void btnExitLead_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != CloseProfessor)
            {
                CloseProfessor.Show();
            }

        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {

        }
    }
}
