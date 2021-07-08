using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_person_inheritance
{
    class Person
    {
        private string name;
        public int age;

        public string Name  //свойство
        {
            get { return name; }
            set { name = value; }
        }

        public int Age //{ get; set; }
        {
            get { return age; }
            set { age = value; }
        }

        public void Show() //метод выделен желтым цветом.
        {
            Console.WriteLine(Name);
            if (Age < 18)
            {
                Console.WriteLine("Возраст должен быть больше 18 лет");
            }
            else
            {
                Console.WriteLine("{0} года", Age);
            }
        }
    }
}
