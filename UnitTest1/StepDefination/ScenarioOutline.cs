using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnitTest1.PageObject;

namespace UnitTest1.StepDefination
{
    [Binding]
    public sealed class ScenarioOutline
    {
       private BugDetails BPage;
        [When(@"I provide the ""(.*)"",""(.*)"",""(.*)"" ,""(.*)"" nad ""(.*)""")]
        public void WhenIProvideTheNad(string severity, string hardware, string platform, string summary, string scenario)
        {
            BPage = new BugDetails();

                BPage.SeverirtyDropdown(severity);
                BPage.HardwareDropdown(hardware);
                BPage.OSDropdown(platform);
                BPage.Summary(summary);
                BPage.Description(scenario);
            
        }


    }
}
