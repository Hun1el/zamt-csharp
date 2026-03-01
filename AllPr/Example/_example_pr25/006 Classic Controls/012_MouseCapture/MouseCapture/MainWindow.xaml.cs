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

namespace MouseCapture
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            // Проверка состояния левой клавиши мыши.
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                // Получение координат мыши относительно объекта Rect.
                Point currentMouse = e.GetPosition(Rect);
                TextBlock1.Text = string.Format("x: {0} y:{1}", currentMouse.X, currentMouse.Y);
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (IsCaptureMouse.IsChecked == true)
            {
                // Захват мыши на объекте Rect.
                Rect.CaptureMouse();
            }
        }

        private void Rectangle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (IsCaptureMouse.IsChecked == true)
            {
                // Освобождение мыши.
                Rect.ReleaseMouseCapture();
            }
        }
    }
}
