using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vrn_shilovo
{
    class Program
    {
        static void PuskKomp(int num_pk)
        {
            Console.WriteLine("ПК{0} Коммутаторы агрегации", num_pk);
            Console.WriteLine("sb{0}.vrn.pk{0}.sw1", num_pk);

            Console.WriteLine(new string('*', 40));

            Console.WriteLine("Коммутаторы доступа");

            for (int i = 1; i <= 66; i++)
            {
                Console.WriteLine("sa{1}.vrn.pk{0}", num_pk, i);
            }
            Console.WriteLine();

        }


        static void Main(string[] args)
        {
           PuskKomp(13);
           Console.ReadKey();
        }
    }
}
