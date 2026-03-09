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

namespace ApplicationResource
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window1().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Window2().Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // FindResource - метод производит поиск ресурса в текущем элементе,
            // а потом в родительских элементах.
            // Если ресурс не найден - выбрасывается исключение.
            Button btn = sender as Button;
            ImageBrush brush = (ImageBrush)btn.FindResource("TileBrush");
            MessageBox.Show("Ресурс найден: " + brush.ToString());

            // TryFindResource - если ресурс не найден возвращается null
            brush = (ImageBrush)btn.TryFindResource("TileBrush_123");
            if (brush == null)
            {
                MessageBox.Show("Ресурс не найден");
            }
        }
    }
}


