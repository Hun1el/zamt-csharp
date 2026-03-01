using System;
using System.Windows;

namespace GlassEffect
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Сделать часть окна прозрачной.
                GlassEffectHelper.ExtendGlass(this, -1, -1, -1, -1);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
