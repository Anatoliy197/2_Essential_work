using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_weak_referense
{
    class Person
    {
        private string name = "Koker";
        private int age = 68;

        public void GetInfo()
        {
            Console.WriteLine("Имя: {0}, Возраст: {1}", name, age);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Instance1 = new Person(); // Создание экземпляра класса по сильной ссылке
            Instance1.GetInfo();
            
            new Person().GetInfo(); // Создание экземпляра класса по слабой ссылке

            Console.ReadKey();
        }
    }
}
