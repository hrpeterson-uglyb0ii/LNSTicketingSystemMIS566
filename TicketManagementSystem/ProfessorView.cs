﻿using System;
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
        public Form FormShowLeaderboard { get; set; }
        public Form LoginProfessor { get; set; }

        public ProfessorView()
        {
            InitializeComponent();
        }

        private void logOffButton_Click(object sender, EventArgs e)
        {
            this.Close();
            if (null != LoginProfessor)
            {
                LoginProfessor.Show();
            }
        }

        private void ProfessorView_Load(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            stview stViewForm = new stview();
            stViewForm.OpenTicketsClose = this;
            stViewForm.Show();
            this.Hide();
        }

        private void viewButton2_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.CloseProfessor = this;
            leaderboard.Show();
            this.Hide();
        }
    }
}
