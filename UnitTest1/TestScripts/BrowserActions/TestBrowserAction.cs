
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.BrowserActions
{
    
    public class TestBrowserAction
    {
        [Test]
        public void BrowserAction()
        {


            NavigationHelper.NavigateToUrl("https://www.cleartrip.com/ticket");
            BroswerHelper.BrowserMaximize();
            LinkHelper.ClickLink(By.XPath("//span[contains(text(),'Flights')]"));
            BroswerHelper.GoBack();
            BroswerHelper.GoForward();
            BroswerHelper.RefreshPage();

        }
    }
}
