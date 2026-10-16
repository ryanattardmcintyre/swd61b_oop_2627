using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Inheritance.Example2
{
    public class Sphere: Circle
    {
        public Sphere (int x, int y, int z, int radius): base(x, y, radius)
        {
            Z = z;
        }
        public int Z { get; set; }

        public override string Draw()
        {
            return $"This is a sphere with {X}, {Y}, {Z} and radius {Radius}";
        }
        public override double FindArea()
        {
            return 4 * Math.PI * Radius * Radius;
        }

        public virtual double FindVolume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
