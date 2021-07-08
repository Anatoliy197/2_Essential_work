using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_t_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Array_N one = new Array_N(9);

            one.Odd_number();
            one.Summ();
            one.Average();
            one.Max_Min();

            Console.ReadKey();
        }
    }
}
