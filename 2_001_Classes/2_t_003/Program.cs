using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_003
{
   
    class Programm
    {
        static void Main()
        {

            Title title = new Title();
            title.Name = "Солдатский долг";

            Author author = new Author();
            author.Name = "Рокосовский К. К.";

            Content content = new Content();
            content.Name = "1941 - 1945......";

            Book book = new Book(title, author, content);
            book.Show();
            

            Console.ReadKey();
        }
    }
        
}
    
    