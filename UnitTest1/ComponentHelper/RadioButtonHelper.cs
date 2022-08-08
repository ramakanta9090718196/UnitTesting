using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement element;
        public static void ClickRadioButton(By locator)
        {
            element=GenericHelper.GetElement(locator);
            element.Click();
        }

        public static bool IsRadiButtonChecked(By locator)
        {
            element = GenericHelper.GetElement(locator);
            String IsChecked = element.GetAttribute("checked");
            if(IsChecked==null)
            {
                return false;
            }
            else
            {
                return IsChecked.Equals("Checked") || IsChecked.Equals("True");
            }
        }

    }
}
