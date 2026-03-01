using System;
using System.Windows;
using System.Threading;

namespace WpfMultiThread_smp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonNewThread_Click(object sender, RoutedEventArgs e)
        {
            // Создание вторичного потока.
            Thread th = new Thread(UpdateTextWrong);
            th.Start();
        }

        private void UpdateTextWrong()
        {
            // Задержка на 5 секунд.
            Thread.Sleep(TimeSpan.FromSeconds(5));

            // Объект txt был создан в первичном потоке. Так как текущий метод работает
            // в другом потоке то обращение к нему невозможно.
            txt.Text = "Text";
        }
    }
}
