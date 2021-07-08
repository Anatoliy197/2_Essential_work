using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_add
{
    class Dictionary_2ukr
    {
        private string[] key = new string[5];
        private string[] value1 = new string[5];
        private string[] value2 = new string[5];

        public Dictionary_2ukr()
        {
            key[0] = "книга"; value1[0] = "book"; value2[0] = "книга_у";
            key[1] = "ручка"; value1[1] = "pen"; value2[1] = "ручка_y";
            key[2] = "солнце"; value1[2] = "sun"; value2[2] = "сонце";
            key[3] = "яблоко"; value1[3] = "apple"; value2[3] = "яблуко";
            key[4] = "стол"; value1[4] = "table"; value2[4] = "стiл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value1[i] + " - " + value2[i];
                return string.Format("{0} - нет перевода для этого слова", index);
            }
        }
        public string this[int index]
        {

            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value1[index] + " - " + value2[index];
                else
                    return "Попытка обращения за пределы массива";
            }
        }
    }
}
