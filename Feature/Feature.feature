Feature: To test login functionality for OrangeHRm application
	To test login functionalitis 

@Launch MHC website and make login into application with users account
Scenario Outline: To make login in orange HRM application and go to home page
	Given Launch the browser and open the url
	And Enter the valid userid <emailid> and password<password>
	When Click on login button
	Then User should be sucessfully redirected to home page of application

	@source:MHC.xlsx:Sheet1
	Examples:
		| emailid | password |



