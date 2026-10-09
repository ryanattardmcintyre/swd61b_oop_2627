//What is an object?
//An object is when you instantiate the class
//An object allows you to start assigning values to the properties inside
// the class

//What is a class?
//A class represents a collection of related characteristics that together they define some (real world) entity
//A class is like a template/blueprint
//e.g. class Book
//e.g. class Student, class User, class Person


using Week1_IntroToClasses;

Person p;  //the declaration of an object p of type Person
p = new Person(); //the instantiation of object p; creating an object of type Person using the Constructor
p.Name = "Ryan";
p.Surname = "Attard";

Person p2 = new Person();
p2.Name = "Maria";

p2 = p;
Console.WriteLine("Name= " + p2.Name);


//Exercise
//Create a class named Attendance which has the following properties:
//Id -int
//Group - string
//Person - Person
//Present - bool
//LastModified - DateTime

// and the following method:
// MarkPresent() - where it sets Present to true and changes the LastModified property
// MarkAbsent() - where it sets Present to false and changes the LastModified property


Attendance a = new Attendance();
a.Person = p;
a.MarkPresent("123");


