using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_012_metanit.Account;

namespace _2_012_metanit
{
    class Account
    {
        public delegate void AccHandler(string serv_message);
        public event AccHandler Accevent;

        public int Sum { get; private set; } // свойство 
        public Account(int sum) // конструктор
        {
            this.Sum = sum;
        }

        public void Put(int sumput) // метод для внесения средств
        {
            Sum += sumput;
            Accevent?.Invoke($"На счет поступило: {sumput}");   // 2.Вызов события 
        }

        public void Take (int sumtake) // метод для внесения средств
        {
            if(sumtake <= Sum)
            {
                Sum -= sumtake;
                Accevent?.Invoke($"Со счета снято: {sumtake}");   // 2.Вызов события
            }
            else
            {
                Accevent?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}") ;
            }
            
        }

    }
    class Program
    {
        //private static void DisplayMessage(string message)
        //{
        //    Console.WriteLine(message);
        //}
        static void Main(string[] args)
        {
            Account account1 = new Account(1000);
            //account1.Accevent += new AccHandler(Account1_Accevent); // 1-й способ  // установка делегата, который указывает на метод Account1_Accevent
            account1.Accevent += Account1_Accevent;            // 2-й способ  // установка в качестве обработчика метода Account1_Accevent
            account1.Put(24000);
            Console.WriteLine($"На вашем счетe: {account1.Sum} рублей");
            account1.Take(18000);
            Console.WriteLine($"На вашем счетe: {account1.Sum} рублей");
            account1.Take(60000);
            Console.WriteLine($"На вашем счетe: {account1.Sum} рублей");

            Console.ReadKey();
        }
        private static void Account1_Accevent(string serv_message)
        {
            Console.WriteLine(serv_message);
        }
    }
}
