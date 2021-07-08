using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_004
{
    class Invoice
    {
        int sum;
        
        public readonly int account = 100;
        public readonly string customer = "Rossety";
        public readonly string provider = "RAO EAC";

        // public Invoice()
        // {
        // account = 400;
        //customer = "Shevchenko";
        // provider = "TNS Energy";
        //}

        private string Article { get; } = "En_KVT";
        private int Quantity { get; } = 8;

        public void AddedTax()
        {
            double nds = 1.2;
            sum = account * Quantity;
            Console.WriteLine("сумма без НДС = {0}", sum);
            Console.WriteLine("сумма c НДС 20% = {0}", sum*nds);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Invoice instance1 = new Invoice();
            Console.WriteLine(instance1.account);
            Console.WriteLine(instance1.customer);
            Console.WriteLine(instance1.provider);

            instance1.AddedTax();

            Console.ReadKey();


        }
    }
}
