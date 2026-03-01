using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Diagnostics;
using System.Threading;

namespace ApplicationSample
{
    // В проекте созданном по стандартному шаблону WPF Application нет метода Main, так как он
    // генерируется автоматически. 
    // Найти авто сгенерированный файл можно по пути /obj/x86/Debug/App.g.cs
    // Если требуется создать свой метод Main, следует указать в настройках проекта,
    // что стартовым объектом (StartUp Object) является Ваш класс.
    // Это можно сделать в окне Properties во вкладке Application.

    public class StartUpClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application app = new Application();
            MainWindow window = new MainWindow();
            app.Run(window);
        }
    }
}
