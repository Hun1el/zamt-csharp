using System.Windows;
using System.ComponentModel; // для BackgroundWorker
using System.Threading;

namespace BackgroundWorkerSample
{
    public partial class MainWindow : Window
    {
        // Задача объекта типа BackgroundWorker захватить свободный поток из пула потоков CLR и затем из
        // этого потока вызвать событие DoWork;
        BackgroundWorker _worker;

        public MainWindow()
        {
            InitializeComponent();

            _worker = new BackgroundWorker();
            // Метод, который будет выполнятся в отдельном потоке. Событие DoWork срабатывает при вызове RunWorkerAsync
            _worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            // Метод, который сработает в момент завершения BackgroundWorker
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            // Событие для отслеживание процесса выполнения задачи BackgroundWorker. Событие возникает при вызове метода _worker.ReportProgress(i);
            _worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            // Для отслеживания выполнения хода работ свойство WorkerReportsProgress устанавливаем true
            _worker.WorkerReportsProgress = true;
            // Поддержка отмены выполнения фоновой операции с помощью метода CancelAsync()
            _worker.WorkerSupportsCancellation = true;
        }

        // Метод работает из потока Dispetcher. Он может получать доступ к переменным окна.
        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        // Метод работает из потока Dispetcher. Он может получать доступ к переменным окна.
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Title = "Completed";
            MessageBox.Show("Completed");
            if (e.Cancelled)
                this.Title = "Cancelled";
        }

        // Данный метод работает в отдельном потоке.
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; ++i)
            {
                // Эмулируем трудоемкую задачу.
                Thread.Sleep(50);

                // Отмена выполнения фоновой задачи, сработает при вызове CancelAsync
                if (_worker.CancellationPending)
                {
                    e.Cancel = true; // значение нужно установить для того что бы при событии RunWorkerCompleted определить почему оно было вызвано, из-за того что закончилась операция или из-за отмены.
                    return; // Отмена выполнения фоновой операции.
                }
                // Отчитываемся о проценте выполнения задачи.
                _worker.ReportProgress(i);
            }
        }

        private void buttonStartWorker_Click(object sender, RoutedEventArgs e)
        {
            // Запуск выполнения фоновой операции. Событие DoWork.
            // Вторая перегрузка RunWorkerAsync позволяет передать объект событию DoWork для его последующей обработки в потоке.
            _worker.RunWorkerAsync();
        }

        private void buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            // Для работы метода, свойство WorkerSupportsCancellation должно быть равное true.
            _worker.CancelAsync();
        }
    }
}


