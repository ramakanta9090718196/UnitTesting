using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnitTest1.ComponentHelper;
using UnitTest1.PageObject;

namespace UnitTest1.StepDefination
{
    [Binding]
    public sealed class Argument
    {
        private HomePage hPage;
        private Login LPage;
        private BugDetails BPage;
        #region Given
        [Given(@"User it at Bug zilla homepage with url ""(.*)""")]
        public void GivenUserItAtBugZillaHomepageWithUrl(string url)
        {
            BaseClasses.BaseClass.InitWebDriver();
            NavigationHelper.NavigateToUrl(url);
        }

        #endregion

        #region When
        [When(@"User click on ""(.*)"" link")]
        public void WhenUserClickOnLink(string link)
        {
            hPage = new HomePage();
            LPage = hPage.NavigationToLogin();
        }

        [When(@"I provide the ""(.*)"" ""(.*)"" and click on login button")]
        public void WhenIProvideTheAndClickOnLoginButton(string username, string password)
        {
            LPage.LogIn(username, password);
        }



        #endregion

    }
}
