using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_002
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение 1-й стороны прямоугольника в см, ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение 2-й стороны прямоугольника в см, ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle Instance1 = new Rectangle(side1, side2);
            Console.WriteLine("Периметр равен = {0}, Площадь равна = {1}", Instance1.Perimeter, Instance1.Area);

            Console.ReadKey();
        }

        

    }

}
