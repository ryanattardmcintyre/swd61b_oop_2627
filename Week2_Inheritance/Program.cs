using Week2_Inheritance.Example1;
using Week2_Inheritance.Example2;
using Week2_Inheritance.Example3;
using Week2_Inheritance.Example4;


TextDigitalFile myFile = new TextDigitalFile();
myFile.Filename = "C://users/attar/downloads/myfile.txt";
myFile.Text = "Hello World";
myFile.Save(false, "this is the new text", "Hello.txt");







//1. Add a Cone class that inherits from Point/Circle/Sphere/Cylinder
    //Cone => X,Y,Z,Radius,Height, FindArea, FindPerimeter, FindVolume
//2. Update Program.cs to accomodate the addition of a Cone shape into myShapes
//3. Offer the user the option to FindVolumes() of any shapes which allow you
     //to find the volume of

List<Point>myShapes = new List<Point>();
int choice;
do
{
    Console.Clear();
    Console.WriteLine("1.\t Adding a shape");
    Console.WriteLine("2.\t Print details of shapes on screen");
    Console.WriteLine("3.\t Find Areas");
    Console.WriteLine("4.\t Quit");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1: //add new shape
            Console.Clear();
            Console.WriteLine("1.\t Point");
            Console.WriteLine("2.\t Circle");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1: //Point
                    Console.WriteLine("Insert coordinate x:");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert coordinate y:");
                    int y = Convert.ToInt32(Console.ReadLine());

                    Point p = new Point(x, y);
                    myShapes.Add(p);

                    Console.WriteLine("Point added!");
                    break;

                case 2: //Circle
                    Console.WriteLine("Insert coordinate x:");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert coordinate y:");
                     y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert radius:");
                    int radius = Convert.ToInt32(Console.ReadLine());

                    Circle c = new Circle(x, y, radius);
                    myShapes.Add(c);

                    Console.WriteLine("Point added!");
                    break;
            }

            break;

        case 2: //calling Draw() method of each shape

            Console.Clear();
            //Circle is a Point, Sphere is a Circle which is a Point, ...
            foreach(Point p in myShapes)
            {
                Console.WriteLine(p.Draw()); //effect of dynamic polymorphism
                Console.WriteLine("---------------------------\r");
                
            }

            break;


        case 3://finding areas
            Console.Clear();
            //Circle is a Point, Sphere is a Circle which is a Point, ...
            foreach (Point p in myShapes)
            {
                if(p is Circle)
                {
                    Circle c = (Circle)p;

                    Console.WriteLine("Area: " + c.FindArea());
                    Console.WriteLine("---------------------------\r");
                }
            }
            break;
    }

    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
} while (choice != 4); //keep repeating if choice is not equals to 3

Console.ReadLine();


