using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private double result;
        //Context Injection for SpecFLow: 
        private Calculator calculator;
        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator calc)
        {
            this.calculator = calc;
        }

        [When(@"I have entered (.*), (.*) and (.*) and press CurrentFailureIntensityLog")]
        public void WhenIHaveEnteredAndAndPressCurrentFailureIntensityLog(double p0, double p1, double p2)
        {
            result = calculator.CalculateCurrentFailureIntensity(p0, p1, p2);
        }

        [Then(@"the failure intensity expected result should be (.*)")]
        public void ThenTheFailureIntensityExpectedResultShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }

        [When(@"I have entered (.*), (.*), (.*) and press NumberOfExpectedFailure")]
        public void WhenIHaveEnteredAndPressNumberOfExpectedFailure(double p0, double p1, double p2)
        {
            result = calculator.CalculateNumberOfExpectedFailure(p0,p1,p2);
        }

        [Then(@"the failures result should be (.*)")]
        public void ThenTheFailuresResultShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }
    }
}
