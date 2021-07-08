using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_t_003
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();

    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();

    }
    class Player: IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Проигрыватель");
        }
        public void Record()
        {
            Console.WriteLine("Запись");
        }
       void IPlayable.Pause()
        {
            Console.WriteLine("Пауза проигрывателя");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Стоп проигрыватель");
        }
        void IRecordable.Pause()
        {
            Console.WriteLine("Пауза записи");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Стоп запись");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Player instanse = new Player();

            Console.WriteLine("1 способ");

            IPlayable instanse1 = instanse as IPlayable;
            instanse1.Play();
            instanse1.Pause();
            instanse1.Stop();

            Console.WriteLine("*********");

            IRecordable instanse2 = instanse as IRecordable;
            instanse2.Record();
            instanse2.Pause();
            instanse2.Stop();

            Console.WriteLine();
            Console.WriteLine("2 способ_из ответов");

            instanse.Play();
            (instanse as IPlayable).Pause();
            (instanse as IPlayable).Stop();

            Console.WriteLine("*********");

            instanse.Record();
            (instanse as IRecordable).Pause();
            (instanse as IRecordable).Stop();


            Console.ReadKey();
        }

    }
}
