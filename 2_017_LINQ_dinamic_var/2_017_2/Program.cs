using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_017_2
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }

    public class AutoCustomer
    {
        public string Model { get; set; }
        public string NameofCustomer { get; set; }
        public int NumberCustomer { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car { Brand = "Ford", Model = "Focus",  Year = 2009, Color = "Red"  },
                new Car { Brand = "Mazda", Model = "M6",  Year = 2014, Color = "Black"  },
                new Car { Brand = "Lada", Model = "Vesta",  Year = 2021, Color = "blue" },
                new Car { Brand = "GM", Model = "Aveo",  Year = 2011, Color = "blue" },

            };

            var autocustomers = new List<AutoCustomer>
            {
                new AutoCustomer { Model = "Focus",  NameofCustomer = "Gaichev", NumberCustomer = 2507 },
                new AutoCustomer { Model = "Vesta",  NameofCustomer = "Smirnov", NumberCustomer = 1005 },
                new AutoCustomer { Model = "Mazda",  NameofCustomer = "Mordin", NumberCustomer = 4403 },
                new AutoCustomer { Model = "Vesta",  NameofCustomer = "Geev", NumberCustomer = 1603 },

            };

            var query = from cr in cars
                        join a in autocustomers
                        on cr.Model equals a.Model
                        where cr.Model == "Vesta"
                        select new
                        {
                            Model = cr.Model,
                            NameofCustomer = a.NameofCustomer,
                            NumberCustomer = a.NumberCustomer,
                            Brand = cr.Brand,
                            Year = cr.Year,
                            Color = cr.Color
                        };

            Console.WriteLine("Владельцы Веста:");

            foreach (var item in query)
                Console.WriteLine(item);

            // Delay.
            Console.ReadKey();
        }
    }
}
