using System;
using System.Windows;

namespace WindowInteractin2
{
    public partial class Window2 : Window, IInteractiveWindow
    {
        public Window2()
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
