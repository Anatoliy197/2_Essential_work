using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_006_add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calc.Sum(55, 45));
            Console.WriteLine(Calc.Subtraction(75, 45));
            Console.WriteLine(Calc.Multiply(5, 4));
            Console.WriteLine(Calc.Division(55, 0));

            Console.ReadKey();
        }

    }
}
