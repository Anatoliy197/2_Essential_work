using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_012_4
{
    class Model4
    {
        public string Add(int x, int y)
        {
            return (x+y).ToString();
        }

        public string Sub(int x, int y)
        {
            return (x - y).ToString();
        }

        public string Mult(int x, int y)
        {
            return (x * y).ToString();
        }

        public string Div(int x, int y)
        {
            if(y!=0)
            {
                return ((double)x / y).ToString();
            }
            else
            {
                return "На ноль делить нельзя!";
            }
        }
    }
}
