using Moq;
using System;
using System.Collections.Generic;
using System.Text;


/**
 * Updated on 08/10/2021
 * Created By : Ho Mun
 */

namespace ICT3101_Calculator_Lab
{
    public class Calculator
    {
        //lab 4 changed here
        //added _fileReader to constructor
        public FileReader _fileReader;
        public Mock<IFileReader> _mockFileReader;

        public Calculator() { 
            _fileReader = new FileReader();
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "20" });
        }
        /*
         * Testing code
         * 
        public Calculator(FileReader _fileReader)
        {
            _fileReader = new FileReader();
            //_mockFileReader = new Mock<IFileReader>();
            //_mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "20" });
        }
        public Calculator(Mock<IFileReader> _mockFileReader)
        {
            //_fileReader = new FileReader();
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt")).Returns(new string[2] { "42", "20" });
        }
        */
        public double DoOperation(double num1, double num2, double num3, string op)
        {

            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                case "f":
                    result = Factorial(num1);
                    break;
                case "aot":
                    // Get area of triangle
                    result = CalculateAreeOfTriangle(num1, num2);
                    break;
                case "aoc":
                    // Get area of circle
                    result = CalculateAreaOfCircle(num1);
                    break;
                case "ufa":
                    // Get result of Unknown Function A
                    result = UnknownFunctionA(num1, num2);
                    break;
                case "ufb":
                    // Get result of Unknown Function B
                    result = UnknownFunctionB(num1, num2);
                    break;
                case "mtbf":
                    // Get result of MTBF
                    result = MTBF(num1, num2);
                    break;
                case "availability":
                    // Get result of Availability
                    result = Availability(num1, num2);
                    break;
                case "currentFailureIntensity":
                    result = currentFailureIntensity(num1, num2, num3);
                    break;
                case "averageNumberOfExpectedFailures":
                    result = averageNumberOfExpectedFailures(num1, num2, num3);
                    break;
                case "defectDensity":
                    result = DefectDensity(num1, num2);
                    break;
                case "secondReleaseSSI":
                    result = SecondReleaseSSI(num1, num2, num3);
                    break;
                case "magicNumber":
                    result = GenMagicNum(num1);
                    //result = GenMagicNum(num1, _fileReader);
                    //result = GenMagicNum(num1, _mockFileReader);
                    break;
                default:
                    break;
            }
            return result;
        }

        // normal add
        /*
        public double Add(double num1, double num2)
        {
            return (num1 + num2);
        }
        */

        // Lab 2.1 Q10: Add with zero as special cases
        public double Add(double num1, double num2)
        {
            string bin1 = num1.ToString();
            bin1 = bin1 + "00";

            string bin2 = num2.ToString();

            double finalNum1 = Convert.ToDouble(Convert.ToInt32(bin1, 2));
            double finalNum2 = Convert.ToDouble(Convert.ToInt32(bin2, 2));
            return (finalNum1 + finalNum2);
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            //Lab 1 
            /*
            if (num1 == 0 || num2 == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return (num1 / num2);
            }

            */

            //updated 
            //Lab 2.1
            double result = 0;
            //divide zero by number
            if(num1 == 0 && num2 > 0)
            {
                //result = 0;
                result = num1 / num2;
            }
            //dividing by 0
            else if(num1 > 0 && num2 == 0)
            {
                result = num1 / num2;
                //throw new ArgumentException();
            }
            //divide 0 by 0
            else if(num1 == 0 && num2 == 0)
            {
                //result = num1 / num2;
                result = 1;
            }
            //dividing two number
            else
            {
                result = num1 / num2;
            }

            return result;

        }

        public double Factorial(double num)
        {

            if (num < 0)
            {
                throw new ArgumentException();
            }
            else if (num == 0)
            {
                return 1;
            }
            else
            {
                double value = 1;
                for (int i = 1; i <= num; i++)
                {
                    value = value * i;
                }
                return value;
            }

        }

        public double CalculateAreeOfTriangle(double height, double width)
        {
            if (height == 0 || width == 0)
            {
                throw new ArgumentException();
            }
            else if (height < 0 || width < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return (0.5 * height * width);
            }

        }

        public double CalculateAreaOfCircle(double radius)
        {
            if (radius == 0)
            {
                throw new ArgumentException();
            }
            else if (radius < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                return (Math.PI * radius * radius);
            }

        }

        public double UnknownFunctionA(double num1, double num2)
        {
            return Divide(Factorial(num1), Factorial(Subtract(num1, num2)));
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            return Divide(Factorial(num1), Multiply(Factorial(num2), Factorial(Subtract(num1, num2))));
        }

        //lab 2.2
        //MTBF = MTTF + MMTR
        public double MTBF(double MTTF, double MTTR)
        {
            return MTTF + MTTR;
        }
        // Availability = MTTF / MTBF
        public double Availability(double MTTF, double MTBF)
        {
            double result = 0;
            result = MTTF / MTBF;
            return result;
        }

        //lab 2.2
        //current failure intensity
        public double currentFailureIntensity(double initialFailure, double averageExpectedFailure, double totalNoOfFailureInfinititeTime)
        {
            double result = initialFailure * (1 - (averageExpectedFailure / totalNoOfFailureInfinititeTime));
            return result;
        }

        //lab 2.2
        //average number of expected failures
        public double averageNumberOfExpectedFailures(double initialFailure, double totalNoOfFailureInfinititeTime, double noOfHours)
        {
            int result = (int)(totalNoOfFailureInfinititeTime*(1 - Math.Exp(-((initialFailure / totalNoOfFailureInfinititeTime) * noOfHours))));
            return result;
        }

        //lab 2.3
        // defect density
        public double DefectDensity(double defects, double CSI)
        {
            return defects / CSI;
        }

        //lab 2.3
        // second release SSI
        public double SecondReleaseSSI(double oldSSI, double CSI, double changedCode)
        {
            return (Subtract((oldSSI + CSI), changedCode));
        }


        //lab 4
        //Basic
        public double GenMagicNum(double input)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            
            //Console.WriteLine(input);
            //Console.WriteLine(choice);
            //Dependency------------------------------
            FileReader getTheMagic = new FileReader();
            //----------------------------------------
            string[] magicStrings = getTheMagic.Read(@"MagicNumbers.txt");
            
            //foreach (String i in magicStrings){
            //    Console.WriteLine(i);
            //}
            
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                Console.WriteLine("From File: " + (magicStrings[choice]).ToString());
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;


        }
        
        //lab 4
        //IFileReader
        
        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);


            //Dependency------------------------------
            //FileReader getTheMagic = new FileReader();
            //----------------------------------------
            //changed here!!!
            //string[] magicStrings = getTheMagic.Read(@"MagicNumbers.txt");
            string[] magicStrings = _fileReader.Read(@"MagicNumbers.txt");
            
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                //Console.WriteLine(magicStrings[choice]);
                Console.WriteLine("From File: " + (magicStrings[choice]).ToString());
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            //Console.WriteLine(result);
            return result;


        }
        
        //lab 4
        //mock file reader
        public double GenMagicNum(double input, Mock<IFileReader> _mockFileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);


            //Dependency------------------------------
            //FileReader getTheMagic = new FileReader();
            //----------------------------------------
            //changed here!!!
            //string[] magicStrings = getTheMagic.Read(@"MagicNumbers.txt");
            //string[] magicStrings = _fileReader.Read(@"MagicNumbers.txt");
            string[] magicStrings = _mockFileReader.Object.Read(@"MagicNumbers.txt");

            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                //Console.WriteLine(magicStrings[choice]);
                Console.WriteLine("From File: " + (magicStrings[choice]).ToString());
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            //Console.WriteLine(result);
            return result;


        }


    }


}

