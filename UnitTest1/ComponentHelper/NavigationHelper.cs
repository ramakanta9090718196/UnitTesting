using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Settings;

namespace UnitTest1.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);
        }
    }
}
