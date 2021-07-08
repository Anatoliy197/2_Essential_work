using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_003_Inheritance
{
    class Printer
    {
        public string value;
        protected ConsoleColor console;
        public void Print(string value)
        {
            //this.value = value;
            Console.WriteLine(value);
        }
    }
}
