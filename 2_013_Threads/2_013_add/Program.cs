using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2_013_add
{
    class Program
    {
        static int count;

        static void Recursion()
        {
            Console.WriteLine("{0} Поток {1} говорит \"привет!\"", count, Thread.CurrentThread.GetHashCode());
            Thread.Sleep(1000);
            Thread threadSec = new Thread(Recursion);
            count++;
            threadSec.Start();

        }

        static void Main(string[] args)
        {
            Thread threadOne = new Thread(Recursion);
            threadOne.Start();

            Console.ReadKey();
        }
    }
}
