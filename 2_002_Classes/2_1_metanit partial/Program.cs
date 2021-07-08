using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_metanit_partial
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Ivan = new Person();

            Ivan.Eat();
            Ivan.Riding();
            Ivan.StartFinish();

            Console.ReadKey();
        }
    }
}
