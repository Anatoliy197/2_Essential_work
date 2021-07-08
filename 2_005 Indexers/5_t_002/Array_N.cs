using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_t_002
{
    class Array_N
    {
        public int[]array;
        public Array_N(int n) //Конструктор
        {
            array = new int[Math.Abs(n)];
            Random random = new Random();
            Console.Write("Элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write("{0} ", array[i]); 
            }
        }

        public void Odd_number()
        {
            Console.WriteLine();
            Console.Write("Нечетные элементы массива: ");
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] % 2 == 1)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
        }

        public void Summ()  // int здесь для применения суммы элементов в следующем методе для нахождения среднего арифм.
        {
            Console.WriteLine();
            Console.Write("Суммма элементов массива: ");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.Write(" {0}", sum);
        }

        public void Average()
        {
            Console.WriteLine();
            Console.Write("Среднее арифметическое массива: ");
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.Write(" {0}", sum/ array.Length);
        }

        public void Max_Min()
        {
            Console.WriteLine();
            Console.Write("Максимальное значение массива: ");
            int max = int.MinValue;
            foreach (int a in array)
            {
                if (a > max)
                {
                    max = a;
                }
            }
            Console.Write(" {0}", max);

            Console.WriteLine();
            Console.Write("Минимальное значение массива: ");
            int min = int.MaxValue;
            foreach (int a in array)
            {
                if (a < min)
                {
                    min = a;
                }
            }
            Console.Write(" {0}", min);

        }

    }
}
