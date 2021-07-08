using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Person
    {
       
        public string name; // имя
        public int age;     // возраст

        public Person() : this("Неизвестно")
        {
        }
        public Person(string name) : this(name, 18)
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }



        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();          // вызов 1-ого конструктора без параметров
            Person bob = new Person("Bob");     //вызов 2-ого конструктора с одним параметром
            Person sam = new Person("Sam", 25); // вызов 3-его конструктора с двумя параметрами


            bob.GetInfo();          // Имя: Bob  Возраст: 18
            tom.GetInfo();          // Имя: Неизвестно  Возраст: 18
            sam.GetInfo();          // Имя: Sam  Возраст: 25
            Console.ReadKey();
        }
    }
    
}
