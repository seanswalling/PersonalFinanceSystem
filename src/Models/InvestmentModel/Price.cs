using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentModel
{
    public class Price
    {
        public DateTime Date { get; }
        public double Amount { get; }
        public Price(DateTime date, double amount)
        {
            Date = date;
            Amount = amount;
        }
    }
}
