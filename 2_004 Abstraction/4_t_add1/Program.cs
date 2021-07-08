using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_t_add1
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Контракт");
            document.Body = "Тело контракта";
            document.Footer = "Директор Иванов А. А.";
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
