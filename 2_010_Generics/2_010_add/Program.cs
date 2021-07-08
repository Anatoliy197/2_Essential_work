using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_010_add
{
    class MyClass<T> where T : new()
    {
       public static T FactoryMethod() 
        {
            return new T();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = MyClass<int>.FactoryMethod();
            Console.WriteLine(a.GetType().FullName);
            Program b = MyClass<Program>.FactoryMethod();
            Console.WriteLine(b.GetType().FullName);

            Console.ReadKey();
        }
    }
}
