using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_014_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> mylist = new List<int>() { 2, 3, 4, 9, 11 };
            mylist.Add(0);
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Длина массива = {0}", mylist.Count);

            Console.ReadKey();
        }
    }
}
