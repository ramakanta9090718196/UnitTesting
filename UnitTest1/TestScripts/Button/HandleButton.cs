
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.Button
{

    public class HandleButton
    {
        [Test]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            Console.WriteLine(ButtonHelper.IsButtonEnabled(By.Id("log_in")));
            Console.WriteLine(ButtonHelper.GetButtonText(By.Id("log_in")));
            ButtonHelper.ClickButton(By.Id("log_in"));


        }
    }
}
