Feature: UsingCalculatorAvailability
 In order to calculate MTBF and Availability
 As someone who struggles with math
 I want to be able to use my calculator to do this

@MTBF
Scenario: Calculating MTBF
 Given I have a calculatora
 When I have entered MTTF value as 200 and MTTR value as 10 into the calculator and press MTBF
 Then the MTBF result should be 210

@Availability
Scenario: Calculating Availability
 Given I have a calculator
 When I have entered MTTF value as 200 and MTBF value 210 into the calculator and press Availability
 Then the availability result should be 0.95
