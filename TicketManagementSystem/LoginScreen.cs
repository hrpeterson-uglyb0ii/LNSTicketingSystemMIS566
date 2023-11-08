using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

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
            string currentDirectory = Environment.CurrentDirectory;

            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(currentDirectory + "\\Security.xlsx");
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            int rowCount = worksheet.UsedRange.Rows.Count;
            int colCount = worksheet.UsedRange.Columns.Count;

            bool found = false;
            for (int row = 1; row <= rowCount; row++)
            {
                string username = ((Excel.Range)worksheet.Cells[row, 1]).Value2?.ToString();
                string password = ((Excel.Range)worksheet.Cells[row, 2]).Value2?.ToString();
                string role = ((Excel.Range)worksheet.Cells[row, 3]).Value2?.ToString();

                if (username == userTextBox.Text && password == passwordTextBox.Text)
                {
                    found = true;
                    switch (role)
                    {
                        case "student":
                            StudentView studentView = new StudentView();
                            studentView.Show();
                            this.Hide();
                            break;
                        case "ta":
                            TAview taView = new TAview();
                            taView.Show();
                            this.Hide();
                            break;
                        case "prof":
                            MessageBox.Show("Haven't Implemented");
                            break;
                    }
                    break;
                }
            }

            if (!found) MessageBox.Show("Invalid username or password");
            excelApp.Quit();
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
