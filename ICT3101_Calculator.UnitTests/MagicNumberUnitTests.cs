using System;
using System.Collections.Generic;
using System.Text;
using ICT3101_Calculator_Lab;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    class MagicNumberUnitTests
    {
        //lab 4 changed here
        //added _fileReader in setup
        private Calculator _calculator;
        public FileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = new FileReader();
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WithPositiveInputAndPositiveNumberRetrieved_ResultEqualToTwoTimesItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a, _fileReader);
            Console.WriteLine(result);
            Assert.That((int)result, Is.EqualTo(8));

        }

        [Test]
        [TestCase(1)]
        public void GenMagicNum_WithPositiveInputButNegativeNumberRetrieved_ResultEqualToNegativeTwoTimesItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a, _fileReader);
            Console.WriteLine(result);
            Assert.That((int)result, Is.EqualTo(4));

        }

        [Test]
        [TestCase(-1)]
        public void GenMagicNum_WithNegativeInput_ResultEqualToItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a, _fileReader);
            Console.WriteLine(result);
            Assert.That((int)result, Is.EqualTo(0));

        }

    }
}
