using System;


namespace _2_012_4
{
    class Presenter4
    {
        Model4 model4;
        MainWindow mainWindow;

        public Presenter4(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            this.model4 = new Model4();
            this.mainWindow.AddEvent += MainWindow_AddEvent;
            this.mainWindow.SubEvent += MainWindow_SubEvent;
            this.mainWindow.MulEvent += MainWindow_MultEvent;
            this.mainWindow.DivEvent += MainWindow_DivEvent;

        }

        private void MainWindow_DivEvent(object sender, EventArgs e)
        {
            string result = model4.Div(Convert.ToInt32(mainWindow.var_x.Text), Convert.ToInt32(mainWindow.var_y.Text));
            mainWindow.var_res.Text = result;

        }

        private void MainWindow_MultEvent(object sender, EventArgs e)
        {
            string result = model4.Mult(Convert.ToInt32(mainWindow.var_x.Text), Convert.ToInt32(mainWindow.var_y.Text));
            mainWindow.var_res.Text = result;

        }

        private void MainWindow_SubEvent(object sender, EventArgs e)
        {
            string result = model4.Sub(Convert.ToInt32(mainWindow.var_x.Text), Convert.ToInt32(mainWindow.var_y.Text));
            mainWindow.var_res.Text = result;

        }

        private void MainWindow_AddEvent(object sender, EventArgs e)
        {
            string result = model4.Add(Convert.ToInt32(mainWindow.var_x.Text), Convert.ToInt32(mainWindow.var_y.Text));
            mainWindow.var_res.Text = result;
        }
    }
}
