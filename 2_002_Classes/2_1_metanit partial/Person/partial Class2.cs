using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_metanit_partial
{
    partial class Person
    {
        public void Riding()
        {
            Console.WriteLine("I am riding a bicycle");
        }

        partial void Running()
        {
            Console.WriteLine("I am running");
        }
    }
}
