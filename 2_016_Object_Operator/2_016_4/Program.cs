using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_016_4
{
    class DateInfo
    {
        DateTime d1 = new DateTime(2021, 5, 19);
        DateTime d2 = new DateTime(2021, 5, 31);

        public static DateTime operator +(DateTime d1, DateTime d2)
        {
            return new DateTime(d1.Year + d2.Year, d1.Month + d2.Month, d1.Day + d2.Day);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
