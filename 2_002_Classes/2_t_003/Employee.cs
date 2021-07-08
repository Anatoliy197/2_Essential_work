using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_003
{
    class Employee
    {
        string surname, name, post;
        double salary, taxe;
        double k = 0.13;
        int experience;

        public Employee(string surname, string name, string post, int experience)
        {
            this.surname = surname;
            this.name = name;
            this.post = post;
            this.experience = experience;

        }
        public void SalaryTax()
        {
            Console.WriteLine(surname);
            Console.WriteLine(name);
            Console.WriteLine(post);
            if (post == "Junior Eng.")
            {
                salary = 20000;
            }
            else if (post == "Middle Eng.")
            {
                salary = 40000;
            }

            else if (post == "Senior Eng.")
                salary = 60000;

            else
            {
                Console.WriteLine("Должность отсутствует");
                return;
            }

            taxe = salary * k;
            salary = salary + experience * 1000;

            Console.WriteLine(salary);
            Console.WriteLine(taxe);
        }
    }
}
