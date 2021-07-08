using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_016_Object_Operator
{

    public struct ThreePoint
    {
        public int x, y, z;

        public ThreePoint(int xX, int yY, int zZ)
        {
            x = xX;
            y = yY;
            z = zZ;
        }

        public static ThreePoint operator +(ThreePoint p1, ThreePoint p2)
        {
            return new ThreePoint(p1.x + p2.x, p1.y + p2.y, p1.z + p2.z);
        }
        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", this.x, this.y, this.z);
        }
    }
    class Programs
    {
        static void Main(string[] args)
        {
            ThreePoint one = new ThreePoint(12, 12, 14);
            ThreePoint two = new ThreePoint(2, 2, 1);

            ThreePoint res = one + two;

            Console.WriteLine("c = {0}", res);
            Console.ReadKey();
        }
    }
}
