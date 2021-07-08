using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_t_002
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        public ClassRoom(Pupil petrov, Pupil ivanov, Pupil sidorov, Pupil sokolov)
        {
            pupils[0] = petrov;
            pupils[1] = ivanov;
            pupils[2] = sidorov;
            pupils[3] = sokolov;
        }
        public void Study()
        {
            foreach (Pupil el in pupils)
            {
                el.Study(); //пример полиморфизма
            }
        }
    }
}
