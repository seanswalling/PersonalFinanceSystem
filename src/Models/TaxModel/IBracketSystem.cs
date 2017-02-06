using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxModel
{
    internal interface IBracketSystem
    {
        List<TaxBracket> GetBrackets();
    }
}
