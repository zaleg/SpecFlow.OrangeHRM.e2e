using NSelene;
using OpenQA.Selenium;
using System;
using static NSelene.Selene;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlow.OrangeHRM.e2e.PageObjects
{
    class DashboardPage
    {
        private static String DASHBOARD_PAGE_TITLE = "Dashboard";
        #region Locators
        private SeleneElement NavBar = S(By.ClassName("page-title"));
        private SeleneElement TimeMenuItem = S(By.Id("menu_time_viewTimeModule"));
        private SeleneElement AttendanceMenuItem = S(By.Id("menu_attendance_Attendance"));
        private SeleneElement EmployeeRecordsMenuItem = S(By.Id("menu_attendance_viewAttendanceRecord"));
        #endregion

        public void IsLoaded()
        {
            NavBar.Should(Be.Visible);
            Assert.AreEqual(NavBar.Text, DASHBOARD_PAGE_TITLE);
        }

        public void NavigateToMenuItem(String strItem)
        {
            switch (strItem)
            {
                case "Time":
                    TimeMenuItem.Should(Be.Visible).Click();
                    break;
                case "Attendance":
                    AttendanceMenuItem.Should(Be.Visible).Click();
                    break;
                case "Employee Records":
                    EmployeeRecordsMenuItem.Should(Be.Visible).Click();
                    break;
                default:
                    throw new NotSupportedException(string.Format("'{0}' menu item is not supported now.", strItem));
            }
        }
    }
}
