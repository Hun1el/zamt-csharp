using System;
using System.Windows;

namespace WindowInteractin2
{
    public partial class Window1 : Window, IInteractiveWindow
    {
        public Window1()
        {
            InitializeComponent();
        }

        #region IInteractiveWindow Members

        public void UpdateWindow(string message)
        {
            label1.Content = message;
        }

        #endregion
    }
}
