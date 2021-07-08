using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_009_2_deleg
{
    public delegate float Arithmetic(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic del;

            Console.WriteLine("Введите 1-е число");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите 2-е число");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Выберите арифметическое действие (+, -, *, / )");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "+":
                    {
                        //del = (x,y) => { return x + y; };          // Лямбда-Оператор.
                        del = (x, y) => x + y;                        // Лямбда-Выражение.

                        float result = del(a, b);
                        Console.WriteLine(result);
                        break;
                    }
                case "-":
                    {
                        del = (x, y) => { return x - y; };          // Лямбда-Оператор.
                        float result = del(a, b);
                        Console.WriteLine(result);
                        break;
                    }
                case "*":
                    {
                        del = (x, y) => { return x * y; };          // Лямбда-Оператор.
                        float result = del(a, b);
                        Console.WriteLine(result);
                        break;
                    }
                case "/":
                    {
                        if (b != 0)
                        {
                            del = (x, y) => { return x / y; }; // Лямбда-Оператор.
                            float result = del(a, b);
                            Console.WriteLine(result);
                        }
                        else
                        {
                            Console.WriteLine("На нуль делить нельзя!");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели недопустимое значение.");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
