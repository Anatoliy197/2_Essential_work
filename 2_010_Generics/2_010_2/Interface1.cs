using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_010_2
{
    interface Interface1<T>
    {
        void Add();
        int this[int index]
        {
            get;
            set;
        }
        T Quant { get;}
    }
}
