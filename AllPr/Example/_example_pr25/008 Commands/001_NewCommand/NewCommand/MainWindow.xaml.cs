using System;
using System.Windows;
using System.Windows.Input;

namespace NewCommand
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Привязка команды. CommandBinding - пространство имен System.Windows.Input
            CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += new ExecutedRoutedEventHandler(binding_Executed);
            this.CommandBindings.Add(binding);

            // Для того, что бы команда работала, ее нужно привязать к коллекции команд окна.
            // Выполнение команды возможно за счет поднимающихся(Bubble) событий.
            // При вызове команды на любом из элементов управления, событие поднимется до уровня 
            // самого верхнего контейнера - окна, в котором и находится обработчик.

            // Системные команды привязаны к горячим клавишам. Команда New - <Ctrl+N>
        }

        void binding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Команда 'New' была вызвана.");
        }
    }
}
