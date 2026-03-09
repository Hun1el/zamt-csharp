using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Globalization;
using System.Threading;

namespace LocalizatorHelper
{
    public static class ResourceManagerService
    {
        private static Dictionary<string, ResourceManager> _managers;

        public static event LocaleChangedEventHander LocaleChanged;

        private static void RaiseLocaleChanged(CultureInfo newLocale)
        {
            var evt = LocaleChanged;

            if (evt != null)
            {
                evt.Invoke(null, new LocaleChangedEventArgs(newLocale));
            }
        }

        /// <summary>
        /// Текущая культура приложения
        /// </summary>
        public static CultureInfo CurrentLocale { get; private set; }

        static ResourceManagerService()
        {
            _managers = new Dictionary<string, ResourceManager>();

            ChangeLocale(CultureInfo.CurrentCulture.Name);
        }

        /// <summary>
        /// Получение строкового ресурса по указанному ключу из указанного ResourceManager
        /// 
        /// </summary>
        /// <param name="managerName">Имя ResourceManager</param>
        /// <param name="resourceKey">Имя ресурса для поиска</param>
        /// <returns></returns>
        public static string GetResourceString(string managerName, string resourceKey)
        {
            ResourceManager manager = null;
            string resource = String.Empty;

            if (_managers.TryGetValue(managerName, out manager))
            {
                resource = manager.GetString(resourceKey);
            }
            return resource;
        }

        /// <summary>
        /// Смена текущей культуры
        /// </summary>
        /// <param name="newLocaleName">Имя культуры (en-US, en-GB)</param>
        public static void ChangeLocale(string newLocaleName)
        {
            CultureInfo newCultureInfo = new CultureInfo(newLocaleName);
            Thread.CurrentThread.CurrentCulture = newCultureInfo;
            Thread.CurrentThread.CurrentUICulture = newCultureInfo;

            CurrentLocale = newCultureInfo;

            RaiseLocaleChanged(newCultureInfo);
        }

        /// <summary>
        /// Запускает событие LocaleChanged для обновления привязок
        /// </summary>
        public static void Refresh()
        {
            ChangeLocale(CultureInfo.CurrentCulture.IetfLanguageTag);
        }

        /// <summary>
        /// Регистрация ресурс менеджера без обновления интерфейса.
        /// </summary>
        public static void RegisterManager(string managerName, ResourceManager manager)
        {
            RegisterManager(managerName, manager, false);
        }

        /// <summary>
        /// Регистрация нового ресурс менеджера и обновление интерфейса.
        /// </summary>
        public static void RegisterManager(string managerName, ResourceManager manager, bool refresh)
        {
            ResourceManager _manager = null;

            _managers.TryGetValue(managerName, out _manager);

            if (_manager == null)
            {
                _managers.Add(managerName, manager);
            }

            if (refresh)
            {
                Refresh();
            }
        }

        /// <summary>
        /// Удаление ресурс менеджера.
        /// </summary>
        public static void UnregisterManager(string name)
        {
            ResourceManager _manager = null;

            _managers.TryGetValue(name, out _manager);

            if (_manager != null)
            {
                _managers.Remove(name);
            }
        }
    }
}


