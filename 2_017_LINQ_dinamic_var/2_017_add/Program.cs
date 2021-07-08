using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_017_add
{
    class Calc
    {
        public dynamic Add(dynamic x, dynamic y)
        {
            return x + y;
        }

        public dynamic Sub(dynamic x, dynamic y)
        {
            return x - y;
        }

        public dynamic Mul(dynamic x, dynamic y)
        {
            return x * y;
        }

        public dynamic Div(dynamic x, dynamic y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return "На ноль делить нельзя";
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic calc = new Calc();
            Console.WriteLine(calc.Add(5, 2));
            Console.WriteLine(calc.Sub(5.6, 2));
            Console.WriteLine(calc.Mul(5, 2.1358));
            Console.WriteLine(calc.Div(5, 2));

            Console.ReadKey();
        }
    }
}
