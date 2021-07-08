using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_person_inheritance_Constructor
{
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            :base(name)
        {
            Company = company;
        }
        public void Show2()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Company);
        }
    }
}
