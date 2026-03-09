using System;
using System.Windows;

namespace _005_WindowPosition
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.WindowStyle = System.Windows.WindowStyle.ToolWindow;
        }

        // Для Window в XAML коде WindowStartupLocation="CenterScreen" для старта окна в центре экрана.

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Вариант 1
            Double width  = SystemParameters.FullPrimaryScreenWidth;
            Double height = SystemParameters.FullPrimaryScreenHeight;

            //// Вариант 2 не учитывается панель задач.
            //width = SystemParameters.WorkArea.Width;
            //height = SystemParameters.WorkArea.Height;

            this.Top = (height - this.Height) / 2;
            this.Left = (width - this.Width) / 2;
        }
    }
}
