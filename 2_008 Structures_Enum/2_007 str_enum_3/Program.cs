using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_007_str_enum_3
{
    enum Post
    {
        Engeneer = 100,
        Boss = 500,
        Cleaner = 20,
    }

    class Account
    {
        public bool GetBonus(Post worker, int hourse)
        {
            if(hourse > (int) worker)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
          

            //Console.Write("Выберите должность");
            //string postt = Console.ReadLine();

            Console.Write("Введите количество отработанных часов ");
            int hoursee = Convert.ToInt16(Console.ReadLine());

            Account ins1 = new Account();
            if(ins1.GetBonus(Post.Boss, hoursee))
            {
                Console.WriteLine("Дать премию");
            }
            else
            {
                Console.WriteLine("Не дать");
            }

            Console.ReadKey();
        }
    }
}
