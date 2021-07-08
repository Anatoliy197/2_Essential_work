using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_017_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<dynamic, dynamic>
            {
                {new{key = "socks"}, new {value = "носки"} },
                {new{key = "table"}, new {value = "стол"} },
                {new{key = "gold"}, new {value = "золото"} },
                {new{key = "brother"}, new {value = "брат"} },

            };

            foreach (var d in dict)
                Console.WriteLine("{0} - {1}", d.Key, d.Value);

            Console.ReadKey();
        }
    }
}
