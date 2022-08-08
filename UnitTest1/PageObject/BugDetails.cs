using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.BaseClasses;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.PageObject
{
    class BugDetails
    {

        #region WebElement

        private IWebElement Severity => ObjectRepository.Driver.FindElement(By.Id("bug_severity"));
        private IWebElement Hardware => ObjectRepository.Driver.FindElement(By.Id("rep_platform"));

        private IWebElement OS => ObjectRepository.Driver.FindElement(By.Id("op_sys"));

        private By SummaryLocator => By.Id("short_desc");

        private By Descriptionlocator => By.Id("comment");

        private By SubmitButton => By.Id("commit");


        #endregion

        #region Action
        public void SeverirtyDropdown(string value)
        {
            ComboBoxHelper.SelectByValue(Severity,value);
            
        }
        public void HardwareDropdown(string value)
        {
            ComboBoxHelper.SelectByValue(Hardware, value);

        }

        public void OSDropdown(string value)
        {
            ComboBoxHelper.SelectByValue(OS, value);
        }

        public void Summary(String value)
        {
            TextBoxHelper.TypeInTextBox(SummaryLocator,value);
        }
        public void SummaryClear()
        {
            TextBoxHelper.ClearTextBox(SummaryLocator);
        }

        public void Description(String value)
        {
            TextBoxHelper.TypeInTextBox(Descriptionlocator,value);
        }
        public void DescriptionClear(String value)
        {
            TextBoxHelper.ClearTextBox(Descriptionlocator);
        }

        public void Submit()
        {
            ButtonHelper.ClickButton(SubmitButton);
        }


        #endregion


    }
}
