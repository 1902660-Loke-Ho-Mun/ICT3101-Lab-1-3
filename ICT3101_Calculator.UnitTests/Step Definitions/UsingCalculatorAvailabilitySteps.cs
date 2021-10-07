using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {

        private double _result;

        private readonly CalculatorDetails calculatorDetails;

        public UsingCalculatorAvailabilitySteps(CalculatorDetails calculatorDetails)
        {
            this.calculatorDetails = calculatorDetails;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            _result = calculatorDetails.calculator.MTBF(p0,p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = calculatorDetails.calculator.Availability(p0, p1);
        }
        
        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
