using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example2
{
    /*
     * Create a class called Point. Inside this class you must create 
     * - two properties: int x, int y
     * - a method: string Draw(); returning a string such "This is a point drawn at (x,y)"
     * 
     * Create a second class called Circle.  Inside this class you must create
     * - three properties: int x, int y, double radius
     * - a method: string Draw();
     * - a method: double FindArea();
     * - a method: double FindPerimeter();
     * 
     * Create a third class called a Sphere. Inside this class you must create
     * - four properties: int x, int y, int z, double radius
     * - a method: string Draw();
     * - a method: double FindArea();
     * - a method: double FindPerimeter();
     * 
     * Create a fourth class called a Cylinder. Inside this class you must create
     * - five properties: int x, int y, int z, double radius, double height
     * - a method: string Draw();
     * - a method: double FindArea();
     * - a method: double FindPerimeter();
     */



    public class Point
    {
        public Point(int x, int y)
        { X = x; Y = y; }
        public int X { get; set; }
        public int Y { get; set; }

        //dynamic polymorphism 
        public virtual string Draw()
        {
            return $"This is a point drawn at ({X},{Y})";
        }

    }
}
