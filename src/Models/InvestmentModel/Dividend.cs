using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentModel
{
    class Dividend
    {
        public Investment Investment { get; }
        public double CentsPerShare { get; }
        public double Amount { get; }
        public double FrankingCredit { get; }
        public DateTime Date { get; }

        public Dividend(Share investment, double centsPerShare, double amount, double frankingCredit, DateTime date)
        {
            Investment = investment;
            CentsPerShare = centsPerShare;
            FrankingCredit = frankingCredit;
            Date = date;
            Amount = amount;
        }

    }
}
