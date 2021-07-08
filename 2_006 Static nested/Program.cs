using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_006_Static_nested
{
    class Book
    {
        public class Notes
        {
            string textnote = "";
            public string Textnote
            {
                get
                {
                    return textnote;
                }

                set
                {
                    if (textnote != "")
                        textnote += "\n";
                    textnote += value;

                }
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            Book.Notes Ins1 = new Book.Notes();
            Ins1.Textnote = "note a";
            Ins1.Textnote = "note b";

            Console.WriteLine(Ins1.Textnote);

            Console.ReadKey();

        }
    }
}
