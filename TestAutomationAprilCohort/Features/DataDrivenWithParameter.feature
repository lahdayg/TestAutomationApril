Feature: DataDrivenWithParameter

A short summary of the feature

@tag1
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username text "LWPLONDON"
	And I enter my email text "lwplondon@demo.com"
	And I enter my password text "PasswordSecure"
	And I added something else
	And I added Akins branch
	When I click on the Sign up button
	Then I should be able to register successfully
