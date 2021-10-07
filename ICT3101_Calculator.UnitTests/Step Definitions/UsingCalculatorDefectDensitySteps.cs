using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDefectDensitySteps
    {
        private double _result;

        private readonly CalculatorDetails calculatorDetails;

        public UsingCalculatorDefectDensitySteps(CalculatorDetails calculatorDetails)
        {
            this.calculatorDetails = calculatorDetails;
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into calculator and press Defect Density")]
        public void WhenIHaveEnteredAndIntoCalculatorAndPressDefectDensity(int p0, int p1)
        {
            _result = calculatorDetails.calculator.DefectDensity(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"", ""(.*)"" and ""(.*)"" into the calculator and press SSI")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressSSI(int p0, int p1, int p2)
        {
            _result = calculatorDetails.calculator.SecondReleaseSSI(p0, p1, p2);
        }
        
        [Then(@"the defect density result should be ""(.*)""")]
        public void ThenTheDefectDensityResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the SSI result for second release should be ""(.*)""")]
        public void ThenTheSSIResultForSecondReleaseShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
