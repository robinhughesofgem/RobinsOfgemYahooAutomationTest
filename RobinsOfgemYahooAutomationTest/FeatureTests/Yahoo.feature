Feature: Yahoo
	As a user of Yahoo
	In order to manage my emails
	I want to be able to delete emails where they have a given subject and body content, 
	Or if they do not, then move them to another folder
	So that My mail box is uncluttered

	Scenario: Find email with given subject and delete if contains given body, otherwise move into another folder
	Given I have logged into Yahoo with the email 'OfgemAutomationTest@yahoo.com' and Password 'Ofgem12345'
	And I enter the most recent email with the subject 'Ofgem Automation Test' to Check the body text
	When The email body contains 'Hello Ofgem' I delete the email, Otherwise I move it into the Junk folder
	Then The email should be in the correct place
