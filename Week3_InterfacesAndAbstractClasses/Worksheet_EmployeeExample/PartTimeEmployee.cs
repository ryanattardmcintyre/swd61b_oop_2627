using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample
{/*
  * Class 2: PartTimeEmployee
Properties: Name (string), HourlyRate (decimal), HoursWorked (int).
CalculateSalary(): HourlyRate x HoursWorked (monthly salary).
CalculateBonus(): If HoursWorked is greater than 80, return 5% of monthly salary; 
    otherwise return zero.
Example: EUR 15 per hour x 100 hours = EUR 1,500 monthly salary; bonus = EUR 75.
  */
    public class PartTimeEmployee: IBonus, ISalary
    {
        public string Name { get; set; }
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public decimal CalculateBonus()
        {
            if (HoursWorked > 80) return 0.05M * CalculateSalary();
            else return 0;
        }

        public decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
}
