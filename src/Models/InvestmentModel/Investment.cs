using System;
using System.Collections.Generic;
using System.Linq;

namespace InvestmentModel
{
    public class Investment
    {
        public int InvestmentNumber { get; }
        public Price InvestmentPrice { get; }
        public List<Price> HistoricalPrice { get; }

        public Investment(Price investmentPrice, int investmentNumber)
        {
            InvestmentPrice = investmentPrice;
            InvestmentNumber = investmentNumber;
            HistoricalPrice = new List<Price>();
            AddPrice(investmentPrice);
        }

        public void AddPrice(Price price)
        {
            HistoricalPrice.Add(price);
        }

        public Price GetPriceAtDate(DateTime date)
        {
            return HistoricalPrice.Find(p => p.Date.Equals(date));
        }

        public Price GetLatestPrice()
        {
            return HistoricalPrice.OrderByDescending(p => p.Date).First();
        }

        public Price GetLastPriceBeforeDate(DateTime date)
        {
            return HistoricalPrice.Where(p => p.Date < date)
                                  .OrderByDescending(p => p.Date)
                                  .First();
        }
    }
}
