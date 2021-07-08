using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void PuskKomp(int[] num_pk, int[] num_ring)
        {
            for(int k = 0; k<num_pk.Length; k++)
            {
                Console.WriteLine("ПК{0}", num_pk[k]);
                Console.WriteLine("sb0{0}.elc.0{0}35", num_pk[k]);

                Console.WriteLine(new string('*', 40));

                for (int i = 0; i < num_ring.Length; i++)
                {
                    Console.WriteLine("Кольцо №{0}", num_ring[i]);
                    int sw = 6;
                    for (int counter = 1; counter <= sw; counter++)
                    {
                        Console.WriteLine("sa{0}{2}.elc.0{1}{0}{2}", num_ring[i], num_pk[k], counter);
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            PuskKomp(new int[6] { 2, 3, 4, 5, 6, 7 }, new int[6] { 1, 2, 3, 4, 5, 6 });
            Console.ReadKey();
        }
    }
}
