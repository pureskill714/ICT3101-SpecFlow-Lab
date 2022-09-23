using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorFactorialStepDefinitions
    {
        private double result;
        //Context Injection for SpecFLow: 
        private Calculator calculator;
        public UsingCalculatorFactorialStepDefinitions(Calculator calc)
        {
            this.calculator = calc;
        }

        [When(@"I have entered integer value (.*) into my calculator and press Factorial")]
        public void WhenIHaveEnteredIntegerValueIntoMyCalculatorAndPressFactorial(int p0)
        {
            result = calculator.Factorial(p0);
        }

        [Then(@"the result will be (.*)")]
        public void ThenTheResultWillBe(Decimal p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }

    }
}
