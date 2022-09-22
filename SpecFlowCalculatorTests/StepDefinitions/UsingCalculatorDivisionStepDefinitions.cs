using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {

        private double result;
        //Context Injection for SpecFLow: 
        private Calculator calculator;
        public UsingCalculatorDivisionStepDefinitions(Calculator calc)
        {
            this.calculator = calc;
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0,double p1)
        {
            result = calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }

        [Then(@"the division result should be positive_infinity")]
        public void ThenTheDivisionResultShouldBePositive_Infinity()
        {
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
