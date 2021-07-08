using System;

namespace _5_t_003
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix one = new MyMatrix(7, 8);

            Console.WriteLine(new string('-', 30)); 
            Console.WriteLine("[1][2] = {0}", one[1, 2]); 
            Console.WriteLine("[6][2] = {0}", one[6, 2]);
            one[1, 1] = 11; //Присвоение полю с координатами (0,0) значения 11
           

            Console.WriteLine(new string('-', 30));
            one.ChangeMatrix(10, 15); //Вызов метода изменения размерности матрицы
            one.Show();

            one.ShowPartly(1, 0, 4, 4);
            Console.ReadKey();
        }
    }
}
