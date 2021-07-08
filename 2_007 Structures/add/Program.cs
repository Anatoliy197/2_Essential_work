using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    struct Notebook
    {
        public string model;
        public string manufacturer;
        public int price;

        public Notebook(string model, string manufacturer, int price) // пользовательский конструктор
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Модель:{model}");
            Console.WriteLine($"Производитель:{manufacturer}");
            Console.WriteLine($"Цена:{price}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook ins1 = new Notebook("MG_56K", "Asus", 1000);
            ins1.Display();

            Console.ReadKey();
        }
    }
}
