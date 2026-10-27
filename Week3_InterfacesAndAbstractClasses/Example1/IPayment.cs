using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Example1
{
    //What is an interface?
    //An interface is like a contract where it outlines some abstract declarations without
    //giving any implementations

    //Characteristics:
    //1. Interfaces stop at the declartion of propeties/methods
    //2. Cannot be instantiated (in other words you cannot create an object of an Interface)
    //   you cannot do this: IPayment myPayment = new IPayment();
    //3. An interface (to be used) has to be inherited
    //4. ...An abstract class/class which inherits an interface is forced to implement the interface
    //5. In a class you can inherit more than 1 interface
    public interface IPayment
    {
        double TaxRate { get; set; }
        double CalculatePayment(double amount);
        double CalculateTax(double amount);
        string PrintReceipt(double amount, List<string> items);
    }



}
