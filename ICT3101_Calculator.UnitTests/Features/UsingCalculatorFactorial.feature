Feature: UsingCalculatorFactorial
	Simple calculator for finding factorial

@Factorial
Scenario: Factorial of input zero
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be "1"

@Factorial
Scenario: Factorial of positive input
	Given I have a calculator
	When I have entered "3" into the calculator and press factorial
	Then the factorial result should be "6"