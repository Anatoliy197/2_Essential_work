using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_003
{
    class Content
    {
        private string name;
        public string Name
        {
            private get
            {
                if (name != null)
                    return name;
                else
                    return "Содержание книги отсутствует.";
            }
            set
            {
                name = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
