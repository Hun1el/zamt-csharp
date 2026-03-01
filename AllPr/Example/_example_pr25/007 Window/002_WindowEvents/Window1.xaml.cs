using System;
using System.Windows;

namespace _007_WindowTimeEvent
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            listBox.Items.Add("InitializeComponent");
        }

        // Возникает сразу же после первой визуализации окна.
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            listBox.Items.Add("ContentRendered");
        }

        // Происходит когда окно полностью инициализировано и готово к взаимодействию.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox.Items.Add("Loaded");
        }

        // Возникает, когда пользователь переключается на это окно, а также при первой загрузке окна.
        private void Window_Activated(object sender, EventArgs e)
        {
            listBox.Items.Add("Activated");
        }

        // Возникает, когда пользователь переходит на другое окно, а также когда окно закрывается.
        private void Window_Deactivated(object sender, EventArgs e)
        {
            listBox.Items.Add("Deactivated");
        }

        // Возникает при закрытии окна. Позволяет отменить операцию закрытия.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you shure?", "Confirm", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }

            Window2 w = new Window2();
            if (w.ShowDialog() == false)
                e.Cancel = true; // Отмена закрытия окна.
        }

        // Возникает после закрытия окна.
        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("Closed");
        }
    }
}


