using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Settings;

namespace UnitTest1.ComponentHelper
{
    class BroswerHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }
        public static void GoForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }
        public static void RefreshPage()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index=0)
        {
            IReadOnlyCollection<string> windows = ObjectRepository.Driver.WindowHandles;
            if(windows.Count<index)
            {
                throw new NoSuchWindowException("Invalid window id"+ index);
            }
            else
            {
                ObjectRepository.Driver.SwitchTo().Window(windows.ElementAt(index));
                BrowserMaximize();
            }
        }

        public static void SwitchToFrame(By locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(ObjectRepository.Driver.FindElement(locator));


        }
        public static void SwitchToDefaultFrame()
        {
            ObjectRepository.Driver.SwitchTo().DefaultContent();


        }

    }
}
