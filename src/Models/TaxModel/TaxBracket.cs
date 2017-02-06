using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxModel
{
    public class TaxBracket
    {
        private readonly double _rate;
        private readonly double _bracketUpperLimit;
        private readonly double _bracketLowerLimit;

        private double _taxable;
        private double _taxCharged;

        public TaxBracket(double rate, double upper, double lower)
        {
            _rate = rate;
            _bracketUpperLimit = upper;
            _bracketLowerLimit = lower;
        }

        public void CalculateTax(double income)
        {
            if (income >= _bracketUpperLimit && _bracketUpperLimit != 0.0) //0 means uncapped here
            {
                _taxable = _bracketUpperLimit - _bracketLowerLimit;
            }
            else if (income > _bracketLowerLimit)
            {
                _taxable = income - _bracketLowerLimit;
            }
            else
            {
                _taxable = 0;
            }

            _taxCharged = _taxable * _rate;
        }

        public double GetTax()
        {
            return _taxCharged;
        }
    }
}
