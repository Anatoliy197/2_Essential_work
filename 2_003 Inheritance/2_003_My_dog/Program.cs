using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_003_My_dog
{
    class Dog
    {
        public string name;
        public void Bark()
        {
            Console.WriteLine(name);
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("gav!!!");
            }
        }
            
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Dog rottweiler = new Dog();
            rottweiler.name = "Гризли";
            rottweiler.Bark();

            Console.ReadKey();
        }
    }
}
