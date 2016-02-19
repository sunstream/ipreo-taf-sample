Feature: User_Searches_For_Device
	In order to find out more about the device I want to buy
	As a non-registered user
	I want to find it by name

Scenario: Verify search suggestions
	Given I visit the site 
	When I type Motorola Moto G in search field
	Then search suggestions contain Motorola Moto G

Scenario: See more device results
	Given I visit the site 
	When I type Motorola Moto G in search field
	And I click on More Device Results link
	Then I can see Motorola Moto G in search results 
	
Scenario: Open search results page
	Given I visit the site 
	When I search for Motorola Moto G
	Then I can see search resuts page

Scenario: Verify search results
	Given I visit the site 
	When I search for Motorola Moto G
	Then I can see Motorola Moto G in search results

Scenario: Verify search results count
	Given I visit the site
	When I search for Motorola Moto G
	And I save search results count as Search Results Count
	And I type Motorola Moto G in search field
	And I click on More Device Results link
	Then displayed results count is the same as Search Results Count
