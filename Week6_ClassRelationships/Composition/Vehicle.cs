using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_ClassRelationships.Composition
{
    //Class A has a composition type of relationship with Class B
    //if Class A (object) existence is dependant on Class B (object)
    //existance

    //in other words, if ClassB b = new ClassB(); 
    //Class B will have a composition relationship with Class a only if
    //this: ClassA a = new ClassA(); is happening in b


    public class Vehicle //ClassB
    {
        public Engine Engine { get; set; }
        public Vehicle(string engineNumber, string make, string model)
        {
          //  Engine = new Engine() { EngineNumber = engineNumber, Make = make, Model = model };
        }
    }

    public class Engine
    {
        public string EngineNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
