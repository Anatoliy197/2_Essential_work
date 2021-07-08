using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_002
{
    class User
    {
        string login, first_name, second_name, age;
        public readonly DateTime date_completion;

        public string Login { get; set; }
        public string First_name { get; set; }
        public string Second_name { get; set; }
        public string Age { get; set; }



        public void Method()
        {
            Console.WriteLine(login);
            Console.WriteLine(first_name);
            Console.WriteLine(second_name);
            Console.WriteLine(age);
            Console.WriteLine(date_completion);
        }

        public User()
        {
            date_completion = DateTime.Now;
        }
        public User(string login, string first_name, string second_name, string age)
        {
            this.login = login;
            this.first_name = first_name;
            this.second_name = second_name;
            this.age = age;

            date_completion = DateTime.Now;
        }
    }

    class Programm
    {
        static void Main()
        {
            User User1 = new User("vd", "Vladimir", "Taranov", "29");
            //User1.Login = "ap";
            //User1.First_name = "Alexey";
            //User1.Second_name = "Popov";
            //User1.Age = "34";

            User1.Method();

            Console.WriteLine(new string ('-', 30));

            User User2 = new User("ved","Vlad","Danilov", "49");
            User2.Method();

            Console.ReadKey();
        }


    }


}
