using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_metanit_partial
{
    partial class Person
    {
        public void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public void StartFinish()
        {
            Console.WriteLine("Start");
            Running();
            Console.WriteLine("Finish");
        }
        partial void Running();
    }
}
