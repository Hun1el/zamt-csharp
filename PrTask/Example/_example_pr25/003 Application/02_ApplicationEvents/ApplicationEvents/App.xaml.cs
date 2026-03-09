using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using System.Diagnostics;

namespace ApplicationEvents
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += new StartupEventHandler(App_Startup);
            this.Exit += new ExitEventHandler(App_Exit);
            this.SessionEnding += new SessionEndingCancelEventHandler(App_SessionEnding);
            //this.Activated += new EventHandler(App_Activated);
            this.Deactivated += new EventHandler(App_Deactivated);
            this.DispatcherUnhandledException += new DispatcherUnhandledExceptionEventHandler(App_DispatcherUnhandledException);
        }

        protected override void OnActivated(EventArgs e)
        {
            Debug.WriteLine("------> Activated");
            base.OnActivated(e);
        }
        
        void App_Startup(object sender, StartupEventArgs e)
        {
            // Событие происходит посел запуска метода Run и до появления главного окна.

            Debug.WriteLine("------> Startup");
        }
                
        //void App_Activated(object sender, EventArgs e)
        //{
        //    // Присходит когда активизируется одно из окон приложения.
        //    // Например, при переходе с друго приложения запущенного в системе.
        //    Debug.WriteLine("------> Activated");
        //}

        void App_Deactivated(object sender, EventArgs e)
        {
            // Присходит при деактивации окна приложения. Например, при переключении на другое окно.
            Debug.WriteLine("------> Deactivated");
        }

        void App_SessionEnding(object sender, SessionEndingCancelEventArgs e)
        {
            // Присходит когда завершаеся сеанс Windows
            Debug.WriteLine("------> SessionEnding " + e.ReasonSessionEnding);
            e.Cancel = true; // предотвращаем завершение выполнения.
        }


        void App_Exit(object sender, ExitEventArgs e)
        {
            // Присходит когда приложение закрывается до того как метод Run вернет управление.
            Debug.WriteLine("------> Exit");
        }

        void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // Присходит когда в главном потоке приложения происходит необработанное исключение.
            Debug.WriteLine("------> DispatcherUnhandledException");
            e.Handled = true; // помечаем необработанное исключение, как обработанное.
        }
    }
}
