
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.TestMultipleBrowserWindow
{
 
    public class BrowserWindowHandle
    {
        [Test]
        public void BrowserWindow()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/html/default.asp");
            BroswerHelper.BrowserMaximize();
            ButtonHelper.ClickButton(By.XPath("(//a[@class='w3-btn w3-margin-bottom'])[2]"));
            BroswerHelper.SwitchToWindow(1);
            ButtonHelper.ClickButton(By.XPath("//button[@id='runbtn']"));
            BroswerHelper.SwitchToWindow(0);
            

        }
    }
}
