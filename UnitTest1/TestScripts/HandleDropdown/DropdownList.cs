
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.HandleDropdown
{

   public class DropdownList
    {
        [Test]
        public void TestDropDownList()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.Config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.Config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            ComboBoxHelper.SelectByText(By.Id("bug_severity"), "minor");
            foreach(string item in ComboBoxHelper.GetAllListItem(By.Id("bug_severity")))
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
