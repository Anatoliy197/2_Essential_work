using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_004
{
    class Figure
    {
        Point[] point;
        string type;
        public string Type
        {
            get
            {
                return type;
            }
        }

        double LenghtSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
        }
        public void PerimeterCalculator()
        {
            double sum = 0;

            for (int i = 0; i < point.Length - 1; i++)
            {
                sum += LenghtSide(point[i], point[i + 1]);
            }
            sum += LenghtSide(point[point.Length - 1], point[0]);
            Console.Write(sum);
        }
        public Figure (Point p1, Point p2, Point p3)
        {
            point = new Point[3];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            type = "Triangle";
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            point = new Point[4];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            type = "Tetragon";
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            point = new Point[5];
            point[0] = p1;
            point[1] = p2;
            point[2] = p3;
            point[3] = p4;
            point[4] = p5;
            type = "Pentagon";
        }

    }
}
