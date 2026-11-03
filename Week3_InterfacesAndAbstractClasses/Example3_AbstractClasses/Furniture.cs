using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Example3_AbstractClasses
{
    public class Furniture : Product
    {
        public override double CalculateShippingCost()
        {
            //20eur per metre m^3
            // 1 x 2 x 3 = 6

            return (Dimensions.Length * Dimensions.Width * Dimensions.Height) * 20;
        }
    }
}
