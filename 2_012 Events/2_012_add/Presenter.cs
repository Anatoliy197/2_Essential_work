using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_012_add
{
    class Presenter
    {
        Model model;
        MainWindow mainWindow;

        public Presenter(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model = new Model();
            this.mainWindow.SomeEv1 += MainWindow_SomeEv1;


        }

        private void MainWindow_SomeEv1(object sender, EventArgs e)
        {
            this.mainWindow.textbox1.Text = this.model.Method(this.mainWindow.textbox1.Text);
        }
    }
}
