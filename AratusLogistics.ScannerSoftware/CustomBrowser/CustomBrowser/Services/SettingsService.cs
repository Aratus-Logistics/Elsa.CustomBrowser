using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Xamarin.Forms;

namespace CustomBrowser.Services
{
    public class SettingsService
    {
        //public static ISettings AppSettings => CrossSettings.Current;
        public SettingsService()
        {
        }

        public virtual string GetPropertyOrDefault(string propertyName, string defaultValue)
        {
            try
            {
                 if (Application.Current.Properties.ContainsKey(propertyName))
                 {
                     return Application.Current.Properties[propertyName].ToString();
                 }
                return defaultValue;
            }
            catch (Exception ex)
            {
                return "";
            }

        }

        public virtual void AddOrUpdateProperty(string propertyName, string value)
        {
           if (Application.Current.Properties.ContainsKey(propertyName))
            {
                Application.Current.Properties[propertyName] = value;
            }
            else
            {
                Application.Current.Properties.Add(propertyName, value);
            }
            Application.Current.SavePropertiesAsync();
        }
    }
}
