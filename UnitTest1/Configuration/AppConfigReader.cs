using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Interface;
using UnitTest1.Settings;

namespace UnitTest1.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserTypes GetBrowser()
        {
            //string Browser=ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            string Browser = "Chrome";
            return (BrowserTypes)(Enum.Parse(typeof(BrowserTypes), Browser));
        }

        public string GetPassword()
        {
            //return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
            return "Bugzilla@1996";
        }

        public string GetUsername()
        {
            return "ramakanta.das9090718196@outlook.com";
            //return ConfigurationManager.AppSettings.Get(AppConfigKeys.UserName);
        }

        public string GetWebsite()
        {
            return "http://localhost:5001/";
            //return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }

        public int PageLoadTimeOut()
        {
            string TimeOut = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTime);
            if (TimeOut == null)
            {
                return 30;
            }
            return Convert.ToInt32(TimeOut);
        }
    }   
}
