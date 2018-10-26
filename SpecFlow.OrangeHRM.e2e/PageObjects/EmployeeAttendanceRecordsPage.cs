using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSelene;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static NSelene.Selene;

namespace SpecFlow.OrangeHRM.e2e.PageObjects
{
    public class EmployeeAttendanceRecordsPage
    {
        private static String ATTENDANCE_RECORDS_PAGE_TITLE = "Employee Attendance Records";
        #region Locators
        private SeleneElement NavBar = S(By.XPath("//*[@id='primary-header']//span[1]"));
        private SeleneElement TxtEmployeeName = S(By.Id("attendance_employeeName_empName"));
        private SeleneElement DatePicker = S(By.Id("attendance_date"));
        private SeleneElement BtnView = S(By.Id("btView"));
        private SeleneElement TableResults = S(By.Id("tableWrapper"));

        



        #endregion
        public void IsLoaded()
        {
            // Switching to Frame to be able to interact with elements.
            GetWebDriver().SwitchTo().Frame(0);
            NavBar.Should(Have.ExactText(ATTENDANCE_RECORDS_PAGE_TITLE));
        }

        public void SetEmployeeDataAndView(String strEmployeeName, String date)
        {
            TxtEmployeeName.Should(Be.Visible).SetValue(strEmployeeName).PressEnter();
            // Set date via JS.
            Selene.ExecuteScript(
                @"
                    document.getElementById('attendance_date')
                            .value = " + '"' + date + '"' + ""
                            );
            BtnView.Click();
            TableResults.Should(Be.Visible);
        }
    }
}
