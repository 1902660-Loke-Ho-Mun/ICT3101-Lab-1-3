using System;
using System.Collections.Generic;
using System.Text;
using ICT3101_Calculator_Lab;
using Moq;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        //lab 4 changed here
        //added MOCK in setup

        //mock only used here
        private Mock<IFileReader> _mockFileReader;
        private Calculator _calculator;
        public FileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            /*
             * 2,-2,4,6,8,10,12,14
             */
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read(@"MagicNumbers.txt")).Returns(new string[3] { "2", "-5", "20" });
            //_mockFileReader.Setup(fr =>
            //fr.Read(@"MagicNumbers.txt")).Returns(new string[8] { "2","-2","4","6","8","10","12","14" });
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(2)]
        public void GenMagicNum_WithPositiveInputAndPositiveNumberRetrieved_ResultEqualToTwoTimesItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a, _mockFileReader);

            //double result = _calculator.GenMagicNum(a, _fileReader);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(20));

        }

        [Test]
        [TestCase(1)]
        public void GenMagicNum_WithPositiveInputButNegativeNumberRetrieved_ResultEqualToNegativeTwoTimesItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a, _mockFileReader);


            //double result = _calculator.GenMagicNum(a, _fileReader);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(10));

        }

        [Test]
        [TestCase(-1)]
        public void GenMagicNum_WithNegativeInput_ResultEqualToItemRetrieved(int a)
        {
            double result = _calculator.GenMagicNum(a, _mockFileReader);

            //double result = _calculator.GenMagicNum(a, _fileReader);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(0));

        }

        [Test]
        [TestCase(20)]
        public void GenMagicNum_WithAnOutOfRangeInput_ResultEqualsToZero(int a)
        {
            double result = _calculator.GenMagicNum(a, _mockFileReader);
            //double result = _calculator.GenMagicNum(a, _fileReader);
            Console.WriteLine("Result: " + (result).ToString());
            Assert.That((int)result, Is.EqualTo(0));

        }
    }
}
