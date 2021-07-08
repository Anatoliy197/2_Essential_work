using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_009_3
{
    class Program
    {
        delegate int Del(int x);
        delegate double ArrDel(Del[] a);

        static int GetRandom()
        {
            Random random = new Random();
            return random.Next(10, 99);
        }

        static void Main(string[] args)
        {

            //ArrDel inst1 = FillArray;

            Console.Write("Введите число элементов массива: ");
            int z = Convert.ToInt32(Console.ReadLine());
            Del [] inst1 = new Del[z];

            //int[] array = new int[z];
            Console.WriteLine(new string('-', 30));

            for (int i = 0; i < z; i++) // заполнение элементов массива
            {
                inst1[i] = new Del(GetRandom);
                inst1();

            }

            for (int i = 0; i < array.Length; i++) // вывод на экран элементов массива
            {
                Console.Write("{0} ",array[i]);
            }

            Console.WriteLine();
            Console.Write("Среднее арифметическое массива: ");
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.Write(" {0}", sum / array.Length);

            Console.ReadKey();
        }
    }
}
