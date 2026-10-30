using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample
{
    /*
     * Class 1: FullTimeEmployee
Properties: Name (string), MonthlySalary (decimal), YearsOfService (int).
CalculateSalary(): Return the fixed monthly salary.
CalculateBonus(): Calculate an annual bonus based on annual salary (MonthlySalary x 12):
• Fewer than 5 years: 5% of annual salary.
• 5 to 10 years inclusive: 10% of annual salary.
• More than 10 years: 15% of annual salary.
Example: Monthly salary EUR 2,500; 7 years of service. Annual salary = EUR 30,000; annual bonus = EUR
3,000.



     */
    public class FullTimeEmployee: IBonus, ISalary
    {
        public string Name { get; set; }
        public decimal MonthlySalary { get; set; }
        public int YearsOfService { get; set; }

        public decimal CalculateBonus()
        {
            /*• Fewer than 5 years: 5% of annual salary.
• 5 to 10 years inclusive: 10% of annual salary.
• More than 10 years: 15% of annual salary.*/

            if (YearsOfService < 5)
                return 0.05M * (MonthlySalary * 12M);
            else if (YearsOfService >= 5 && YearsOfService < 10)
                return 0.1M * (MonthlySalary * 12);
            else return 0.15M * (MonthlySalary * 12);

        }

        public decimal CalculateSalary()
        {
            return MonthlySalary ;
        }
    }
}
