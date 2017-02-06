using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentModel
{
    class Share : Investment
    {
        public List<Dividend> Dividends { get; }
        public String CompanyCode { get; }

        public Share(Price investmentPrice, int investmentNumber, string companyCode) : base(investmentPrice, investmentNumber)
        {
            CompanyCode = companyCode;
            Dividends = new List<Dividend>();
        }

        public void AddDividend(Dividend dividend)
        {
            Dividends.Add(dividend);
        }

        public Dividend GetDividend(DateTime date)
        {
            return Dividends.Single(d => d.Date.Equals(date));
        }

        public Dividend GetLastDividendBeforeDate(DateTime date)
        {
            return Dividends.Where(d => d.Date < date)
                            .OrderByDescending(d => d.Date)
                            .First();
        }

        public Dividend GetLatestDividend()
        {
            return Dividends.OrderByDescending(d => d.Date)
                            .First();
        }

        public double GetCurrentDividendRate()
        {
            return (GetLatestDividend().Amount / GetLatestPrice().Amount) * 100;
        }

        public double GetDividendRateAtDate(DateTime date)
        {
            return (GetLastDividendBeforeDate(date).Amount / GetLastPriceBeforeDate(date).Amount) * 100;
        }
    }
}
