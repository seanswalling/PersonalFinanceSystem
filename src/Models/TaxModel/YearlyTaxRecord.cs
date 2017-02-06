using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxModel
{
    public class YearlyTaxRecord
    {
        private readonly int _year;
        private readonly double _income;
        private double _tax;
        private readonly TaxSystem _system = new TaxSystem();

        public YearlyTaxRecord(double income, int year)
        {
            _income = income;
            _year = year;
            CalcYearlyTax();
        }

        private void CalcYearlyTax()
        {
            _tax = _system.CalculateTax(_income);
        }

        public double GetTax()
        {
            return _tax;
        }

        public int GetYear()
        {
            return _year;
        }

    }
}
