using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace SingleInstanceApplication
{
    public class StartupClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            SingleInstanceApplicationWrapper startWrapper = new SingleInstanceApplicationWrapper();
            startWrapper.Run(args);
        }
    }

    // WindowsFormsApplicationBase из псборки Microsoft.VisualBasic
    public class SingleInstanceApplicationWrapper : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        private WpfApplication _app;

        public SingleInstanceApplicationWrapper()
        {
            // Включаем режим single-instance.
            this.IsSingleInstance = true;
        }

        // Первый запуск приложения.
        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs eventArgs)
        {
            try
            {
                // Регестрация расширения .test. Нужно запустить приложения с правами администратора.
                string extension = ".test";
                string title = "SingleInstanceApplication";
                string extensionDescription = "A Test Document";
                ExstensionRegisterHelper.SetFileAssociation(extension, title + "." + extensionDescription);
            }
            catch
            {
                MessageBox.Show("Не удалось зарегистрировать расширение .test");
            }

            _app = new WpfApplication();
            _app.Run();

            return false;
        }

        // Метод срабатывает при последующих запусках приложения.
        protected override void OnStartupNextInstance(Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs eventArgs)
        {
            if (eventArgs.CommandLine.Count > 0)
            {
                (Application.Current.MainWindow as MainWindow).ShowFileText(eventArgs.CommandLine[0]);
            }
            Application.Current.MainWindow.Activate();
        }
    }
}
