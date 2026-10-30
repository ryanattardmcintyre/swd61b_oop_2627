using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample
{
    /*
     * Class 3: SalesEmployee
Properties: Name (string), BaseSalary (decimal), MonthlySales (decimal).
CalculateSalary(): BaseSalary + 3% commission on MonthlySales.
Page 2
CalculateBonus(): If MonthlySales exceeds EUR 20,000, return an additional 5% of MonthlySales;
otherwise return zero.
Example: Base salary EUR 1,800; monthly sales EUR 25,000. Commission = EUR 750; monthly salary =
EUR 2,550; bonus = EUR 1,250.
     */
    public class SalesEmployee : IBonus, ISalary
    {
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal MonthlySales { get; set; }
        public decimal CalculateBonus()
        {
            if (MonthlySales > 20000)
                return 0.05M * MonthlySales;
            else return 0;
        }

        public decimal CalculateSalary()
        {
            return BaseSalary + (0.03M * MonthlySales);
        }
    }
}
