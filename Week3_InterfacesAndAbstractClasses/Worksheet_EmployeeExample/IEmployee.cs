using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample
{

    //This design change is also known as "Facade design pattern"
    public interface IEmployee: IBonus, ISalary
    {
        string Name { get; set; }
    }
}
