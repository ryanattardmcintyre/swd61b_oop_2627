using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Example3_AbstractClasses
{
    public class Electronic : Product
    {
        public bool DoesItHaveABattery { get; set; }
        public override double CalculateShippingCost()
        {
            //10eur per 200g
            if (DoesItHaveABattery)
                return ((Weight / 200) * 10) + 50;
            else
            {
                return ((Weight / 200) * 10);
            }
        }
    }
}
