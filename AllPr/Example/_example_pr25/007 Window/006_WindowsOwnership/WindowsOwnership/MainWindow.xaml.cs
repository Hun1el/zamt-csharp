using System.Windows;

namespace WindowsOwnership
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Окна, имеющие окно-владельца, удобно применять для всплывающих окон и панелей инструментов.
            // Дочернее окно всегда отображается поверх своего владельца и сворачивается, когда сворачивается окно-владелец.

            Window1 window = new Window1();
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();
        }
    }
}


