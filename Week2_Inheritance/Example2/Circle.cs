using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example2
{
    public class Circle: Point
    {
        public double Radius { get; set; }

        //you apply override (part of dynamic polymorphism) only if you need to change the method's
        //implementation
        public override string Draw()
        {
            return $"This is a Circle drawn at {X}, {Y} with radius {Radius}";
        }

        public double FindArea()
        { 
                return Math.PI * Math.Pow(Radius, 2);
        }
        public double FindPerimeter()
        {
            return Math.PI * Radius * 2;
        }
    }
}
