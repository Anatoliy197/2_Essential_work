using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_009_Delegates
{
    public delegate int DelegateAverage(int x, int y, int z);

    class Program
    {
        static void Main(string[] args)
        {
            DelegateAverage average;
            average = (x, y, z) => { return (x+y+z)/3; };

            int result = average(4,9,8);
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
