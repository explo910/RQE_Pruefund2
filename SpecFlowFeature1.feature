Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: Substract two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are substracted
	Then the result should be -20

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are multiplied
	Then the result should be 3500

Scenario: Divide two numbers
	Given the first number is 2
	And the second number is 1
	When the two numbers are divided
	Then the result should be 2