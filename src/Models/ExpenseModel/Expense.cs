using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseModel
{
    class Expense
    {
        private DateTime Date { get; }
        private double Amount { get; }
        private string Description { get; set; }

        public Expense(DateTime date, double amount, string description)
        {
            Date = date;
            Amount = amount;
            Description = description;
        }

    }
}
