using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TicketManagementSystem
{
    public partial class stview : Form
    {
        public stview()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;

        string sFileName = "C:\\Users\\megan\\Desktop\\TicketManagementSystem (3)\\TicketManagementSystem (2)\\TicketManagementSystem\\TicketManagementSystem\\opentickets.xlsx";

        public void Excel2Grid(string sFile)
        {
            {
                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(sFile);
                xlWorkSheet = xlWorkBook.Worksheets[1];

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                int iRow, iCol;

                for (iCol = 1; iCol <= xlWorkSheet.Columns.Count; iCol++)
                {
                    if (xlWorkSheet.Cells[1, iCol].Value == null)
                    {
                        break;
                    }
                    else
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = xlWorkSheet.Cells[1, iCol].Value;
                        int colIndex = dataGridView1.Columns.Add(col);
                    }
                }

                for (iRow = 2; iCol <= xlWorkSheet.Rows.Count; iRow++)
                {
                    if (xlWorkSheet.Cells[iRow, 1].Value == null)
                    {
                        break;
                    }
                    else
                    {
                        string[] row = new string[]
                        {
                            xlWorkSheet.Cells[iRow, 1].Value.ToString(),
                            xlWorkSheet.Cells[iRow, 2].Value.ToString(),
                            xlWorkSheet.Cells[iRow, 3].Value.ToString(),
                            xlWorkSheet.Cells[iRow, 4].Value.ToString(),
                            xlWorkSheet.Cells[iRow, 5].Value.ToString(),
                            xlWorkSheet.Cells[iRow, 6].Value.ToString(),
                            xlWorkSheet.Cells[iRow, 7].Value.ToString(),
                        };

                        dataGridView1.Rows.Add(row);
                    }
                }
            }

            dataGridView1.AutoResizeColumns();
            xlWorkBook.Close();
            xlApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet);
        }

        private void stExit_Click(object sender, EventArgs e)
        {
            StudentView studentViewForm = new StudentView();
            studentViewForm.Show();
            this.Close();
        }

        private void stview_Load_1(object sender, EventArgs e)
        {
            Excel2Grid(sFileName);
        }

        private void resolveTicket_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                int columnIndex = 1;
                string creatorEmail = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();

                dataGridView1.Rows.RemoveAt(rowIndex);

                UpdateExcelWorksheet(rowIndex);

                SendEmailForm sendEmailForm = new SendEmailForm(creatorEmail);
                sendEmailForm.ShowDialog();

                MessageBox.Show("You have finished resolving this ticket. Good job!");
            }
            else
            {
                MessageBox.Show("Please select the row of the ticket you wish to resolve.");
            }
        }

        private void UpdateExcelWorksheet(int rowIndex)
        {
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(sFileName);
            xlWorkSheet = xlWorkBook.Worksheets[1];

            xlWorkSheet.Rows[rowIndex + 2].Delete();

            xlWorkBook.Save();
            xlWorkBook.Close(false);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
        }

    }
}
