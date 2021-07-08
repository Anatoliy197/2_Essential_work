using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_002
{

    class Program
    {
        static void Main(string[] args)
        {
            Converter exchange1 = new Converter(61.8, 68.8);
            exchange1.Tousd(200);
            exchange1.Fromusd(200);

            exchange1.Toeur(200);
            exchange1.Fromeur(200);

            Console.ReadKey();

        }
    }
}
