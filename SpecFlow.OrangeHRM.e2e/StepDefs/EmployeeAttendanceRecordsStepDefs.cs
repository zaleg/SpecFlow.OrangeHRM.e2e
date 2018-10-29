using SpecFlow.OrangeHRM.e2e.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow.OrangeHRM.e2e.StepDefs
{
    [Binding]
    public sealed class EmployeeAttendanceRecordsStepDefs
    {
        EmployeeAttendanceRecordsPage employeeAttendanceRecordsPage = new EmployeeAttendanceRecordsPage();

        [When(@"view records for employee with '(.*)' name and '(.*)' date")]

        public void WhenViewRecordsForEmployeeWithNameAndDate(string p0, string p1)
        {
            employeeAttendanceRecordsPage.SetEmployeeDataAndView(p0, p1);
        }

        [Then(@"verify that there are no attendance records in the table")]
        public void ThenVerifyThatThereAreNoAttendanceRecordsInTheTable()
        {
            employeeAttendanceRecordsPage.ValidateNoRecords();
        }


    }
}
