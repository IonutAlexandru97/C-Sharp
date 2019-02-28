using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelCalculator.Excel
{
    class ExcelLine
    {
        private int noCrt;
        private DateTime dateAdded;
        private double F;
        private double R;

        public int NoCrt
        {
            get
            {
                return noCrt;
            }

            set
            {
                noCrt = value;
            }
        }

        public DateTime DateAdded
        {
            get
            {
                return dateAdded;
            }

            set
            {
                dateAdded = value;
            }
        }

        public double FactorDePutere
        {
            get
            {
                return F;
            }

            set
            {
                F = value;
            }
        }

        public double PutereReactiva
        {
            get
            {
                return R;
            }

            set
            {
                R = value;
            }
        }

        public ExcelLine(int noCrt, DateTime dateAdded, double F, double R)
        {
            this.NoCrt = noCrt;
            this.DateAdded = dateAdded;
            this.FactorDePutere = F;
            this.PutereReactiva = R;
        }
    }
}
