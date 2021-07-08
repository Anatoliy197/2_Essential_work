using System;

namespace ConsoleApp1
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person(string name)");
        }
        public Person(string name, int age) :this (name)
        {
            this.age = age;
            Console.WriteLine("Person(string name, int age)");
        }
    }
    class Employee : Person
    {
        string company;

        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Employee(string name, int age, string company)");
        }
        public void Show()
        {
            Console.WriteLine("Имя {0} Возраст {1} Компания {2}", name, age, company);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Ins = new Employee("Ivan",19,"Tybydox");
            Ins.Show();
          
            Console.ReadKey();
        }
    }
}
