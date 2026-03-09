using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Diagnostics;

namespace _007_Popup
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        // Обработчик наведения на объект Run.
        private void run_MouseEnter(object sender, MouseEventArgs e)
        {
            // Делаем Popup видимым.
            popLink.IsOpen = true;
        }

        // Переход по ссылке.
        private void lnk_Click(object sender, RoutedEventArgs e)
        {
            string fileName = ((Hyperlink)sender).NavigateUri.ToString();
            // Запускаем приложение, которое ассоциируется с файлом.
            Process.Start(fileName);
        }
    }
}
