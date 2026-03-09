using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;

namespace WpfMultiThread_smp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonNewThread_Click(object sender, RoutedEventArgs e)
        {
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            // Создание вторичного потока.
            Thread th = new Thread(UpdateTextRight);
            th.Start();
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString());
        }

        private void UpdateTextRight()
        {
            // Задержка на 5 секунд.
            Thread.Sleep(TimeSpan.FromSeconds(5));

            // v1.0
            ThreadStart threadStart = new ThreadStart(WorkerMethod);
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, threadStart);

            // v2.0
            txt.Dispatcher.BeginInvoke(DispatcherPriority.Normal, (Action)delegate() { txt.Text = "Text"; });
        }

        /// v1.0
        private void WorkerMethod()
        {
            MessageBox.Show(Thread.CurrentThread.GetHashCode().ToString());
            // Этот метод выполняется в потоке диспетчера, поэтому трудоемкие операции подвесят приложение
            // точно так же, как если бы оно работало в одном потоке.
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            txt.Text = "Test";
        }
    }
}
