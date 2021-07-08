using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_014_add
{
    class Program
    {
        static IEnumerable MethReturnEven(int[] numbers)
        {
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    yield return numbers[i];
                }

            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 6, 9, 10 };
            IEnumerable result = MethReturnEven(numbers);
            Console.Write("Четные элементы массива: ");
            foreach (int el in result)
            {
                Console.Write(" {0},", el);
            }
            

            //MethReturnEven(numbers);

            Console.ReadKey();
        }

    }

    class ArrayMy
    {
        
    }
}
