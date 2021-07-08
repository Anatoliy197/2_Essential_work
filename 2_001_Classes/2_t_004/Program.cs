using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_004
{
    class Program
    {
        static void Main()
        {
            Figure figure = new Figure(new Point("A", 1, 2), new Point("B", 1, 5), new Point("C", 5, 5), new Point("D", 5, 2));
            Console.Write("{0}, P = ", figure.Type);
            
            figure.PerimeterCalculator();

            Console.ReadKey();

        }
    }
}
