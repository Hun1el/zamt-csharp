// Проверяем наличие значений в строке аргументов.

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

namespace WindowsTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmdCreate_Click(object sender, RoutedEventArgs e)
        {
            // Создаем окно
            Document doc = new Document();

            // Устанавливаем владельца для созданного окна
            doc.Owner = this;

            // Отображаем окно.
            doc.Show();

            // Добавляем окно в коллекцию окон.
            (Application.Current as App).Documents.Add(doc);
        }

        private void cmdUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Перебираем коллекцию окон
            foreach (Document doc in ((App)Application.Current).Documents)
            {
                // Обновляем содержимое всех окно.
                doc.SetContent("Updated at " + DateTime.Now.ToLongTimeString());
            }
        }
    }
}



