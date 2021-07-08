using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_010_metanit_1
{
    class Account<T,R>
    {
        public T Id { get; set; }
        public R Sum { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account<int,int> account1 = new Account<int,int> { Id = 2, Sum = 5000 };
            Account<string,int> account2 = new Account<string,int> {Id = "djflkd", Sum = 4000 };
            //account1.Id = 2;        // упаковка не нужна
            //account2.Id = "4356";
            int id1 = account1.Id;  // распаковка не нужна
            string id2 = account2.Id;
            Console.WriteLine(id1);
            Console.WriteLine(id2);

            Console.ReadKey();
        }
    }
}
