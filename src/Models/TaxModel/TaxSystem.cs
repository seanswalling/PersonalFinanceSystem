using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxModel
{
    internal class TaxSystem
    {
        private readonly List<TaxBracket> _breakdown;

        public TaxSystem()
        {
            IBracketSystem bracketSystem = new AusTaxBrackets();
            _breakdown = bracketSystem.GetBrackets();
        }

        public double CalculateTax(double income)
        {
            foreach(var bracket in _breakdown) { bracket.CalculateTax(income);}

            return _breakdown.Sum(i => i.GetTax());
        }

    }
}
