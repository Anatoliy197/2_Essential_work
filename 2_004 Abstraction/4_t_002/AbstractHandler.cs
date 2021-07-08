using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_t_002
{
    abstract class AbstractHandler
    {
        //public string name = "XML";
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт XML Документ");
        }
        public override void Create()
        {
            Console.WriteLine("Создан XML Документ");
        }
        public override void Change()
        {
            Console.WriteLine("Изменен XML Документ");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен XML Документ");
        }
    }
    class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт TXT Документ");
        }

        public override void Create()
        {
            Console.WriteLine("Создан TXT Документ");
        }
        public override void Change()
        {
            Console.WriteLine("Изменен TXT Документ");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен TXT Документ");
        }

    }
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыт DOC Документ");
        }
        public override void Create()
        {
            Console.WriteLine("Создан DOC Документ");
        }
        public override void Change()
        {
            Console.WriteLine("Изменен DOC Документ");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранен DOC Документ");
        }

    }
}
