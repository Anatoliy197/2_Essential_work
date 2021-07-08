using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_person_enapsulation
{
    class Person
    {
        private void Secret()
        {
            Console.WriteLine("I am writing secret letter");
        }

        public void Write()
        {
            Console.WriteLine("Writing");
            Secret();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person Ivan = new Person();
            Ivan.Write();

            Console.ReadKey();
        }
    }
}
