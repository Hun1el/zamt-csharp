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

namespace ContentInWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Test - не наследуется от UIElement. Используется метод ToString
            button1.Content = new Test();

            // TextBox - производный от UIElement.
            TextBox textBox = new TextBox();
            textBox.Width = 100;
            button2.Content = textBox;
        }
    }

    class Test
    {
        public override string ToString()
        {
            return "Hello world";
        }    
    }
}
