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

namespace WindowsInteracting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        NewWindow _window = new NewWindow();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Отображаем второе окно как немодальное.
            _window.Show();

            // Делаем первую кнопку не активной.
            buttonShow.IsEnabled = false;
            // Вторую кнопку, для обновления дочернего окна, делаем активной.
            buttonUpdate.IsEnabled = true;
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Вызываем пользовательский метод, который обновляет значения Label в дочернем окне.
            _window.UpdateWindow("Hello world");
            buttonUpdate.IsEnabled = false;
        }
    }
}


