using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_009_3A
{
    //public delegate int MyDelegate(int x);
    class Program //!!! ПРОГРАММА РАБОТАЕТ НЕ КОРРЕКТНО!!!
    {
        delegate int Arr();
        delegate int MyDel(Arr[] y);

        static Random random = new Random();
        static int GetRandom()
        {
            return random.Next(9);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число элементов массива: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Arr[] array = new Arr[a];

            Console.WriteLine(new string('-', 30));

            for (int i = 0; i < array.Length; i++) // заполнение элементов массива
            {
                array[i] = () => new Arr(GetRandom).Invoke();
            }

            for (int i = 0; i < array.Length; i++) // вывод на экран элементов массива
            {
                Console.Write("{0} ", array[i].Invoke());
            }
            Console.WriteLine();

            MyDel del = delegate (Arr[] s) {
                Console.Write("Среднее арифметическое массива: ");
                int sum = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    sum = sum + s[i].Invoke();
                }
                return sum / array.Length;
            };

            Console.WriteLine("среднее арифметическое {0}", del(array)); //Отображение результата вычисления среднего арифметического

            Console.ReadKey();
        }
    }
}
