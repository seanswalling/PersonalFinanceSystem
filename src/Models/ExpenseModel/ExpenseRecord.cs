using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionRecord;

namespace ExpenseModel
{
    public class ExpenseRecord : ITransactionRecord
    {
        private FinancialYear _finYear;
        private List<Expense> _expenses;
    }
}
