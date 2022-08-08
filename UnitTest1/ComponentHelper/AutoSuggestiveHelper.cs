using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Settings;

namespace UnitTest1.ComponentHelper
{
    class AutoSuggestiveHelper
    {
        public static void Autosuggsetive(By SearchBoxLocator,string searchinitial,By SuggestionListlocater,string searchitem)
        {
            //Step 1 :- Send search value to search box
            ObjectRepository.Driver.FindElement(SearchBoxLocator).SendKeys(searchinitial);

            //Step2: get webdriverwait.
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30));
            IList<IWebElement> list = wait.Until(SuggestionList(SuggestionListlocater));
            foreach (var item in list)
            {
                if (item.Text == searchitem)
                {
                    item.Click();
                }
            }
        }

        private static Func<IWebDriver, IList<IWebElement>> SuggestionList(By locator)
        {
            return ((x) => {

                return x.FindElements(locator);


            });
        }
    }
}
