using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_006_2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }

    static class FindandReplaceManager
    {
        public static void FindNext(string str)
        {
            Book ins1 = new Book();
            ins1.FindNext(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FindandReplaceManager.FindNext("fix");
            Console.ReadKey();
        }
    }
}
