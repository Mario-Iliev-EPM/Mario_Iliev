Feature: DeleteBooking

A short summary of the feature

@tag1
Scenario: I Delete created booking
	Given I delete booking with id 0
	Then I assert that there is no booking with id 0
	
