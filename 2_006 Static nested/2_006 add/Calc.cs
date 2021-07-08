using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_006_add
{
    static class Calc
    {
        public static float Sum (float x, float y)
        {
            return x + y;
        }

        public static float Subtraction (float x, float y)
        {
            return x - y;
        }

        public static float Multiply (float x, float y)
        {
            return x * y;
        }

        public static float Division(float x, float y)
        {
            //if (y == 0)
            //    Console.WriteLine("на ноль делить нельзя!!!");
            return x / y;
        }
    }
}
