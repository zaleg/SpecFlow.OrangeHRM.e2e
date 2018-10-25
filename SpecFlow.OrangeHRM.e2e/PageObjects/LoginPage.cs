using OpenQA.Selenium;
using System;
using NSelene;
using static NSelene.Selene;

namespace SpecFlow.OrangeHRM.e2e.PageObjects
{
    class LoginPage
    {
        #region Locators
        private SeleneElement TxtUsernameField = S(By.Id("txtUsername"));
        private SeleneElement TxtPasswordField = S(By.Id("txtPassword"));
        private SeleneElement BtnLogin = S(By.Id("btnLogin"));
        #endregion

        public DashboardPage DoLoginAs(String strRole)
        {
            switch (strRole)
            {
                case "admin":
                    Login(TestVariables.ADMIN, TestVariables.VALID_ADMIN_PASSWORD);
                    break;
                default:
                    throw new NotSupportedException(string.Format("'{0}' is not supported now.", strRole));
            }
            DashboardPage dashboardPage = new DashboardPage();
            dashboardPage.IsLoaded();
            Console.WriteLine("User Logged In Successfully");
            return dashboardPage;
        }

        private void Login(String txtUserName, String txtUserPassword)
        {
            TxtUsernameField.Should(Be.Visible).SetValue(txtUserName);
            TxtPasswordField.Should(Be.Visible).SetValue(txtUserPassword);
            BtnLogin.Click();
        }
    }
}
