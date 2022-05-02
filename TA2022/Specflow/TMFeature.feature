Feature: TMFeature

As a TurnUp portal admin
I would like to create, edit and delete Time and material records
So  thatI can manage employee time and materiaal records successfully.


Scenario: Create time and material records with valid details
	Given I logged in to Turnup Portal successfully
	When I navigate to Time and Material page
	When I Create a new Time and Material record
	Then the record should be created successfully

	Scenario Outline: Edit time and material records with valid details
	Given I logged in to Turnup Portal successfully
	When I navigate to Time and Material page
	When I update '<Description>','<Code>','<Price>' on existing time and material records
	Then the record should have updated '<Description>','<Code>','<Price>'

	Examples: 
	| Description  | Code     | Price |
	| Time         | laptop   | 1500  |
	| Material     | Mouse    | 30    |
	| EditedRecord | Keyboard | 50    |






	
