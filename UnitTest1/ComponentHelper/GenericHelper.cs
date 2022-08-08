using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.Settings;

namespace UnitTest1.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch(Exception)
            {
               return  false;
            }
            
        }

        public static IWebElement GetElement(By locator)
        {
           if(IsElementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Loactor not found"+locator.ToString());
            }
        }

        public static void TakeScreenShot(String filename="FileName")
        {
            Screenshot screen = ObjectRepository.Driver.TakeScreenshot();
            if(filename.Equals("FileName"))
            {
                screen.SaveAsFile("FileName"+ DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg", ScreenshotImageFormat.Jpeg);
            }
            else
            {
                screen.SaveAsFile(filename+".jpeg", ScreenshotImageFormat.Jpeg);
            }
        }
    }
}
