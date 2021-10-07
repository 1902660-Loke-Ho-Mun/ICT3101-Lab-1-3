using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private double _result;

        private readonly CalculatorDetails calculatorDetails;

        public UsingCalculatorBasicReliabilitySteps(CalculatorDetails calculatorDetails)
        {
            this.calculatorDetails = calculatorDetails;
        }

        [When(@"I entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press failure intensity")]
        public void WhenIEnteredAndIntoTheCalculatorAndPressFailureIntensity(int p0, int p1, int p2)
        {
            _result = calculatorDetails.calculator.currentFailureIntensity(p0, p1, p2);
        }
        
        [When(@"I entered ""(.*)"", ""(.*)"", ""(.*)"" into the calculator and press Average Number of Expected Failures")]
        public void WhenIEnteredIntoTheCalculatorAndPressAverageNumberOfExpectedFailures(int p0, int p1, int p2)
        {
            _result = calculatorDetails.calculator.averageNumberOfExpectedFailures(p0, p1, p2);
        }
        
        [Then(@"the failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the Average number of expected failures result should be ""(.*)""")]
        public void ThenTheAverageNumberOfExpectedFailuresResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
