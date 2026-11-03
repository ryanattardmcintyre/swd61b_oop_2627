using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Example3_AbstractClasses
{
 
    /*
     * Abstract classes
     * - An abstract class cannot be instantiated (like an interface) e.g. I cannot do this Product p = new Product()
     * - As it happens with an interface, an abstract is there to be inherited
     * - An abstract its like a contract (like an interface) BUT with an added value: it allows implementations
     *   side-by-side with abstract methods
     *   
     * When do you use an abstract class and not an interface?
     * - Reason 1: When you have partial details of the implementation
     * - Reason 2: scenario when you must use a class as a common base type but not an interface e.g.
     *             you need a common base type with some implemented method but you need to add an unimplemented
     *             method
     *   Example: NotifictionStrategy
     *            e.g. when applying to take a course I want to inform the applicant and the university
     *            e.g. when booking to use a lab I want to inform the person responsible of the bookings for that lab
     *            e.g  when appling for a degree online I want to inform the the applicant, the hosting univ, the applciant's university
     *            Solution in this case => NotificationStrategy Abstract class 
     *            <= LabNotificationStrategy, CourseNotificationStrategy, ForumNotificationStrategy
     */ 

    public abstract class Product
    {
        //fields:
        private string name;

        //properties
        public int Id { get; set; }
        public string Name { get { return name.ToUpper(); } set { name = value; } }
        public Dimension Dimensions { get; set; }

        public double Weight { get; set; }

        public double WholesalePrice { get; set; }

        public double CalculateRetailPrice(double taxRate)
        {
            return (1 + taxRate) * WholesalePrice;
        }

        //if a method is marked with abstract, it means that we don't have a concrete implementation
        //and after this class is inherited it will have to be overridden.
        public abstract double CalculateShippingCost();
        


    }
}
