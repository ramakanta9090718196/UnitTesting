using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.BaseClasses;
using UnitTest1.Settings;

namespace UnitTest1.PageObject
{
    class Login:PageBase
    {

        #region WebElement
        private IWebElement LoginTextBox => ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
        private IWebElement LoginPassword => ObjectRepository.Driver.FindElement(By.Id("Bugzilla_password"));

        private IWebElement LoginButton => ObjectRepository.Driver.FindElement(By.Id("log_in"));

        private IWebElement HomeLink => ObjectRepository.Driver.FindElement(By.Id("Home"));





       

        #endregion
       
        #region Action
        public BugDetails LogIn()
        {
            LoginTextBox.SendKeys(ObjectRepository.Config.GetUsername());
            LoginPassword.SendKeys(ObjectRepository.Config.GetPassword());
            LoginButton.Click();
            return new BugDetails();

        }
        public BugDetails LogIn(String username,string password)
        {
            LoginTextBox.SendKeys(username);
            LoginPassword.SendKeys(password);
            LoginButton.Click();
            return new BugDetails();

        }

        #endregion

        #region Navigation

        public HomePage Navigation()
        {
            HomeLink.Click();
            return new HomePage();
        }

        #endregion
    }
}
