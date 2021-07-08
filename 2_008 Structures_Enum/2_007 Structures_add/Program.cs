using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_007_Structures_add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите дату дня рождения в этом году: ");

            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Now;

            TimeSpan remain = birthday - today;
            Console.WriteLine("До ДР осталось дней: " + remain.Days);

            Console.ReadKey();

        }
    }
}
