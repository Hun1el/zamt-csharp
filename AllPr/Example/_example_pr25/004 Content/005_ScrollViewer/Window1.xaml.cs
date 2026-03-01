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

namespace _004_ScrollViewer
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // Прокручивает содержимое на одну строку вверх.
            scroller.LineUp();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Прокручивает содержимое на одну строку вниз.
            scroller.LineDown();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            // Прокручивает содержимое на одну страницу вверх.
            scroller.PageUp();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            // Прокручивает содержимое на одну страницу вниз.
            scroller.PageDown();
        }
    }
}
