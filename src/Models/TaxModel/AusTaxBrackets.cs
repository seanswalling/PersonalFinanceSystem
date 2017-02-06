using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxModel
{
    internal class AusTaxBrackets : IBracketSystem
    {
        private readonly List<TaxBracket>_breakdown;

        public AusTaxBrackets()
        {
            _breakdown = new List<TaxBracket>
            {
                new TaxBracket( 0, 18200, 0),
                new TaxBracket( .19, 37000, 18200),
                new TaxBracket( .325, 87000, 37000),
                new TaxBracket( .37, 180000, 87000),
                new TaxBracket( .45, 0, 180000)
            };
        }

        public List<TaxBracket> GetBrackets()
        {
            return _breakdown;
        }
    }
}
