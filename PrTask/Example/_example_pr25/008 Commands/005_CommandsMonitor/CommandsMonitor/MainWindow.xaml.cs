using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;

namespace CommandsMonitor
{
    // Отслеживание и отмена команд.
    public partial class MainWindow : Window
    {
        // Команда Undo, которая будет выполнять отмену в масштабах приложения.
        private static RoutedUICommand applicationUndo;

        public static RoutedUICommand ApplicationUndo
        {
            get { return applicationUndo; }
        }

        static MainWindow()
        {
            applicationUndo = new RoutedUICommand(
              "Application Undo", "ApplicationUndo", typeof(MainWindow));
        }


        public MainWindow()
        {
            InitializeComponent();

            // Вешаем обработчик для всех событий PreviewExecutedEvent.
            // Событие происходит перед тем, как будет вызвана любая команда в приложении.
            // На момент срабатывания события, значение задействованного элемента управления еще не изменено.
            this.AddHandler(CommandManager.PreviewExecutedEvent,
               new ExecutedRoutedEventHandler(PreviewCommandExecute));
        }

        private void PreviewCommandExecute(object sender, ExecutedRoutedEventArgs e)
        {
            // Игнорируем, если отправителем является кнопка. Берем только поля ввода.
            if (e.Source is ICommandSource) return;

            // Игнорируем текущую команду ApplicationUndo
            if (e.Command == ApplicationUndo) return;


            TextBox txt = e.Source as TextBox;
            if (txt != null)
            {
                RoutedCommand cmd = (RoutedCommand)e.Command;

                // создаем запись в журнале истории.
                CommandHistoryItem historyItem = new CommandHistoryItem(
                    cmd.Name, txt, "Text", txt.Text);

                ListBoxItem item = new ListBoxItem();
                item.Content = historyItem;
                lstHistory.Items.Add(item);
            }
        }

        // Выполнение команды отмены
        private void ApplicationUndoCommand_Executed(object sender, RoutedEventArgs e)
        {
            // Достаем из истории последнюю запись.
            CommandHistoryItem historyItem = ((ListBoxItem)lstHistory.Items[lstHistory.Items.Count - 1]).Content as CommandHistoryItem;
            // Выполняем отмену.
            historyItem.Undo();
            // Удаляем запись из истории.
            lstHistory.Items.Remove(lstHistory.Items[lstHistory.Items.Count - 1]);
        }

        private void ApplicationUndoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            // Команда ApplicationUndo активна если журнал истории не пуст.
            if (lstHistory == null || lstHistory.Items.Count == 0)
                e.CanExecute = false;
            else
                e.CanExecute = true;
        }

    }

    // Описывает одну запись в истории действий.
    public class CommandHistoryItem
    {
        // Имя выполненной команды.
        private string commandName;
        public string CommandName
        {
            get { return commandName; }
            set { commandName = value; }
        }

        // Элемент, для которого была выполнена команда.
        private UIElement elementActedOn;
        public UIElement ElementActedOn
        {
            get { return elementActedOn; }
            set { elementActedOn = value; }
        }

        // Свойство, которое было изменено в целевом элементе.
        private string propertyActedOn;
        public string PropertyActedOn
        {
            get { return propertyActedOn; }
            set { propertyActedOn = value; }
        }

        // Предыдущего состояния.
        private object previousState;
        public object PreviousState
        {
            get { return previousState; }
            set { previousState = value; }
        }

        public CommandHistoryItem(string commandName, UIElement elementActedOn,
            string propertyActedOn, object previousState)
        {
            CommandName = commandName;
            ElementActedOn = elementActedOn;
            PropertyActedOn = propertyActedOn;
            PreviousState = previousState;
        }

        // Метод для отмены действия.
        public void Undo()
        {
            // Получаем Type элемента, для которого выполнялась команда.
            Type elementType = ElementActedOn.GetType();
            // Находим свойство по имени.
            PropertyInfo property = elementType.GetProperty(PropertyActedOn);
            // Устанавливаем свойству сохраненное значение.
            property.SetValue(ElementActedOn, PreviousState, null);
        }

        public override string ToString()
        {
            return commandName;
        }
    }
}


