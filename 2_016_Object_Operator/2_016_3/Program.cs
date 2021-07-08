using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_016_3
{
    class House
    {
        public static string City = "Voronezh";
        public int number;
        public string street;

        //public House(int Number, string Street)
        //{
        //    this.number = Number;
        //    this.street = Street;
        //}
    
    }

    
    class Program: House
    {
        static void Main(string[] args)
        {
            Program original = new Program();
            original.number = 18;
            original.street = "Революции";
            Console.WriteLine(Program.City + " " + original.street + " " + original.number);

            Program clone = original.MemberwiseClone() as Program;
            Console.WriteLine(Program.City + " " + clone.street + " " + clone.number);

            clone.number = 1;
            clone.street = "Красная площадь";
            House.City = "Москва";

            Console.WriteLine(Program.City + " " + original.street + " " + original.number);
            Console.WriteLine(Program.City + " " + clone.street + " " + clone.number);


            Console.ReadKey();
        }
    }
}
