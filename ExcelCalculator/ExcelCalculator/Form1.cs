using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using ExcelCalculator.Excel;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;

namespace ExcelCalculator
{
    public partial class Form1 : Form
    {

        private ExcelWorkbook myWorkbook;
        private string filePath;
        private DateTime startInterval;
        private DateTime endInterval;

        public Form1()
        {
            InitializeComponent();
            this.dateTimeStartInterval.Value = new DateTime(2017, 1, 1);
            this.dateEndTimeInterval.Value = new DateTime(2018, 1, 1);
        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            excelLoader.ShowDialog(this);
        }

        private void excelLoader_FileOk(object sender, CancelEventArgs e)
        {
            this.filePath = excelLoader.FileNames[0] as string;
            this.myWorkbook = new ExcelWorkbook();
            this.startInterval = dateTimeStartInterval.Value;
            this.endInterval = dateEndTimeInterval.Value;

            if (File.Exists(filePath))
                this.processWorker.RunWorkerAsync();
        }

        private void appendLine(ExcelLine line)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                        delegate () { appendLine(line); }));
            }
            else
            {
                textBox1.AppendText("Date: " + line.DateAdded + " ------>  Val F: " + line.FactorDePutere + "  R:  " + line.PutereReactiva + "  Result:  " + this.applyAlgorithm(line) + Environment.NewLine);
            }
        }

        private void setLoadButtonStatus(bool status)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(
                    new MethodInvoker(
                        delegate () { setLoadButtonStatus(status); }));
            }
            else
            {
                this.btnLoadExcel.Enabled = status;
            }
        }

        private double applyAlgorithm(ExcelLine line)
        {
            double x = 0;
            if (line.FactorDePutere < 0.65)
                x = line.PutereReactiva * 0.1926;
            else if (line.FactorDePutere < 0.9)
                x = line.PutereReactiva * 0.0642;

            return x;
        }

        private void initFile(string path)
        {
            Microsoft.Office.Interop.Excel.Application excelApplication = null;
            Workbook excelWorkbook = null;

            try
            {
                excelApplication = new Microsoft.Office.Interop.Excel.Application();
                excelWorkbook = excelApplication.Workbooks.Open(path);

                for(int i = 1; i <= excelWorkbook.Worksheets.Count; i++)
                {
                    dynamic dynamicWorksheet = excelWorkbook.Worksheets[i];
                    Worksheet worksheet = excelWorkbook.Worksheets[i];

                    ExcelWorksheet excelWorksheet = new ExcelWorksheet(dynamicWorksheet.Name);

                    Range lastRow = dynamicWorksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing);
                    Range workingRange = worksheet.get_Range("A1", lastRow);

                    int numberOfRows = workingRange.Rows.Count;

                    for(int j = 2; j <= numberOfRows; j++)
                    {
                        dynamic currentRow = workingRange.Rows[j];

                        dynamic cell1 = currentRow.Cells[1];
                        dynamic val1 = cell1.Value;

                        dynamic cell2 = currentRow.Cells[2];
                        dynamic val2 = cell2.Value;

                        dynamic cell5 = currentRow.Cells[5];
                        dynamic val5 = cell5.Value;

                        dynamic cell8 = currentRow.Cells[8];
                        dynamic val8 = cell8.Value;

                        try
                        {
                            int noCrt = Convert.ChangeType(val1, typeof(int));
                            DateTime date = val2 == null ? DateTime.MinValue : this.getDateTime(val2);
                            double factorDePutere = val5 == null ? 0 : Convert.ChangeType(val5, typeof(double));
                            double putereReactiva = val8 == null ? 0 : Convert.ChangeType(val8, typeof(double));

                            if(date >= this.startInterval && date <= this.endInterval)
                            {
                                ExcelLine excelLine = new ExcelLine(noCrt, date, factorDePutere, putereReactiva);
                                excelWorksheet.AddLine(excelLine);

                                this.appendLine(excelLine);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                        }

                        processWorker.ReportProgress(j * 100 / numberOfRows);
                    }

                    myWorkbook.AddWorkshets(excelWorksheet);
                    if (i == 1) break;
                   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                try
                {
                    excelWorkbook.Close(SaveChanges: true);
                }
                catch { }

                excelApplication.Quit();

                if (excelWorkbook != null)
                    Marshal.ReleaseComObject(excelWorkbook);
                if (excelApplication != null)
                    Marshal.ReleaseComObject(excelApplication);

                excelWorkbook = null;
                excelApplication = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private DateTime getDateTime(dynamic val2)
        {
            string dateString = val2 == null ? DateTime.MinValue.ToLongDateString() : Convert.ChangeType(val2, typeof(string));

            if (dateString.Contains("."))
                return DateTime.ParseExact(dateString, "dd.MM.yyyy  HH:mm:ss", null);

            return Convert.ToDateTime(dateString);
        }

        private void processWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.setLoadButtonStatus(false);
            this.initFile(filePath);
        }

        private void processWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progress.Value = e.ProgressPercentage;
        }

        private void processWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.setLoadButtonStatus(true);
        }
    
    }
}
