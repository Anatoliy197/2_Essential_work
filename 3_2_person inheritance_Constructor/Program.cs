using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_person_inheritance_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person One = new Person("Ivan");
            One.Show();
            Console.WriteLine("-", 30);
            Employee Two = new Employee("Vovan", "CVE");
            Two.Show2();

            Console.ReadKey();
        }
    }
}
