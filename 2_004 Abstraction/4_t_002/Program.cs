
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_t_002
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler abstractHandler = new XMLHandler();
            //abstractHandler.Open();

            Console.Write("Выберите формат файла: ");
            string format = Console.ReadLine();

            switch(format)
            {
                case "XML":
                    abstractHandler = new XMLHandler();
                    abstractHandler.Open();
                    abstractHandler.Create();
                    abstractHandler.Change();
                    abstractHandler.Save();
                    break;
                case "TXT":
                    abstractHandler = new TXTHandler();
                    abstractHandler.Open();
                    abstractHandler.Create();
                    abstractHandler.Change();
                    abstractHandler.Save();
                    break;
                case "DOC":
                    abstractHandler = new DOCHandler();
                    abstractHandler.Open();
                    abstractHandler.Create();
                                        abstractHandler.Change();
                    abstractHandler.Save();
                    break;
                default:
                    Console.WriteLine("Формат не выбран");
                    break;
            }

            Console.ReadKey();
        }
    }
}
