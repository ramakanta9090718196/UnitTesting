
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.MouseAction
{
   
    public class PerformMosueAction
    {
        [Test]
        public void ContextClick()
        {
            // For right click
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement element = ObjectRepository.Driver.FindElement(By.Id("draggable"));
            act.ContextClick(element).Build().Perform();

        }

        [Test]
        public void DragAndDrop()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/events");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement src = ObjectRepository.Driver.FindElement(By.Id("draggable"));
            IWebElement dst = ObjectRepository.Driver.FindElement(By.Id("droptarget"));
            act.DragAndDrop(src,dst);
            Thread.Sleep(4000);

        }

        [Test]
        public void TestClickAndHold()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/sortable/index");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement src = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[contains(text(),'Pushing Me Away')]"));
            IWebElement dst = ObjectRepository.Driver.FindElement(By.XPath("//ul[@id='sortable-basic']/li[contains(text(),'Papercut')]"));
            act.ClickAndHold(src).MoveToElement(dst,0,30).Release().Build().Perform();
            


        }
    }
}
