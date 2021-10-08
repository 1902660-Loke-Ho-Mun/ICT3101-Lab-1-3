using System;
using System.Collections.Generic;
using System.Text;
using ICT3101_Calculator_Lab;
using NUnit.Framework;


namespace ICT3101_Calculator.UnitTests
{
    public class MagicNumberUnitTestsBasic
    {
        private Calculator _calculator;
        
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WithPositiveInputAndPositiveNumberRetrieved_ResultEqualToTwoTimesItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(8));

        }

        [Test]
        [TestCase(1)]
        public void GenMagicNum_WithPositiveInputButNegativeNumberRetrieved_ResultEqualToNegativeTwoTimesItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(4));

        }

        [Test]
        [TestCase(-1)]
        public void GenMagicNum_WithNegativeInput_ResultEqualToItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(0));

        }

        [Test]
        [TestCase(20)]
        public void GenMagicNum_WithAnOutOfRangeInput_ResultEqualsToZero(int a)
        {
            double result = _calculator.GenMagicNum(a);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(0));

        }
    }
}
