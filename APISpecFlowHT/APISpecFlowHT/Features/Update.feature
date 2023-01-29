Feature: Upadte

A short summary of the feature

@tag1
Scenario: I update booking
	Given Update booking with id 1
	Then I assert that booking 1 has the same name as in the update request
	
