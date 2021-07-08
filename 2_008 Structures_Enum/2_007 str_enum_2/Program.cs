using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_007_str_enum_2
{
    static class Workcolor
    {
        public static void Print(string stroka, int color)
        {
            switch(color)
            {
                case (int)Colors.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case (int)Colors.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case (int)Colors.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            Console.WriteLine(stroka);
        }
    }

    enum Colors
    {
        White = 1,
        Yellow,
        Cyan,
        Red,
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите текст:  ");
            string text = Console.ReadLine();

            Console.Write("Выберите цвет (White - 1, Yellow - 2, Cyan - 3, Red - 4:  ");
            int choicecolor = Convert.ToInt16 (Console.ReadLine());
            
            Workcolor.Print(text, choicecolor);

            Console.ReadKey();
        }
    }
}
