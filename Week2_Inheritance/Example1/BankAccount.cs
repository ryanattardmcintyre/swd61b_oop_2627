using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example1
{
    public class BankAccount
    {
        public string Iban { get; set; }
        public string OwnerIdCard { get; set; }
        public double Balance { get; set; }
        public string Currency { get; set; }

        protected double InterestRate { get; set; }

        public double Deposit (double amount)
        {
            Balance += amount; //Balance = Balance + amount
            return Balance;
        }

    }
}
