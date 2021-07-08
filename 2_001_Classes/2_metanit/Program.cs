using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_metanit
{
    class Person
    {
        public string name; // имя
        public int age = 18;     // возраст

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Instance1 = new Person();
            Instance1.name = "aich";
            Instance1.age = 21;

            Instance1.GetInfo();
            Console.ReadKey();
        }
    }
}
