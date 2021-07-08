using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        static int retirementAge = 60;
        public static void ChangeRetirementAge(int years)
        {
            retirementAge += years;
        }
        public void DisplayRetirementAge()
        {
            Console.WriteLine(retirementAge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            Person.ChangeRetirementAge(-5);
            tom.DisplayRetirementAge();
            Console.Read();
        }
    }
}
