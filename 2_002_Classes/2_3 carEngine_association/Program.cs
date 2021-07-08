using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_carEngine_association
{
    class Engine
    {
        int power;
        public Engine(int p)
        {
            power = p;
        }
    }

    class Car
    {
        string model = "Porshe";
        Engine engine;
        public Car()
        {
            this.engine = new Engine(360);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car Ins1 = new Car();
            Console.WriteLine("")
        }
    }
}
