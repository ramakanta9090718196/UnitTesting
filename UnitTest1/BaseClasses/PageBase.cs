using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.BaseClasses
{
    //this class contains all the
    public class PageBase
    {
        #region WebElement
        //private By LogoutButton => By.LinkText("Log out");
        private By HomePage => By.XPath("(//a[contains(text(),'Home')])[1]");

        private By Logout => By.XPath("//table[@id='lang_links_container']/following-sibling::ul/child::li[11]/span/following-sibling::a");

        #endregion

     
      

        #region Navigation
        protected void NavigateToHomePage()
        {
            if (GenericHelper.IsElementPresent(HomePage))
            {
                LinkHelper.ClickLink(HomePage);
            }
        }

        public void LogOut()
        {
            if(GenericHelper.IsElementPresent(Logout))
            {
                LinkHelper.ClickLink(Logout);
            }
        }

        #endregion

        public static String PageTitle()
        {
            return ObjectRepository.Driver.Title;
        }

    }
}
