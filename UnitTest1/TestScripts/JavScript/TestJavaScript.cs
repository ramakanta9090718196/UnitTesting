
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.JavScript
{
 
    public class TestJavaScript
    {
        // This way we can use java script in selenium code
        [Test]
        public void JavaScriptTest()
        {
            NavigationHelper.NavigateToUrl("https://www.udemy.com/");

            IJavaScriptExecutor exe = ((IJavaScriptExecutor)ObjectRepository.Driver);
            exe.ExecuteScript("window.scrollBy(0,1000)");// here we can execute any java script code
        }
    }
}
