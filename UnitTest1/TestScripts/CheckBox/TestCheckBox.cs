
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.CheckBox
{
   
   public class TestCheckBox
    {
        [Test]
        public void TestCheckBoxComponenet()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            CheckBoxHelper.IsCheckBoxChecked(By.Id("Bugzilla_restrictlogin"));
            CheckBoxHelper.CheckCheckBox(By.Id("Bugzilla_restrictlogin"));

        }
    }
}
