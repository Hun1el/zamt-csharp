using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows;

namespace _02_CustomCommand
{
    public class CustomCommand  : ICommand
    {
        // Событие происходит при изменениях, которые могут повлиять на возможность запуска команды.
        public event EventHandler CanExecuteChanged 
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        // Метод позволяет определить может ли команда быть запущена в своем текущем состоянии.
        public bool CanExecute(object parameter)
        {
            return true;
        }

        // Метод который сработает при запуске команды.
        public void Execute(object parameter)
        {
            MessageBox.Show("Пользовательская команда сработала.");
        }
    }
}
