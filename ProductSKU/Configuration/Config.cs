using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSKU.Configuration
{
    public class Config
    {
        public static string GetEnviroment()
        {
            return GetConfigValue("Enviroment");
        }
        public static string GetBrowser()
        {
            return GetConfigValue("Browser");
        }
        public static string GetUrl()
        {
            string key = "ProductSKU." + GetEnviroment();
            return GetConfigValue(key);
        }
        public static string GetConfigValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
