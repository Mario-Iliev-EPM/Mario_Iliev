Feature: Organizations

A short summary of the feature

@tag1
Scenario: Verifythat user is logged in
	Given I navigate to the application
	When I log in as admin user
		| Username | Password |
		| Admin    | admin123 |
	Then I successfully logged in
@Record
Scenario: Add a new record in Pay Grades
	Given I navigate to the application
	When I log in as admin user
		| Username | Password |
		| Admin    | admin123 |
	And I add New Record with name and save changes
		| Name    |
		| TestUser |
	And I add assigned currency, with minimum salary value 1 and maximum value 5 and click save button
	Then My changes are visible
@Record
Scenario: Add a new record in Pay Grades and cancel the changes
	Given I navigate to the application
	When I log in as admin user
		| Username | Password |
		| Admin    | admin123 |
	And I add New Record with name and save changes
		| Name    |
		| TestUser |
	And I add assigned currency, select currency, with minimum salary 1 and maximum salary 5 and click cancel button
	Then Data is not visible on the Paygrades pages