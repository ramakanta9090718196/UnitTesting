
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest1.ComponentHelper;
using UnitTest1.Settings;

namespace UnitTest1.TestScripts.TestPopups
{
   
    public class TestPopup
    {
        [Test]
        public void PoPUpAlert()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ClickButton(By.XPath("(//a[contains(text(),'Try it Yourself »')])[1]"));
            BroswerHelper.SwitchToWindow(1);
            BroswerHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[contains(text(),'Try it')]"));
            Console.WriteLine(AlertHelper.GetAlertText());
            AlertHelper.AcceptAlert();
            BroswerHelper.SwitchToDefaultFrame();
            


        }
        [Test]
        public void PopUpConfirmation()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/js/js_popup.asp");
            ButtonHelper.ClickButton(By.XPath("(//a[contains(text(),'Try it Yourself »')])[2]"));
            BroswerHelper.SwitchToWindow(1);
            BroswerHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[contains(text(),'Try it')]"));
            AlertHelper.CancelAlert();
        }

        [Test]
        public void PromptConfirmation()
        {
            NavigationHelper.NavigateToUrl("https://www.w3schools.com/jsref/met_win_prompt.asp");
            ButtonHelper.ClickButton(By.XPath("(//a[contains(text(),'Try it Yourself »')])[1]"));
            BroswerHelper.SwitchToWindow(1);
            BroswerHelper.SwitchToFrame(By.Id("iframeResult"));
            ButtonHelper.ClickButton(By.XPath("//button[contains(text(),'Try it')]"));
            AlertHelper.FillPrompt("Filled");
            AlertHelper.AcceptAlert();
        }
    }
}
