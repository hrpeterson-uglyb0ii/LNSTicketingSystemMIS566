using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace TicketManagementSystem
{
    public partial class createTicket : Form
    {
        public Form FormShowCreation { get; set; } 

        public createTicket()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        string sname = "https://github.com/hrpeterson-uglyb0ii/LNSTicketingSystemMIS566/blob/5ba8c5a20ebc58c78558c4a52e512f386e0a5599/opentickets.xlsx";

        //C:\\Users\\rbieh\\OneDrive\\Desktop\\TicketManagementSystem(2)\\TicketManagementSystem\\TicketManagementSystem\\opentickets.xlsx
        

        int iRow, iCol = 1;
        private void createTicket_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentView studentViewForm = new StudentView();
            studentViewForm.StudentClosing = this;
            studentViewForm.Show();
            this.Close();
        }

        private void ticketSub_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();

            //try
            //{
            //    using (var package = new ExcelPackage(uploadFile.InputSteam))
            //    {
            //        var worksheet = package.Workbook.Worksheets[0];
            //        for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
            //        {
            //            var callValue = worksheet.Cells[1, 0].Text;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Exception: " + ex.Message);
            //}

            try
            {
                xlWorkBook = xlApp.Workbooks.Open(sname);
                xlWorkSheet = xlWorkBook.Worksheets[1];

                for (iRow = 2; iRow <= xlWorkSheet.Rows.Count; iRow++)
                {
                    if (xlWorkSheet.Cells[iRow, 1].value == null)
                    {
                        xlWorkSheet.Cells[iRow, iCol].value = textName.Text;
                        xlWorkSheet.Cells[iRow, iCol + 1].value = textEmail.Text;
                        xlWorkSheet.Cells[iRow, iCol + 2].value = textOpen.Text;
                        xlWorkSheet.Cells[iRow, iCol + 3].value = typeBox.Text;
                        xlWorkSheet.Cells[iRow, iCol + 4].value = levelBox.Text;
                        xlWorkSheet.Cells[iRow, iCol + 5].value = textSubject.Text;
                        xlWorkSheet.Cells[iRow, iCol + 6].value = textDetails.Text;
                        break;
                    }
                }

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
                xlWorkBook.Close();
                xlApp.Quit();

                
                MessageBox.Show("Hello " +textName.Text+"," + " your ticket has been submitted. Thank You!");
                textOpen.Text = " ";
                typeBox.Text = " ";
                levelBox.Text = " ";
                textSubject.Text = " ";
                textDetails.Text = " ";
                textName.Text = " ";
                textEmail.Text = " ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel File not Found or another problem exists! " + ex.Message);
            }
        }

    }
}
