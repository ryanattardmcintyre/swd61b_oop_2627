using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Example1
{
    public class CardPayment : IPayment
    {
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public string CardNumber { get; set; }

        public string Amount { get; set; }
        public string Currency { get; set; }

        /// <summary>
        /// Expressed as Percentage (out of 100)
        /// e.g. 18%
        /// </summary>
        public double TaxRate { get; set; }

        public double Commission { get; set; }
        public double CalculatePayment(double amount)
        {
            return (CalculateTax(amount) + amount)
                 * (1+(Commission/100));
        }

        public double CalculateTax(double amount)
        {
            return (amount * (TaxRate / 100));
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
            output += $"Commision: {Commission}\n";
            output += $"Total: {CalculatePayment(amount)}";

            return output;
        }
    }
}
