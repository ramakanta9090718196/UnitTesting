
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.KeyPress
{
    
    public class KeyPressEvent
    {
        [Test]
        public void KeyPress()
        {
           //it was not working as when written 
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Actions act = new Actions(ObjectRepository.Driver);
            //ctrl+t
            act.KeyDown(Keys.LeftControl)
                .SendKeys("n")
                .Build()
                .Perform();

        }
    }
}
