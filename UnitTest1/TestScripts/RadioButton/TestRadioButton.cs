
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.RadioButton
{
    
    public class TestRadioButton
    {
        [Test]
        public void RadioTest()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            LinkHelper.ClickLink(By.XPath("(//a[@href='admin.cgi'])[1]"));
            LinkHelper.ClickLink(By.XPath("//a[@href='editparams.cgi']"));
            Console.WriteLine(RadioButtonHelper.IsRadiButtonChecked(By.Id("ssl_redirect-on")));
            RadioButtonHelper.ClickRadioButton(By.Id("ssl_redirect-on"));
            
        }
    }
}
