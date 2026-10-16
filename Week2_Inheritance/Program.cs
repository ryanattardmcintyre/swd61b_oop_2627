using Week2_Inheritance.Example1;
using Week2_Inheritance.Example2;
using Week2_Inheritance.Example3;

User a = new User();
a.Name = "Joe"; a.Surname = "Attard";
a.Username = "test";

User b = new User();
b.Name = "Peter"; b.Surname = "Grech";
b.Username = "test1";

Console.WriteLine($"Are these users the same: {a.Equals(b)}");

Console.ReadLine();


