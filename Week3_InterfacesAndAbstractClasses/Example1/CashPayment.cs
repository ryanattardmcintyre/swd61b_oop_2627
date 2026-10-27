using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Example1
{
    public class CashPayment : IPayment, IDiscount
    {
        public double TaxRate { get; set; }
        public double DiscountPercentage { get; set; }
        public double CalculatePayment(double amount)
        {
            return (CalculateTax(amount) + amount);
        }

        public double CalculatePaymentWithDiscount(double amount)
        {
            //25% => 100-25 = 75 / 100 = .75
            return CalculatePayment(amount) * ((100 -DiscountPercentage )/100);
        }

        public double CalculateTax(double amount)
        {
            return (TaxRate / 100) * amount;
        }

        public string PrintReceipt(double amount, List<string> items)
        {
            string output = "";
            foreach (var item in items)
            {
                output += $"{item} \n";
            }
            output += "---------------------\n";
            output += $"Tax ({TaxRate}): {CalculateTax(amount)}\n";
            output += $"Total without discount: {CalculatePayment(amount)} \n";
            output += "---------------------\n";
            output += $"Total with discount {DiscountPercentage}: {CalculatePaymentWithDiscount(amount)}";

            return output;
        }
    }
}
