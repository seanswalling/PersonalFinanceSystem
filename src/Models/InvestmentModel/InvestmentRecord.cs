using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentModel
{
    public class InvestmentRecord
    {
        public List<Investment> Investments { get; }

        public InvestmentRecord(List<Investment> investments)
        {
            Investments = investments;
        }

        public void AddInvestment(Investment investment)
        {
            Investments.Add(investment);
        }

        public Investment GetInvestment(int id)
        {
            return Investments.Find(i => i.InvestmentId == id);
        }
         
    }
}
