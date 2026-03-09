using System.Windows;
using System.Windows.Input;
using System;

namespace CommandParameters
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += new ExecutedRoutedEventHandler(binding_Executed);
            this.CommandBindings.Add(binding);
        }

        void binding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // Чтение параметра команды.
            MessageBox.Show(Convert.ToString(e.Parameter));
        }
    }
}
