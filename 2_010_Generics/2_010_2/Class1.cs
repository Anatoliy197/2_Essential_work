using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_010_2
{
    class Class1<T>:Interface1<T>
    {
        public void Add()
        {
            Console.WriteLine("Метод добавления элемента");
        }

        private int[] array = new int[3];
        public int this[int index]  
        {
            get => array[index];
            set => array[index] = value;
        }
    }
}
