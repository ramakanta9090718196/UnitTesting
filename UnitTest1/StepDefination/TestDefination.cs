using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnitTest1.BaseClasses;
using UnitTest1.ComponentHelper;
using UnitTest1.PageObject;
using UnitTest1.Settings;


namespace UnitTest1.StepDefination
{
    [Binding]
    public sealed class TestDefination
    {
        private HomePage hPage;
        private Login LPage;
        private BugDetails BPage;
        
        [Given(@"User it at Bug zilla homepage")]
        public void GivenUserItAtBugZillaHomepage()
        {
            //BaseClasses.BaseClass.InitWebDriver();


            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
        [Given(@"File a Bug link should be visible")]
        public void GivenFileABugLinkShouldBeVisible()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("enter_bug")));
        }

        [When(@"User click on File a Bug link")]
        public void WhenUserClickOnFileABugLink()
        {
            hPage = new HomePage();
            LPage = hPage.NavigationToLogin();
        }
        [Then(@"User should be at Login page")]
        public void ThenUserShouldBeAtLoginPage()
        {
            Assert.AreEqual("Log in to Bugzilla", PageBase.PageTitle());
        }

        [When(@"I provide the username password and click on login button")]
        public void WhenIProvideTheUsernamePasswordAndClickOnLoginButton()
        {
            BPage = LPage.LogIn();
        }
        [Then(@"User should be at enter bug page")]
        public void ThenUserShouldBeAtEnterBugPage()
        {
            Assert.AreEqual("Enter Bug: TestProduct",PageBase.PageTitle());
            
        }
        [When(@"I click on logout button")]
        public void WhenIClickOnLogoutButton()
        {
            PageBase p = new PageBase();
            p.LogOut();

        }
        [Then(@"User should be logged out and should be in home page")]
        public void ThenUserShouldBeLoggedOutAndShouldBeInHomePage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("welcome")));
        }
        [When(@"I provide the severity , harware, platform and scenario")]
        public void WhenIProvideTheSeverityHarwarePlatformAndScenario()
        {
            BPage.SeverirtyDropdown("major");
            BPage.HardwareDropdown("Macintosh");
            BPage.OSDropdown("Linux");
            BPage.Summary("Summary -1");
            BPage.Description("Description -1");
           
        }

        [When(@"click on submit button")]
        public void WhenClickOnSubmitButton()
        {
            BPage.Submit();
        }
        [Then(@"Bug shoud be created")]
        public void ThenBugShoudBeCreated()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.Id("commit_top")));
        }
        [Then(@"User should be at search page")]
        public void ThenUserShouldBeAtSearchPage()
        {
            Assert.IsTrue(GenericHelper.IsElementPresent(By.XPath("//td[@id='bz_field_status']/span[contains(text(),'CONFIRMED')]")));
        }














    }
}
