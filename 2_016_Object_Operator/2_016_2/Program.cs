using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_016_2
{
    class Block
    {
        int a, b, c, d;
        public Block(int A, int B, int C, int D)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Block p = (Block)obj;
            return (a == p.a) && (b == p.b) && (c == p.c) && (d == p.d);
        }
        public override int GetHashCode()
        {
            return a ^ b ^ c ^ d;
        }
        public override string ToString()
        {
            return "Стороны прямоугольника равны : " + a + " " + b + " " + c + " " + d ;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Block one = new Block(5, 8, 5, 8);
            Block two = new Block(5, 8, 6, 8);

            Console.WriteLine("Блок 1 равен блоку 2 - {0}",one.Equals(two));
            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());

            Console.ReadKey();

        }
    }
}
