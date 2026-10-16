using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1_IntroToClasses;

namespace Week2_Inheritance.Example3
{
    //User must inherit from Person (From Week 1)
    //User must contain a Username and Password properties
    //User must have a method called ChangePassword(currentPassword, newPassword, confirmPassword)

    //Problem: Two users are the same person if their username matches
    public class User: Person
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            if(Password == currentPassword && newPassword==confirmPassword)
            {
                Password = currentPassword;
            }
        }

        //produces a code (numeric) which is a result of hashing the entire object
        public override int GetHashCode()
        {
            //GetHashCode()  => by default it combines all the values inside the object and produces 
            //                  this numeric value which represents everything

            //               -> overriding the above to compute only the hash code of just the Username
            return Username.GetHashCode();
        }
        public override bool Equals(object? obj)
        {
            if (obj is User)
            {
                return obj.GetHashCode() == this.GetHashCode();
                
            }
            else return false;
        }

    }
}
