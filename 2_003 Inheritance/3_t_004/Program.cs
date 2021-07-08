using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_t_004
{
    class Program
    {
        static void Main(string[] args)
        {
            ProDocumentWorker instance = new ProDocumentWorker();
            string password_Pro = "pro";
            string password_Exp = "exp";

            Console.Write("Введите пароль: ");
            string usersPassword = Console.ReadLine();

            if(usersPassword == password_Pro)
            {
                Console.WriteLine("Здравствуйте, вы вошли в систему Pro");
                instance.EditDocument();

            }
            else if (usersPassword == password_Exp)
            {
                Console.WriteLine("Здравствуйте, вы вошли в систему Exp");
            }
            else
            {
                Console.WriteLine("Вы можете пользоваться только базовой версией");
            }

            Console.ReadKey();

        }
    }
}
