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

namespace WPFApplication
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

        // Обработчик нажатия по кнопке.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxName.Text == string.Empty)
            {
                MessageBox.Show("Вы не ввели свое имя!");
            }
            else
            {
                MessageBox.Show("Привет, " + textBoxName.Text);
            }
        }
    }
}
