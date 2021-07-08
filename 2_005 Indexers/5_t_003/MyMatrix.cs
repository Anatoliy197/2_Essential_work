using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _5_t_003
{
    class MyMatrix //программа НЕДОДЕЛАНА!!!!
    {
        private int[,] array;
        public MyMatrix(int a, int b) //Пользовательский конструктор принимающий два параметра целого типа
        {
            Random random = new Random();
            array = new int[Math.Abs(a), Math.Abs(b)];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] = random.Next(10,90);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            } 
        }
        public void ChangeMatrix(int row, int col) //Метод изменения размера матрицы
        {
            if (row <= 0 || col <= 0)
            {
                Console.WriteLine("Размеры матрици не могут быть меньшими или равными нулю");
                return;
            }
        }
        public void ShowPartly(int startRow, int startCol, int endRow, int endCol) //Метод частичного отображения матрицы. Принимает в качестве аргументов координаты начальной и конечной точки
        {
            if (startRow < 0 || startCol < 0 || endRow > array.Length || endCol > array.Length) //Проверка валидности полученных аргументов
            {
                Console.WriteLine("Попытка обращения за пределы массива.");
                return;
            }

            if (startRow > endRow || startCol > endCol) //Проверка размещена ли конечная точка раньше начальной
            {
                Console.WriteLine("Неверно заданы координаты конечной точки");
                return;
            }

            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                    Console.Write("{0} ", array[i, j]); //Отображение матрицы нужного размера
                Console.Write("\n");
            }
        }

        public void Show() //Метод отображения всей матрицы matrix
        {
            ShowPartly(0, 0, array.GetLength(0), array.GetLength(1)); //Для отображения вызывается метод ShowPartly и ему передаются 4 параметра - начала и конца матрицы.
            int a = array.Length;
        }

        public int this[int index1, int index2]
        {
            get
            {
                return array[index1, index2];
            }

            set
            {
                array[index1, index2] = value;
            }
        }
    }
}
