using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_metanit_constructor_this
{
    class Person
    {

        public string Name { get; } 
        public int Age { get; }

        public string Sex { get; }

        public Person(string name, int age)
        {
            Name = name; 
            Age = age;
        }
        public Person(string sex) : this("Ivan", 18)
        {
            Sex = sex;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("мужской");
            Console.WriteLine("Имя: {0} Возраст: {1} Пол: {2}", person1.Name, person1.Age, person1.Sex);

            Console.ReadKey();
        }
    }
}
