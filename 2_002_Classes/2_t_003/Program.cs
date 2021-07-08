using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_003
{
    
    class Program
    {
        static void Main()
        {
            Employee instance1 = new Employee("Petrov","Ivan", "Junior Eng.", 3);
            Employee instance2 = new Employee("Vetrov", "Oleg", "Senior Eng.", 5);

            instance1.SalaryTax();
            Console.WriteLine(new string('-', 30));
            instance2.SalaryTax();


            Console.ReadKey();

        }
    }
}
