Feature: SpecFlowFeature2
	In order to update my profile 
	As a skill trader
	I want to add the languages that I know

@mytag
Scenario: Check if user could able to add a language 
	Given user clicked on the Language tab under Profile page
	When user add a new language
	Then that language should be displayed on my listings
	