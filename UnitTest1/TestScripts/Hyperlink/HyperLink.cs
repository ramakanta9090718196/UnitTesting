
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts
{

    public class HyperLink
    {
       [Test]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.Id("enter_bug"));
        }
    }
}
