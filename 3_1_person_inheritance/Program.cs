using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_person_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person One = new Person { Name = "Ivan", Age=19 };
            One.Show();
            Console.WriteLine("-", 30);
            One = new Employee { Name = "Boban", Age =3 };
            One.Show();

            Console.ReadKey();
            
        }
    }
}
