using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace LocalizatorHelper
{
    public delegate void LocaleChangedEventHander(object sender, LocaleChangedEventArgs e);

    public class LocaleChangedEventArgs : EventArgs
    {
        public CultureInfo NewLocale { get; set; }

        public LocaleChangedEventArgs(CultureInfo newLocale)
        {
            NewLocale = newLocale;
        }
    }
}
