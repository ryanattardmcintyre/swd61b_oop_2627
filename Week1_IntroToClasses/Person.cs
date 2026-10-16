using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* private = makes the component private to the logical segregation its in
 * protected = makes the component accessible to either the components in the same class or in derived classes
 * internal = makes the component (classes) accessible to other components within the same logical segregation
 * public = makes the component public to any other component
 */ 



namespace Week1_IntroToClasses
{
    //class names:
    //- they have be in singular
    //- they have to be Pascal case (i.e. first letter is capital case, next letters are not)
    //- no numbers, no symbols, no spaces in the names
    //syntax: [<access modifier>] class <name of class>
    public class Person
    {
        //constructor: are used to instantiate the objects but also used to execute code at the very
        //             beginning
        //syntax: they are like methods BUT NO RETURN TYPES
        //naming: constructors are named exactly like the class they're in
        public Person()
        {
            name = "Joe";
            Surname = "Borg";
            dateOfBirth = DateTime.Now; 
        }

        //fields:
        //fields are containers of data i.e. in fields we will be storing values

        //field names:
        //- is camel case i.e. first letter is small, next letters representing next words are capital 
        //- no numbers, no symbols, no SPACES in the names
        //- access modifier = private

        //syntax: [<access modifier>]<data type><name of the field>
        private string name;
        
        DateTime dateOfBirth;
        string email;
        long contactNumber;
        

        //properties
        //properties are used to control the access to the values stored in the fields

        //name = Ryan
        public string Name { get { return name[0].ToString().ToUpper()+name.Substring(1).ToLower(); } 
            set { name = value; } }

        public string FullName { get { return Name + " " + Surname; } }

        public string Email { get { return email; }  set { email = value; } }
        public long ContactNumber { get { return contactNumber; } set { contactNumber = value; } }

        public string Surname { get; set; }

        //When do you use this notation?
        //Use this notation if there is no specification in the requirements which requires you to
        //modify the data that's being stored/read to/from the field
        public bool Active { get; set; }
        public string Address { get; set; }

        //methods
        //a method is a group of commands that need to be executed normally changing/processing
        // the data within an object
        public void SetDefault()
        {
            name = ""; Surname = ""; email = ""; Active = false; contactNumber = 0; 
        }

        public int CalculateAge()
        {
            return DateTime.Now.Year - dateOfBirth.Year;
        }

        public int HowOldThePersonWillBeInYear(int year)
        {
            if (year > DateTime.Now.Year)
                return year - dateOfBirth.Year;
            else return -1;
        }

    }
}
