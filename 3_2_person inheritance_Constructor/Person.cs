using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_person_inheritance_Constructor
{
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            this.Name = name;
        }
        public void Show()
        {
            Console.WriteLine(Name);
        }
    }
}
