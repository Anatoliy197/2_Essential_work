using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_t_add1
{
    class Document
    {
        ////// поля
        //title title;
        //body body;
        //footer footer;

        //public document(title title, body body, footer footer)
        //{
        //    this.title = title;
        //    this.body = body;
        //    this.footer = footer;
        //}

        //public void show()
        //{
        //    this.title.show();
        //    this.body.show();
        //    this.footer.show();
        //}
        Abstr_parts title = null;
        Abstr_parts body = null;
        Abstr_parts footer = null;

        void InitializeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }

        public Document(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show();
            this.body.Show();
            this.footer.Show();
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }


    }
}
