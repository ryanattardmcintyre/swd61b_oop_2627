using Week2_Inheritance.Example1;
using Week2_Inheritance.Example2;

Point myPoint = new Point();
myPoint.X = 1; myPoint.Y = 1;

Circle myCircle = new Circle();
myCircle.X = 100; myCircle.Y = 100;
myCircle.Radius = 200;

Console.WriteLine(myPoint.Draw());

Console.WriteLine(myCircle.Draw());
Console.ReadKey();
