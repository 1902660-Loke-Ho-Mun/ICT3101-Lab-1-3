using ICT3101_Calculator_Lab;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        /**
         * Remove in Lab 2.1 (clash) 
         * Add function
         */
        /*
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act 
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        */

        /**
         * Subtract function
         */
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtract()
        {
            // Act 
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        /**
         * Multiply function
         */
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiply()
        {
            // Act 
            double result = _calculator.Multiply(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        /*
        
         * Divide function
         * Remove in Lab 2.1 (clash) 
        
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivide()
        {
            // Act 
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZeroAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }
        */
        /**
         * Factorial function
         */
        [Test]
        [TestCase(2)]
        public void Factorial_CalculatingFactorial_ResultEqualToFactorial(int a)
        {
            double result = _calculator.Factorial(a);
            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        [TestCase(-2)]
        public void Factorial_WithNegtiveAsInput_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0)]
        public void Factorial_WithZeroAsInput_ResultEqualToFactorial(int a)
        {
            double result = _calculator.Factorial(a);
            Assert.That(result, Is.EqualTo(1));
        }


        /**
         * Lab 1 Part 2
         * TDD
         */

        //Triangle
        [Test]
        public void CalculateAreaOfTriangle_WithPositiveInput_ResultEqualToArea()
        {
            double result = _calculator.CalculateAreeOfTriangle(4, 10);
            Assert.That(result, Is.EqualTo(20));

        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 2)]
        [TestCase(2, 0)]
        public void CalculateAreaOfTriangle_WithZeroAsInput_ResultThrowArgumentException(double height, double width)
        {
            Assert.That(() => _calculator.CalculateAreeOfTriangle(height, width), Throws.ArgumentException);
        }

        [Test]
        [TestCase(-2, -2)]
        [TestCase(-2, 2)]
        [TestCase(2, -2)]
        public void CalculateAreaOfTriangle_WithNegativeInput_ResultThrowArgumentException(double height, double width)
        {
            Assert.That(() => _calculator.CalculateAreeOfTriangle(height, width), Throws.ArgumentException);
        }

        //Circle
        [Test]
        public void CalculateAreaOfCircle_WithPositiveInput_ResultEqualToArea()
        {
            double result = _calculator.CalculateAreaOfCircle(2);
            Assert.That(System.Math.Round(result, 2), Is.EqualTo(12.57));
        }

        [Test]
        [TestCase(0)]
        public void CalculateAreaOfCircle_WithZeroAsInput_ResultThrowArgumentException(double radius)
        {
            Assert.That(() => _calculator.CalculateAreaOfCircle(radius), Throws.ArgumentException);
        }

        [Test]
        [TestCase(-2)]
        public void CalculateAreaOfCircle_WithNegativeInput_ResultThrowArgumentException(double radius)
        {
            Assert.That(() => _calculator.CalculateAreaOfCircle(radius), Throws.ArgumentException);
        }

        /**
         * Lab 1 Part 2
         * Unknown Function A
         */

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        /**
         * Lab 1 Part 2
         * Unknown Function B
         */

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act 
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act 
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

    }
}