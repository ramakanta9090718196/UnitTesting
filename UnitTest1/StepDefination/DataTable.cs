using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnitTest1.PageObject;

namespace UnitTest1.StepDefination
{
    [Binding]
    public sealed class DataTable
    {
        private BugDetails BPage;

        [When(@"I provide the severity , hardware, platform and scenario")]
        public void WhenIProvideTheSeverityHardwarePlatformAndScenario(Table table)
        {
            BPage = new BugDetails();
           foreach(TableRow row in table.Rows)
            {
                BPage.SeverirtyDropdown(row["severity"]);
                BPage.HardwareDropdown(row["hardware"]);
                BPage.OSDropdown(row["platform"]);
                BPage.Summary(row["Summary"]);
                BPage.Description(row["scenario"]);
            }
        }

    }
}
