Feature: UsingCalculatorFactorial

Calculating the factorial of an integer

@Factorial
Scenario: Calculating factorial 
	Given I have a calculator
	When I have entered integer value 5 into my calculator and press Factorial
	Then the result will be 120