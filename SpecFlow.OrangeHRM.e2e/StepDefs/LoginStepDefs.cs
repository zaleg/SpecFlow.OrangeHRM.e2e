using SpecFlow.OrangeHRM.e2e.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow.OrangeHRM.e2e.StepDefs
{
    [Binding]
    public class LoginStepDefs : BaseStepDefs
    {
        LoginPage loginPage = new LoginPage();

        [Given(@"log in as '(.*)'")]
        public void GivenLogInAs(string p0)
        {
            loginPage.DoLoginAs(p0);
        }
    }
}
