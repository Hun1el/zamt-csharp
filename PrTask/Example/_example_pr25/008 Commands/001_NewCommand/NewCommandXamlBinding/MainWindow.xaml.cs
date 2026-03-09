using System.Windows;
using System.Windows.Input;

namespace NewCommandXamlBinding
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Команда 'New' была вызвана.");
        }
    }
}
