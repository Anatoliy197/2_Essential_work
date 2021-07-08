using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_metanit_properties
{
    class Auto
    {
        //private string model;
        public string Model
        {
            set
            {
                Model = value;
            }

            get
            {
                return Model;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Auto Ins1 = new Auto();
            Ins1.Model = "Ford";
            Console.WriteLine(Ins1.Model);

            Console.ReadKey();
        }
    }
}
