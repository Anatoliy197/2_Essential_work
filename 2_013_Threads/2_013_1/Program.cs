using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2_013_1
{
    class Program
    {
        const string litters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //Статическое строковое поле
        //Random rand;
        //private char GetChar()//Метод возвращающий 
        //{
        //    return litters.ToCharArray()[rand.Next(0, 35)]; //Возвращает оодно значение из строкового поля litters
        //}
        static void Three()
        {
            while (true)
            {
                Random rand = new Random();
                var r = litters.ToCharArray()[rand.Next(0, 35)];
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(new string(' ', 5) + r);
                Thread.Sleep(400);
            }
        }

        static void WriteSecond()
        {
            while (true)
            {
                for (int x = 0; x < 100; x++)
                {
                    Random rand = new Random();
                    var r = litters.ToCharArray()[rand.Next(0, 35)];
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(new string(' ', 2) + r);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string(' ', 2) + r);
                    Thread.Sleep(200);

                }
            }
        }

        static void Main()
        {
            ThreadStart writeSecond = new ThreadStart(WriteSecond);
            Thread thread = new Thread(writeSecond);
            ThreadStart three = new ThreadStart(Three);
            Thread thread2 = new Thread(three);
            thread.Start();
            thread2.Start();

            while (true)
            {
                Random rand = new Random();
                var r = litters.ToCharArray()[rand.Next(0, 35)];

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(r);
                Thread.Sleep(500);

            }
            // Delay.
            Console.ReadKey();
        }
    }
}
