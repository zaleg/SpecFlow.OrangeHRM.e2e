using OpenQA.Selenium.Chrome;
using System.IO;
using TechTalk.SpecFlow;
using NSelene;
using static NSelene.Selene;

namespace SpecFlow.OrangeHRM.e2e.StepDefs
{
    public class BaseStepDefs
    {
        [BeforeScenario]
        public void SetupTest()
        {
            var pathToDriver = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "\\SpecFlow.OrangeHRM.e2e\\lib";
            SetWebDriver(new ChromeDriver(pathToDriver));
            Configuration.Timeout = 6;
            GetWebDriver().Manage().Window.Maximize();
            // Navigate to application URL.
            GoToUrl(TestVariables.APPLICATION_URL);
        }

        [AfterScenario]
        public void TeardownTest()
        {
            GetWebDriver().Quit();
        }
    }
}
