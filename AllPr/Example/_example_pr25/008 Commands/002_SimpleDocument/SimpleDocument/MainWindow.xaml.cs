using System.Windows;
using System.Windows.Input;

namespace SimpleDocument
{
    public partial class MainWindow : Window
    {
        // Указывает изменился ли документ с момента открытия.
        private bool isDirty = false;

        public MainWindow()
        {
            InitializeComponent();

            // Создание привязок.
            CommandBinding binding;
            binding = new CommandBinding(ApplicationCommands.New);
            binding.Executed += NewCommand;
            this.CommandBindings.Add(binding);

            binding = new CommandBinding(ApplicationCommands.Open);
            binding.Executed += OpenCommand;
            this.CommandBindings.Add(binding);

            binding = new CommandBinding(ApplicationCommands.Save);
            binding.Executed += SaveCommand_Executed;

            // Событие, которое вызывается для проверки доступности элемента управления к которому привязана команда.
            binding.CanExecute += SaveCommand_CanExecute;
            this.CommandBindings.Add(binding);
        }

        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Команда New запущена через " + e.Source.ToString());
            isDirty = false;
        }

        private void OpenCommand(object sender, ExecutedRoutedEventArgs e)
        {
            isDirty = false;
        }

        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Команда Save запущена через " + e.Source.ToString());
            isDirty = false;
        }


        private void txt_TextChanged(object sender, RoutedEventArgs e)
        {
            // Текст в поле ввода был изменен.
            isDirty = true;
        }

        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Делаем элементы связанные с командой Save активными или не активными.
            // WPF самостоятельно решает, когда вызывать этот метод (например, перемещение фокуса, выполнение команды)
            // Вызов этого обработчика может происходить достаточно часто, поэтому в нем не желательно использовать код с длительным временем выполнения.
            e.CanExecute = isDirty;
            // Для того, что бы принудительно вызвать CanExecute для всех команд, нужно вызвать метод CommandManager.InvalidateRequerySuggested();
        }
    }
}


