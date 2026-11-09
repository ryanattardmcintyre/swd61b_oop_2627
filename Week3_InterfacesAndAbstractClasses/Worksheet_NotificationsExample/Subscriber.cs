using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_InterfacesAndAbstractClasses.Worksheet_NotificationsExample
{
    public class Subscriber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }

        public string Email { get; set; }

        public Subscriber(int id, string name, string mobile, string email) {

            Id = id;
            Name = name;
            Mobile = mobile;
            Email = email;
        }
    }
}
