﻿Feature: AddCertification5
	Simple calculator for adding two numbers

@mytag
Scenario: Check if user could able to add a Certification details
	Given I clicked on the Certification tab under Profile page
	When I add a new Certification details
	Then that Certification Details should be displayed on my listings