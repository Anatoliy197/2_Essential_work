using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_t_004
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void SaveDocument()
        {
            base.SaveDocument();
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
