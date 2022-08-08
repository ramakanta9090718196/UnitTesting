using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1.ComponentHelper
{
    public class ComboBoxHelper
    {
        private static SelectElement Select;

        public static void SelectByIndex(By locator, int index)
        {
            Select = new SelectElement(GenericHelper.GetElement(locator));
            Select.SelectByIndex(index);
        }
        public static void SelectByValue(By locator,String value)
        {
            Select = new SelectElement(GenericHelper.GetElement(locator));
            Select.SelectByValue(value);
        }
        public static void SelectByValue(IWebElement locator, String value)
        {
            Select = new SelectElement(locator);
            Select.SelectByValue(value);
        }

        public static void SelectByText(By locator, String text)
        {
            Select = new SelectElement(GenericHelper.GetElement(locator));
            Select.SelectByText(text);
        }
         
        public static string GetSelectedValue(By locator)
        {
            Select = new SelectElement(GenericHelper.GetElement(locator));
            return Select.SelectedOption.Text;
        }
       


        public static List<String> GetAllListItem(By locator)
        {
            Select = new SelectElement(GenericHelper.GetElement(locator));
            return Select.Options.Select(x => x.Text).ToList();
        }
    }
}
