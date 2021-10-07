using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        private double _result;

        private readonly CalculatorDetails calculatorDetails;
        public UsingCalculatorDivisionsSteps(CalculatorDetails calculatorDetails)
        {
            this.calculatorDetails = calculatorDetails;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(double p0, double p1)
        {
            _result = calculatorDetails.calculator.Divide(p0, p1);
        }
        
        //normal results
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        //positive infinity
        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
    }
}
