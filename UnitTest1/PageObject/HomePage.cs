using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.BaseClasses;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.PageObject
{
    class HomePage 
    {
        
        #region WebElement
        private IWebElement SearchItemSearcBox => ObjectRepository.Driver.FindElement(By.Id("quicksearch_main"));
        
        private IWebElement SearchItemButton => ObjectRepository.Driver.FindElement(By.Id("find"));

        private By FileBug => By.LinkText("File a Bug");

        #endregion
        
        #region Action
        public void QuickSearch(string text)
        {
            SearchItemSearcBox.SendKeys(text);
            SearchItemButton.Click();
            

        }
        #endregion
        #region Navigation
        public Login NavigationToLogin()
        {
            LinkHelper.ClickLink(FileBug);
            return new Login();

        }

        
        #endregion

        


    }
}
