using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_add1_001
{
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Address instance = new Address();

            instance.Index = "394028";
            Console.WriteLine(instance.Index);
            instance.Country = "Russia";
            Console.WriteLine(instance.Country);
            instance.City = "Moscow";
            Console.WriteLine(instance.City);
            instance.Street = "Tverskaya";
            Console.WriteLine(instance.Street);
            instance.House = "29";
            Console.WriteLine(instance.House);
            instance.Apartment = "159";
            Console.WriteLine(instance.Apartment);

            Console.ReadKey();
        }
    }
}
