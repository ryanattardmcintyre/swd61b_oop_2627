using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example1
{
    public class TermAccount: BankAccount
    {
        public TermAccount()
        {
            InterestRate = 0.05;
        }

        public DateTime MaturityDate { get; set; }
    }
}
