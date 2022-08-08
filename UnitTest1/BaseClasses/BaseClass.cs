
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UnitTest1.Configuration;
using UnitTest1.CustomException;
using UnitTest1.Settings;

namespace UnitTest1.BaseClasses
{
    [Binding]
    public class BaseClass
    {
       /* private static FirefoxProfile GetFirefoxProfile()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager firefoxProfileManager = new FirefoxProfileManager();
            profile = firefoxProfileManager.GetProfile("default-release");
            return profile;
        }*/
        private static ChromeOptions GetChromeOption()
        {
            ChromeOptions chrome = new ChromeOptions();
            chrome.AddArgument("start-maximized");
            //chrome.AddArgument("headless");
            return chrome;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOption());
            return driver;
        }
        private static IWebDriver GetFireFoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetEdgeDriver()
        {
            IWebDriver driver = new EdgeDriver();
            return driver;
        }





        [BeforeTestRun]
        public static void InitWebDriver()
        {
           
            ObjectRepository.Config = new AppConfigReader();
            switch(ObjectRepository.Config.GetBrowser())
            {
                case BrowserTypes.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;
                case BrowserTypes.Egde:
                    ObjectRepository.Driver = GetEdgeDriver();
                    break;
                case BrowserTypes.Firefox: 
                    ObjectRepository.Driver = GetFireFoxDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver required is not added in this scope");
            }
            //Page load time out set
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(40);

        }
       
        [AfterTestRun]
        public static void TearDown()
        {
            if(ObjectRepository.Driver!=null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }

    }
}
