using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example2
{
    public class Circle: Point
    {
        public Circle(int x, int y, double radius): base(x, y) 
        {
            //base = refers to the class being inherited
            //this = refers to the object instantiated out of class holding the running code
            this.Radius = radius;
        }
        public double Radius { get; set; }

        //you apply override (part of dynamic polymorphism) only if you need to change the method's
        //implementation
        public override string Draw()
        {
            return $"This is a Circle drawn at {X}, {Y} with radius {Radius}";
        }

        public virtual double FindArea()
        { 
                return Math.PI * Math.Pow(Radius, 2);
        }
        public virtual double FindPerimeter()
        {
            return Math.PI * Radius * 2;
        }
    }
}
