using ICT3101_Calculator_Lab;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{

    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private double _result;

        private readonly CalculatorDetails calculatorDetails;

        public UsingCalculatorFactorialSteps(CalculatorDetails calculatorDetails)
        {
            this.calculatorDetails = calculatorDetails;
        }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = calculatorDetails.calculator.Factorial(p0);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
