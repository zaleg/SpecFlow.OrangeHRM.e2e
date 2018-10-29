Feature: OrangeHRMDemoFlow
	In order to be sure OrangeHRM works correct
	As a admin
	I want to walk throuth the application performing some basic operations

@smoke
Scenario: Verify basic functionality
	Given log in as 'admin'
	When navigate to 'Time' menu item
	And navigate to 'Attendance' menu item
	And navigate to 'Employee Records' menu item
	When view records for employee with 'John Smith' name and '2018-10-08' date
	Then verify that there are no attendance records in the table
