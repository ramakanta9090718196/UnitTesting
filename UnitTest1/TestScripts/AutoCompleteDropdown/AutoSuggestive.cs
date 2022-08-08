
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.AutoCompleteDropdown
{
   
   public class AutoSuggestive
    {
        [Test]
        public void AutoComplete()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/autocomplete/index");
            By src = By.Id("countries");
            By sug = By.XPath("//ul[@id='countries_listbox']/child::li");
            AutoSuggestiveHelper.Autosuggsetive(src,"a",sug, "Azerbaijan");


         


        }

       
    }
}
