using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.ComponentHelper
{
   public  class ButtonHelper
    {
        private static IWebElement element;
        public static void ClickButton(By loactor)
        {
            element=GenericHelper.GetElement(loactor);
            element.Click();
        }

        //To Check if button is enabled or not

        public static bool IsButtonEnabled(By locator)
        {
            element = GenericHelper.GetElement(locator);
            return element.Enabled;
        }

        public static string GetButtonText(By locator)
        {
            element = GenericHelper.GetElement(locator);
            if (element.GetAttribute("value") == null)
            {
                return string.Empty;
            }
            else
                return element.GetAttribute("value");
        }

    }
}
