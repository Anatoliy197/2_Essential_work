using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_003_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer_2 magenta = new Printer_2();
            magenta.Print("Hello");

            Console.ReadKey();
        }
    }
}
