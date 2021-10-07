Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this


@CurrentFailureIntensity
Scenario: Get current failure intensity
	Given I have a calculator
	When I entered "10", "50" and "100" into the calculator and press failure intensity
	Then the failure intensity result should be "5"

@AverageNumberOfExpectedFailures
Scenario: Get Average number of expected failures
	Given I have a calculator
	When I entered "10", "100", "10" into the calculator and press Average Number of Expected Failures
	Then the Average number of expected failures result should be "63"