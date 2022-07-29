Feature: HomeAndAboutpage

Background:  Launch browser and SwagLabs application
Given Chrome is open and SwagLabs app is opened
When user enters username "standard_user" and password "secret_sauce" and click on Login

Scenario:  Verifying the functionality of Menu Button
     When User clicks on Menu button
	Then it should display all the options in Menu
	

	Scenario:  Verifying the functionality of All Items link
	When User clicks on Menu button
	And User clicks on All Items link
	Then it should display All Items
	

	Scenario:  Verifying the functionality of LogOut link
	When User clicks on Menu button
	And User clicks on Logout link
	Then it should be Logout from the application
	


	Scenario:  Verifying the functionality of Reset App State link
	When User clicks on Menu button
	And User clicks on Reset App State link
	Then it should reset the app state
	

	
	Scenario: Verifying the functionality of  Twitter link
	When user clicks on Twitter link
	Then it should display the Twitter page
	

	Scenario: Verifying the functionality of  Facebook link
	When user clicks on Facebook link
	Then it should display the Facebook page
	

	Scenario: Verifying the functionality of LinkedIn link
	When user clicks on LinkedIn link
	Then it should display the LinkedIn page
    

	Scenario:  Verifying the functionality of CloseMenu Button
    When User clicks on Menu button
	And clicks on Close menu button
	Then it should close the Menu
	
	Scenario: verification of About Link
    When User clicks on Menu button
    And  user clicks on About Link
	Then it should display the AboutPage

	Scenario: verifying all the option should be visible properly
	 When User clicks on Menu button
      And  user clicks on About Link
	Then It Should Display All The Option In Alligned Manner In AboutPage
    
	
	Scenario: verification of company link
	 When User clicks on Menu button
     And user clicks on About Link
	When user Clicks on company link
	Then it should display all the options in company link

	Scenario: verification of news link
	When User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on company link
	And user Clicks on news link
	Then it should be able to access

	Scenario: verification of security link
	When User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on company link
	And user clicks on security
	Then it should be display security page

	Scenario: verification of Resource link
	When  User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on Resource link
	Then it should be display all the options of resource 

	Scenario: verification of platform link
	When User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on platform link
	Then it should be  able to access platform

	Scenario: verification of solutions link
	When User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on solutions link
	Then it should be  able to access solution

	Scenario: verification of pricing link
	When User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on pricing link
	Then it should be  able to access pricing

	Scenario: verification of navigation bar
	When User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on back navigation arrow
	Then it should display the home page

	Scenario: verification of Refresh and Forward navigation bar
	When User clicks on Menu button
     And  user clicks on About Link
	When user Clicks on back navigation arrow
	And user clicks on refresh button and forward arrow
	Then it should display the About cross testing page

