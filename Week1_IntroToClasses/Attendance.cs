using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_IntroToClasses
{
    public class Attendance
    {
        private bool present;

        public int Id { get; set; }
        public string Group { get; set; }
        public Person Person { get; set; }
        public bool Present { get { return present; }  }

        public DateTime LastModified { get; set; }
        public void MarkPresent(string adminPassword)
        {
            if (adminPassword == "P@$$w0rd")
            {
                present = true;
                LastModified = DateTime.Now;
            }
        }
        


    }
}
