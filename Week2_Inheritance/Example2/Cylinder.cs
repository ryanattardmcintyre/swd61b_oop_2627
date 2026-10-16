using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example2
{
    public class Cylinder: Sphere
    {
        public Cylinder(int x, int y, int z, int radius, int height): base(x,y,z, radius)
        {
            Height = height;
        }
        public double Height { get; set; }

        public override string Draw()
        {
            return $"This is a cylinder with {X},{Y},{Z}, radius: {Radius} and height: {Height}";
        }
        public override double FindArea()
        {
            //2πrh + 2π(r^2)

            return (2 * Math.PI * Radius * Height) + (2 * Math.PI * Radius * Radius);

        }

        public override double FindVolume()
        {
            return Math.PI * Radius * Radius * Height;
        }

    }
}
