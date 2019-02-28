using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCalculator.Excel
{
    class ExcelWorksheet
    {
        private string worksheetName;
        private ExcelLine[] lines;

        public string WorksheetName
        {
            get
            {
                return worksheetName;
            }

            set
            {
                worksheetName = value;
            }
        }

        public ExcelLine[] Lines
        {
            get
            {
                return lines;
            }

            set
            {
                lines = value;
            }
        }

        public ExcelWorksheet(string name)
        {
            this.worksheetName = name;
            this.lines = new ExcelLine[0];
        }

        public void AddLine(ExcelLine line)
        {
            Array.Resize<ExcelLine>(ref lines, lines.Length + 1);
            this.lines[lines.Length - 1] = line;
        }

        public override bool Equals(object obj)
        {
            ExcelWorksheet compareTo = (ExcelWorksheet)obj;
            return
                this.worksheetName.Equals(compareTo.WorksheetName);
        }
    }
}
