using Week2_Inheritance.Example1;
using Week2_Inheritance.Example2;
using Week2_Inheritance.Example3;


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
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert coordinate y:");
                    int y1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Insert radius:");
                    int radius = Convert.ToInt32(Console.ReadLine());

                    Circle c = new Circle(x1, y1, radius);
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


