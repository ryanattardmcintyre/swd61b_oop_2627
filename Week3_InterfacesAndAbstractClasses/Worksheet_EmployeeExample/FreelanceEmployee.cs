using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample
{
    public class FreelanceEmployee : IEmployee
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal CalculateBonus()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}
