using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows;

namespace LocalizatorHelper
{
    public class LocalisationHelper : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var evt = PropertyChanged;

            if (evt != null)
            {
                evt.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Создает новый экземпляр класса LocalisationHelper.
        /// </summary>
        public LocalisationHelper()
        {
            if (!DesignHelpers.IsInDesignMode)
            {
                // Обновить все привязки при смене локали.
                ResourceManagerService.LocaleChanged += (s, e) =>
                {
                    RaisePropertyChanged(string.Empty);
                };
            }
        }

        /// <summary>
        /// Получение строки из ресурса с помощью ResourceManager
        /// 
        /// {Binding Source={StaticResource localisation}, Path=.[MainScreenResources.IntroTextLine1]}
        /// </summary>
        /// <param name="key">Ключ, который нужно извлечь из ресурсов в формате [ManagerName].[ResourceKey]</param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                if (!ValidateKey(key))
                {
                    throw new ArgumentException(@"Указан не правильный формат строки. [ManagerName].[ResourceKey]");
                }
                if (DesignHelpers.IsInDesignMode)
                {
                    return "[res]";
                }

                return ResourceManagerService.GetResourceString(GetManagerKey(key), GetResourceKey(key));
            }
        }

        #region Private Key Methods

        private bool ValidateKey(string input)
        {
            return input.Contains(".");
        }

        private string GetManagerKey(string input)
        {
            return input.Split('.')[0];
        }

        private string GetResourceKey(string input)
        {
            return input.Substring(input.IndexOf('.') + 1);
        }

        #endregion
    }
}


