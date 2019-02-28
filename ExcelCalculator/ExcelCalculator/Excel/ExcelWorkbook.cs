using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCalculator.Excel
{
    class ExcelWorkbook
    {

        private ExcelWorksheet[] worksheets;

        public ExcelWorksheet[] Worksheets
        {
            get
            {
                return worksheets;
            }
            set
            {
                worksheets = value;
            }
        }

        public ExcelWorkbook()
        {
            this.worksheets = new ExcelWorksheet[0];
        }

        public void AddWorkshets(ExcelWorksheet worksheet)
        {
            Array.Resize<ExcelWorksheet>(ref worksheets, Worksheets.Length + 1);
            this.worksheets[worksheets.Length - 1] = worksheet;
        }

        public ExcelWorksheet GetWorksheet(string name)
        {
            for (int i = 0; i < this.worksheets.Length; i++)
                if (this.worksheets[i].WorksheetName.Equals(name))
                    return this.worksheets[i];
            return null;
        }
    }
}
