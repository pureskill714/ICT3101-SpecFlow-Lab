using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorAvailabilityStepDefinitions
    {
        private double result;
        //Context Injection for SpecFLow: 
        private Calculator calculator;
        public UsingCalculatorAvailabilityStepDefinitions(Calculator calc)
        {
            this.calculator = calc;
        }


        [When(@"I have entered MTTF value as (.*) and MTTR value as (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredMTTFValueAsAndMTTRValueAsIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            result = calculator.Add(p0, p1);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void ThenTheMTBFResultShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }

        [When(@"I have entered MTTF value as (.*) and MTBF value (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredMTTFValueAsAndMTBFValueIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            result = calculator.CalculateAvailability(p0, p1);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }
    }
}
