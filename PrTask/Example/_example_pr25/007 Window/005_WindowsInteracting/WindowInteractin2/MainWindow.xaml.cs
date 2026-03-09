using System;
using System.Windows;
using System.Linq;

namespace WindowInteractin2
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            // Стартуем окна как немодальные.
            Window1 w1 = new Window1();
            w1.Show();
            Window2 w2 = new Window2();
            w2.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Перебираем все окна текущего приложения.
            for (int i = 0; i < Application.Current.Windows.Count; ++i)
            {
                Window temp = Application.Current.Windows[i];
                // Если окно производное от интерфейса IInteractiveWindow вызываем метод UpdateWindow().
                if (temp is IInteractiveWindow)
                {
                    (temp as IInteractiveWindow).UpdateWindow("Hello world");
                }
            }
        }
    }
}
