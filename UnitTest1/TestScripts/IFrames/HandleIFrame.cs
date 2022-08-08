
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.IFrames
{

    public class HandleIFrame
    {
        [Test]
        public void iFrame()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/default.asp");
            ButtonHelper.ClickButton(By.XPath("//a[contains(text(),'Try it Yourself »')]"));
            BroswerHelper.SwitchToWindow(1);
            BroswerHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//body/h2[contains(text(),'First')]/following-sibling::button"));
            BroswerHelper.SwitchToDefaultFrame();
            ButtonHelper.ClickButton(By.XPath("//button[@id='runbtn']"));

        }
    }
}
