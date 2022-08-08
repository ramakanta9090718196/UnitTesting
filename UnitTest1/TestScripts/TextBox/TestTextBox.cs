
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.BaseClasses;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.TextBox
{
   
   public class TestTextBox
    {
       

        [Test]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"),ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));
           


        }
        public void TearDown()
        {
            BaseClass.TearDown();
        }
    }
}
