using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Example1
{

    //1. create a property called TaxRate e.g. 18%
    //2. create a new property called PaypalCharge expressed as a percentage of 0.1%
    //3. implement IPayment only
    //4. implement the methods derived from inheriting IPayment
    //where CalculatePayment will add the charge only if amount exceeds Eur100
    public class PaypalPayment : IPayment
    {
        public double TaxRate { get;
            set; }

        public double PaypalCharge { get; set; }
        public double CalculatePayment(double amount)
        {
            double subTotal = CalculateTax(amount) + amount;
            double total = 0;
            if(subTotal > 100)
            {
                 total = (1 + (PaypalCharge / 100)) * subTotal;
            }
            else
            {
                total = subTotal;
            }
            return total;
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
            output += $"Charge: {PaypalCharge}\n";
            output += $"Total: {CalculatePayment(amount)}";

            return output;
        }
    }
}
