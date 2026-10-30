// See https://aka.ms/new-console-template for more information
using Week3_InterfacesAndAbstractClasses.Example1;
using Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample;

/*
 * Create at least two objects of each employee type.
• Store all employees in one collection using an appropriate common type or interface.
• Iterate over the collection and display each employee's name, calculated monthly salary, and bonus.
• Calculate the total monthly salary expenditure.
• Calculate the total bonuses payable to all employees.
• Invoke interface methods rather than branching on concrete types using if or switch.
Design note: ISalary and IBonus alone do not provide a common type exposing both calculations and
Name. You may define a combined interface, for example:
public interface IEmployee : ISalary, IBonus
{
string Name { get; }
}
Implement IEmployee in each employee class, and use List<IEmployee> for the collection. This also
demonstrates interface inheritance.
 */

FullTimeEmployee myFulltimer1 = new FullTimeEmployee();
FullTimeEmployee myFulltimer2 = new  FullTimeEmployee();

PartTimeEmployee partTimeEmployee1 = new PartTimeEmployee();
PartTimeEmployee partTimeEmployee2 = new PartTimeEmployee();

SalesEmployee sales1 = new SalesEmployee();
SalesEmployee sales2 = new SalesEmployee();

List<ISalary> myEmployees = new List<ISalary>(); //creating an object of List<ISalary>()
myEmployees.Add(myFulltimer1);
myEmployees.Add(myFulltimer2);
myEmployees.Add(partTimeEmployee1);
myEmployees.Add(partTimeEmployee2);
myEmployees.Add(sales1);
myEmployees.Add(sales2);

foreach(ISalary employee in myEmployees)
{
  
}