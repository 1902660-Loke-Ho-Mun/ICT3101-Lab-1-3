using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ICT3101_Calculator_Lab;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    public class CalculatorDetails
    {
        public Calculator calculator;
    }
    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        private readonly CalculatorDetails calculatorDetails;
        private double _result;
        public UsingCalculatorAdditionsSteps(CalculatorDetails calculatorDetails)
        {
            this.calculatorDetails = calculatorDetails;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            calculatorDetails.calculator = new Calculator();
        }
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = calculatorDetails.calculator.Add(p0, p1);
        }
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }
}
