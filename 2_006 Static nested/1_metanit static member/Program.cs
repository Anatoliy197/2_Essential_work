using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_metanit_static_member
{
    class Account
    {
        public static decimal bonus = 100; // статическое поле
        public decimal totalSum;
        public Account(decimal sum)
        {
            totalSum = sum + bonus;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Account.bonus);      // 100
            Account.bonus += 200;

            Account account1 = new Account(150);
            Console.WriteLine(account1.totalSum);   // 450


            Account account2 = new Account(1000);
            Console.WriteLine(account2.totalSum);   // 1300

            Console.ReadKey();
        }
    }
}
