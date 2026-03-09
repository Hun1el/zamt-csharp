using System;
using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using System.Windows.Media;

namespace GlassEffect
{
    class GlassEffectHelper
    {
        // Для задания Glass эффекта нужно вызвать метод DwmExtendFrameIntoClientArea из Win32 API
        // Импортируем функцию из DwmApi.dll
        [DllImport("DwmApi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(
            IntPtr hwnd,
            ref Margins pMarInset);

        // Структура для задания области, которая будет прозрачной.
        [StructLayout(LayoutKind.Sequential)]
        public struct Margins
        {   
            public int cxLeftWidth;
            public int cxRightWidth;
            public int cyTopHeight;
            public int cyBottomHeight;
        }

        // Выравнивание значений структуры Margins под значение системного DPI
        // IntPtr windowHandle - указатель на окно с которым работает данный класс.
        public static Margins GetDpiAdjustedMargins(IntPtr windowHandle, int left, int right, int top, int bottom)
        {
            // Получение системного DPI
            System.Drawing.Graphics desktop = System.Drawing.Graphics.FromHwnd(windowHandle);
            float DesktopDpiX = desktop.DpiX;
            float DesktopDpiY = desktop.DpiY;

            // Инициализируем структуру.
            Margins margins = new Margins();

            // По умолчанию DPI рабочего стола 96dpi.
            // Корректируем размеры структуры под системные параметры DPI.
            margins.cxLeftWidth = Convert.ToInt32(left * (DesktopDpiX / 96));
            margins.cxRightWidth = Convert.ToInt32(right * (DesktopDpiX / 96));
            margins.cyTopHeight = Convert.ToInt32(top * (DesktopDpiY / 96));
            margins.cyBottomHeight = Convert.ToInt32(bottom * (DesktopDpiY / 96));

            return margins;
        }

        // 1 параметр - окно для которого делается эффект.
        // 2-5 параметры - отступы от краев окна к которым будет применена прозрачность.
        // (эффект обязательно должен начинается с края окна и не может быть по центру рабочей области)
        public static void ExtendGlass(Window win, int left, int right, int top, int bottom)
        {
            // WindowInteropHelper - контролирует взаимодействие между WPF и Win32
            WindowInteropHelper windowInterop = new WindowInteropHelper(win);

            // IntPtr windowHandle - дескриптор текущего окна.
            IntPtr windowHandle = windowInterop.Handle;

            // HwndSource - объект представляет содержимое WPF приложения в Win32 окне.
            HwndSource mainWindowSrc = HwndSource.FromHwnd(windowHandle);

            // Устанавливаем окну прозраяный фон.
            mainWindowSrc.CompositionTarget.BackgroundColor = Colors.Transparent;

            // Корректируем значения структуры Margins
            Margins margins =
                GetDpiAdjustedMargins(windowHandle, left, right, top, bottom);

            // Применяем GlassEffect используя Win32 API.
            int returnVal = GlassEffectHelper.DwmExtendFrameIntoClientArea(mainWindowSrc.Handle, ref margins);

            if (returnVal < 0)
            {
                throw new NotSupportedException("Operation failed.");
            }
        }
    }
}


