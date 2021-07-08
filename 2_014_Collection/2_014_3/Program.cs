using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_014_3
{
    class Program  //ПРОГРАММА НЕДОДЕЛАНА!!!!!!!!!!!!!
    {
        static void Main(string[] args)
        {
            MyDict<int, string> countries = new MyDict<int, string>(5);
            countries.Add(1, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "China");

            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

            //// получение элемента по ключу
            //string country = countries[4];
            //// изменение объекта
            //countries[4] = "Spain";
            //// удаление по ключу
            //countries.Remove(2);

            Console.ReadKey();
        }
    }
}
