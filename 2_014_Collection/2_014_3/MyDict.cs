using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_014_3
{
    class MyDict<TKey, TValue>
    {
        private int v;
        public MyDict(int v)
        {
            this.v = v;
        }

        public void Add(TKey key, TValue value)
        {

        }

        int position = -1; //Поле которое сохраняет позицию 

        public void Reset()//Метод возвращает в начало массива
        {
            position = -1;
        }

        //TKey[] array = null;//Создание массива

        //public IEnumerator<TKey> GetEnumerator()
        //{
        //    while (true) //Бесконечный цикл
        //    {
        //        if (position < array.Length - 1)//Проверяем позицию в массиве 
        //        {
        //            position++; //Инкрементируем 
        //            yield return array[position];
        //        }
        //        else
        //        {
        //            Reset(); //Вызов метода Reset
        //            yield break;
        //        }
        //    }
        //}
    }
}
