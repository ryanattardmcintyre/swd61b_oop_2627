using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6_ClassRelationships.Composition
{
    public class Company
    {
        public int Id { get; set; } 
        public string Name { get; set; } //e.g. MCAST
        public string Description { get; set; }
        public string Address { get; set; }

        List<Department> departments;
        public Company()
        {
            departments = new List<Department>();
        }
        public void AddDepartment(string name, string code)
        {
            Department myDepartment = new Department();
            myDepartment.Name = name;
            myDepartment.Code = code;
            myDepartment.Id = departments.Count + 1;

            departments.Add(myDepartment);

        }

    }
}
