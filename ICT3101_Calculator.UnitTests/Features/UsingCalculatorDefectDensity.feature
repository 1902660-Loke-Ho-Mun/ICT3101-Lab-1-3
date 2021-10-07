Feature: UsingCalculatorDefectDensity
	In order to calculate the Defect Density and SSI for second release
	As a System Quality Engineer
	I want to use my calculator to calculate these

@DefectDensity
Scenario: Calculate Defect Density
	Given I have a calculator
	When I have entered "100" and "50" into calculator and press Defect Density
	Then the defect density result should be "2"

@SSI
Scenario: Calculate SSI for second release
	Given I have a calculator
	When I have entered "50", "20" and "4" into the calculator and press SSI
	Then the SSI result for second release should be "66"