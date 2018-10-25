using SpecFlow.OrangeHRM.e2e.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow.OrangeHRM.e2e.StepDefs
{
    [Binding]
    public sealed class DashboardStepDefs
    {
        DashboardPage dashboardPage = new DashboardPage();

        [When(@"navigate to '(.*)' menu item")]
        public void WhenNavigateToMenuItem(string p0)
        {
            dashboardPage.NavigateToMenuItem(p0);
        }
    }
}
