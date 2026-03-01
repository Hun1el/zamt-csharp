using System.Windows;
using System.Windows.Input;

namespace CustomCommand
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Произведен повторный запрос.");
        }
    }

    public class DataCommandsLibrary
    {
        // Пользовательская команда.
        private static RoutedUICommand requery;

        static DataCommandsLibrary()
        {
            // InputGestureCollection - горячие клавиши, на которые команда будет реагировать.
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl+R"));

            requery = new RoutedUICommand("Requery", "Requery", typeof(DataCommandsLibrary), inputs);
            // 1 параметр: Текст, который будет отображаться, если команда будет присвоена пункту меню.
            // 2 параметр: Имя команды.
            // 3 параметр: Класс объявляющий команду.
            // 4 параметр: Горячие клавиши.
        }

        public static RoutedUICommand Requery
        {
            get { return requery; }
        }
    }
}


