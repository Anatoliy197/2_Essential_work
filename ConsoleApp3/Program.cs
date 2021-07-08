using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);
            }

            int[] numbers2 = new int[] { 21, 22, 23, 24, 25 };
            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

        }
    }
}
