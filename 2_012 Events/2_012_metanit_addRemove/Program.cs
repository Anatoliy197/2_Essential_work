using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_012_metanit_addRemove
{

    class Account
    {
        public delegate void AccountHandler(string message);
        private event AccountHandler _notify;
        public event AccountHandler Notify
        {
            add //Аксессор add вызывается при добавлении обработчика, то есть при операции +=. 
                //Добавляемый обработчик доступен через ключевое слово value. 
                //Здесь мы можем получить информацию об обработчике (например, имя метода через value.Method.Name) и определить некоторую логику. 
                //В данном случае для простоты просто выводится сообщение на консоль:
            {
                _notify += value;
                Console.WriteLine($"{value.Method.Name} добавлен");
            }
            remove //Блок remove вызывается при удалении обработчика. 
            {
                _notify -= value;
                Console.WriteLine($"{value.Method.Name} удален"); //Аналогично здесь можно задать некоторую дополнительную логику:
            }
        }
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sumput)
        {
            Sum += sumput;
            _notify?.Invoke($"На счет поступило: {sumput}");
        }

        public void Take(int sumtake)
        {
            if (Sum >= sumtake)
            {
                Sum -= sumtake;
                _notify?.Invoke($"Со счета снято: {sumtake}");
            }
            else
            {
                _notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Notify += DisplayMessage;       // добавляем обработчик DisplayMessage
            acc.Put(20);    // добавляем на счет 20
            acc.Notify -= DisplayMessage;     // удаляем обработчик DisplayRedMessage
            acc.Put(20);    // добавляем на счет 20

            Console.ReadKey();
        }
        private static void DisplayMessage(string message) => Console.WriteLine(message); // метод Обработчик события
    }
}
