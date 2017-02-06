using System.Collections.Generic;
using TransactionRecord;

namespace IncomeModel
{
    public class IncomeRecord : ITransactionRecord
    {
        private FinancialYear _finYear;
        private List<Income> _income;
    }
}
