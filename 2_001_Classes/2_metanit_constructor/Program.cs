using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_metanit_constructor
{
    class Person
    {
        //private string name;  Используется автосвойство, поэтому переменная не используется
        private int age;

        public string Name { get; } //Автосвойство
        public int Age
        {
            get { return age; }
        }

        public Person(string name, int age)
        {
            Name = name; // Используется автосвойство
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ivan", 18); //Пользовательский конструктор с параметрами
            Console.WriteLine("Имя: {0} Возраст: {1}", person1.Name, person1.Age);

            Console.ReadKey();
        }
    }
}
