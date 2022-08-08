
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.Explicitwait
{
    public class ExplicitWait
    {
        [Test]
        public void DynamicWait()
        {
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait= TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver,TimeSpan.FromSeconds(30));
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(WaitForSearchBox()).SendKeys("health");
            //wait.Until();
        }

        private Func<IWebDriver,IWebElement> WaitForSearchBox()
        {
            return ((x) =>
            {
                if (x.FindElements(By.Id("u188-search-form-autocomplete--3")).Count == 1)
                    return x.FindElement(By.Id("u188-search-form-autocomplete--3"));
                else
                    return null;


            });
        }
        private Func<IWebDriver, IWebElement> WaitForSearchButton()
        {
            return ((x) =>
            {
                if (x.FindElements(By.Id("#u5-search-form-autocomplete--3")).Count == 1)
                    return x.FindElement(By.Id("#u5-search-form-autocomplete--3"));
                else
                    return null;


            });
        }
    }
}
