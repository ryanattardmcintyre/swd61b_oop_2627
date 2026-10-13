using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example1
{
    //Inheritance:
    //A child class inherits from a parent class thus
    //becoming a derived class and a base class
    //Hence the public & protected members of the base class
    //are inherited and thus made available in the derived
    //class
    public class SavingsAccount: BankAccount
    {
        public SavingsAccount() {
            InterestRate = 0.025;
        }

        public long VisaCardNumber = 0;

        public double Withdraw(double amount)
        { 
            if(Balance - amount >= 0)
            {
                Balance -= amount;
            }

            return Balance;
        }



    }
}
