// See https://aka.ms/new-console-template for more information
using Week3_InterfacesAndAbstractClasses.Example1;
using Week3_InterfacesAndAbstractClasses.Example3_AbstractClasses;
using Week3_InterfacesAndAbstractClasses.Worksheet_EmployeeExample;
using Week3_InterfacesAndAbstractClasses.Worksheet_NotificationsExample;

//Consuming Abstract class

Product product = new Furniture();
product.WholesalePrice = 100;
product.Dimensions = new Dimension() { Length = 1, Height = 1.5, Width = 2 };

List<Product> myProducts = new List<Product>();
myProducts.Add(product);
myProducts.Add(new Electronic() { Name="Mobile", WholesalePrice=500, DoesItHaveABattery=true, Weight=600 });

foreach(Product p in myProducts)
{
    Console.WriteLine("Type of product: " + p.GetType().Name);
    Console.WriteLine("Retail price: " + p.CalculateRetailPrice(0.18));
    Console.WriteLine("Shipping cost: " + p.CalculateShippingCost());
    Console.WriteLine("Total cost: " + (p.CalculateRetailPrice(0.18) + p.CalculateShippingCost()));
    Console.WriteLine("");
}

Console.ReadKey();








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
myFulltimer1.Name = "Joe"; myFulltimer1.MonthlySalary = 1000; myFulltimer1.YearsOfService = 5; 
FullTimeEmployee myFulltimer2 = new  FullTimeEmployee();
myFulltimer2.Name = "Mary"; myFulltimer2.MonthlySalary = 2000; myFulltimer2.YearsOfService = 10;

PartTimeEmployee partTimeEmployee1 = new PartTimeEmployee();
partTimeEmployee1.Name = "Jane"; partTimeEmployee1.HourlyRate = 10; partTimeEmployee1.HoursWorked = 40;
PartTimeEmployee partTimeEmployee2 = new PartTimeEmployee();
partTimeEmployee2.Name = "Peter"; partTimeEmployee2.HourlyRate = 11; partTimeEmployee2.HoursWorked = 30;

SalesEmployee sales1 = new SalesEmployee();
sales1.Name = "Robert"; sales1.MonthlySales = 20001; sales1.BaseSalary = 500;
SalesEmployee sales2 = new SalesEmployee();
sales2.Name = "Maya"; sales2.MonthlySales = 40000; sales2.BaseSalary = 500;

List<IEmployee> myEmployees = new List<IEmployee>(); //creating an object of List<ISalary>()
myEmployees.Add(myFulltimer1);
myEmployees.Add(myFulltimer2);
myEmployees.Add(partTimeEmployee1);
myEmployees.Add(partTimeEmployee2);
myEmployees.Add(sales1);
myEmployees.Add(sales2);

decimal totalSalaries = 0; decimal totalBonuses = 0;
foreach(IEmployee employee in myEmployees)
{
    Console.WriteLine($"Employee: {employee.Name}, Salary: {employee.CalculateSalary()}, Bonus: {employee.CalculateBonus()}");
    totalSalaries += employee.CalculateSalary();
    totalBonuses += employee.CalculateBonus();
}
Console.WriteLine("");
Console.WriteLine($"Total Expenditure in Salaries: {totalSalaries}");
Console.WriteLine($"Total Expenditure in Bonuses: {totalBonuses}");

Console.ReadKey();



Subscriber s1 = new Subscriber(1, "ryan", "79797979", "ryan.attard@mcast.edu.mt");
Subscriber s2 = new Subscriber(1, "joe", "79797333", "ryan.attard@mcast.edu.mt");
Subscriber s3 = new Subscriber(1, "robert", "79797444", "ryan.attard@mcast.edu.mt");

Notification emailNotification = new EmailNotification("Newsletter 1", "...");
emailNotification.AddSubscriber(s1);
emailNotification.AddSubscriber(s2);

Notification smsNotification = new SmsNotification("Abc. Ltd", "...");
smsNotification.AddSubscriber(s3);


List<Notification> notifications = new List<Notification>();
notifications.Add(emailNotification);
notifications.Add(smsNotification);
foreach(var n in notifications)
{
    n.NotifySubscribers();
}




