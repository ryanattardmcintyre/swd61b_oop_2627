using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample
{

    //Facade design pattern = to explain!
    internal interface IEmployee: IBonus, ISalary
    {
        string Name { get; set; }
    }
}
