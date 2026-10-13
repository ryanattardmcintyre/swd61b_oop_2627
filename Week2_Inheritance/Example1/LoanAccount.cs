using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example1
{
    public class LoanAccount: TermAccount
    {
        public LoanAccount() {
            InterestRate = 0.035;
        
        }

        public double CalculateInterestMonthly()
        {
            double interestPerAnnum
                  = InterestRate * (Balance * -1);
            return interestPerAnnum / 12;
        
        }

        
    }
}
