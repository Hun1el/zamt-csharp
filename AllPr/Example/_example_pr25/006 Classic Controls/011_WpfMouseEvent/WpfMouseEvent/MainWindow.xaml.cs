using System;
using System.Windows;
using System.Windows.Input;

namespace WpfMouseEvent
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MouseMoved(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition((UIElement)this); // Получение координат мыши, относительно передаваймого элемента.
            lblInfo.Text =
                String.Format(" ({0}; {1}) в оконных координатах.",
                pt.X, pt.Y);
        }
    }
}
