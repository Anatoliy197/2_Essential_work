using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_t_003
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane instance = new Plane(2052000, 830, 2002, 100);
            instance.Show();

            Console.WriteLine(new string('*', 30));

            Car instance2 = new Car();
            instance2.Show();

            Console.WriteLine(new string('*', 30));

            Ship instance3 = new Ship();
            instance3.Show();

            Console.ReadKey();
        }
    }
}
