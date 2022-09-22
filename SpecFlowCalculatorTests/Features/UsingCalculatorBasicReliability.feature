﻿Feature: UsingCalculatorBasicReliability

In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@CurrentFailureIntensity
Scenario: Logarithmic Model Current Failure Intensity
Given I have a calculator
When I have entered 10, 50 and 0.02 and press CurrentFailureIntensityLog
Then the failure intensity expected result should be 3.68

@NumberOfExpectedFailures
Scenario: Logarithmic Model Avg Number of expected failures
Given I have a calculator
When I have entered 10, 10, 0.02 and press NumberOfExpectedFailure
Then the failures result should be 55
	