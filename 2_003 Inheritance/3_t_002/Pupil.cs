using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_t_002
{
    class Pupil
    {
        public virtual void Study()
        {
           Console.WriteLine("Ученик.Обучение");
        }

        public virtual void Read()
        {
            Console.WriteLine("Ученик.Чтение");
        }

        public virtual void Write()
        {
            Console.WriteLine("Ученик.Письмо");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Ученик.Отдых");
        }

    }
    class ExecelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Отличный Ученик.Обучение");
        }
        public override void Read()
        {
            Console.WriteLine("Отличный Ученик.Чтение");
        }
        public override void Write()
        {
            Console.WriteLine("Отличный Ученик.Письмо");
        }
        public override void Relax()
        {
            Console.WriteLine("Отличный Ученик.Отдых");
        }
    }
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хороший Ученик.Обучение");
        }
        public override void Read()
        {
            Console.WriteLine("Хороший Ученик.Чтение");
        }
        public override void Write()
        {
            Console.WriteLine("Хороший Ученик.Письмо");
        }
        public override void Relax()
        {
            Console.WriteLine("Хороший Ученик.Отдых");
        }

    }
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Плохой Ученик.Обучение");
        }
        public override void Read()
        {
            Console.WriteLine("Плохой Ученик.Чтение");
        }
        public override void Write()
        {
            Console.WriteLine("Плохой Ученик.Письмо");
        }
        public override void Relax()
        {
            Console.WriteLine("Плохой Ученик.Отдых");
        }
    }
}
