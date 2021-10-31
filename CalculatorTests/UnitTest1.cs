using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;

namespace CalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        CalculatorLibraryClass calculator = new CalculatorLibraryClass();
        //           -------ADDITION TESTS-----------

        //Test-1
        [TestMethod]
        public void TestAddingTwoZeros()
        {
            decimal number1 = 0M;
            decimal number2 = 0M;
            decimal expected = number2;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-2
        [TestMethod]
        public void TestAddingTwoNumbers()
        {
            decimal number1 = 8M;
            decimal number2 = 8M;
            decimal expected = number1 + number2;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);

        }


        //Test-3
        [TestMethod]
        public void TestAddingNegativeTwoNumbers()
        {
            decimal number1 = -8M;
            decimal number2 = -7M;
            decimal expected = number1 + number2;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-4
        [TestMethod]
        public void TestAddOnePositiveOneNegativeNumber()
        {
            decimal number1 = 3M;
            decimal number2 = -21M;
            decimal expected = number1 + number2;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-5
        [TestMethod]
        public void TestAddNumberToZeroAndCheckIfResultIsNumberOne()
        {
            decimal number1 = 7M;
            decimal number2 = 0M;
            decimal expected = number1;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }



        //Test-6
        [TestMethod]
        public void TestAddTwoDecimalNumbers()
        {
            decimal number1 = 8.33M;
            decimal number2 = 6.45M;
            decimal expected = number1 + number2;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);

        }


        //Test-7
        [TestMethod]
        public void TestAddOnePositiveNumberWithOneNegativeNumber()
        {
            decimal number1 = 6.91M;
            decimal number2 = -6.25M;
            decimal expected = number1 + number2;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-8
        [TestMethod]
        public void TestAddPostiveNumberToZeroAndCheckResultIsNumberOne()
        {
            decimal number1 = 4.163M;
            decimal number2 = 0M;
            decimal expected = number1;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-9
        [TestMethod]
        public void TestAddNegativeNumberToZeroAndCheckResultIsNumberOne()
        {
            decimal number1 = -18.831M;
            decimal number2 = 0M;
            decimal expected = number1;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-10
        [TestMethod]

        public void TestAddTwoNegativeNumbers()
        {
            decimal number1 = -3.26M;
            decimal number2 = -7.34M;
            decimal expected = number1 + number2;

            decimal actual = calculator.Add(number1, number2);

            Assert.AreEqual(expected, actual);

        }


        //           -------SUBTRACTION TESTS-----------

        //Test-1
        [TestMethod]
        public void TestSubtractTwoNumbers()
        {
            decimal number1 = 98.0M;
            decimal number2 = 27.0M;
            decimal expected = number1 - number2;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-2
        [TestMethod]
        public void TestSubtractTwoNegativeNumbers()
        {
            decimal number1 = -75.0M;
            decimal number2 = -89.0M;
            decimal expected = number1 - number2;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-3
        [TestMethod]
        public void TestSubtractNumberByNumber1()
        {
            decimal number1 = 35.0M;
            decimal number2 = number1;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-4
        [TestMethod]
        public void TestSubtractOnePostiveOneNegativeNumbers()
        {
            decimal number1 = 64M;
            decimal number2 = -78M;
            decimal expected = number1 - number2;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-5
        [TestMethod]
        public void TestSubtractTwoDecimalNumbers()
        {
            decimal number1 = 25.434M;
            decimal number2 = 12.95M;
            decimal expected = number1 - number2;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-6
        [TestMethod]
        public void TestSubtractOnePositiveOneNegativeDecimalNumbers()
        {
            decimal number1 = 45.279M;
            decimal number2 = -75.12M;
            decimal expected = number1 - number2;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-7
        [TestMethod]
        public void TestSubtractTwoNegativeDecimalNumbers()
        {
            decimal number1 = -86.144M;
            decimal number2 = -63.332M;
            decimal expected = number1 - number2;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-8
        [TestMethod]
        public void TestSubtractDecimalsNumberByNumber1()
        {
            decimal number1 = 35.167M;
            decimal number2 = number1;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-9
        [TestMethod]
        public void TestSubtractNegativeDecimalsNumberByNumber1()
        {
            decimal number1 = -432.563M;
            decimal number2 = number1;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //Test-10
        [TestMethod]
        public void TestSubtractTwoZeros()
        {
            decimal number1 = 0;
            decimal number2 = 0;

            //expected should be 0
            decimal expected = 0;

            decimal actual = calculator.Subtract(number1, number2);

            Assert.AreEqual(expected, actual);

        }

        //           -------MULTIPLICATION TESTS-----------

        //Test-1
        [TestMethod]
        public void TestMultiplyTwoPositiveNumbers()
        {
            decimal number1 = 62M;
            decimal number2 = 88M;
            decimal expected = number1 * number2;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-2
        [TestMethod]
        public void TestMultiplyOnePositiveOneNegativeNumbers()
        {
            decimal number1 = 45M;
            decimal number2 = -35M;
            decimal expected = number1 * number2;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-3
        [TestMethod]
        public void TestMultiplyANumberByOneAndCheckIfResultIsSameNumber()
        {
            decimal number1 = 73M;
            decimal number2 = 1;

            decimal expected = number1;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-4
        [TestMethod]
        public void TestMultiplyOnePostiveOneNegativeNumbers()
        {
            decimal number1 = 43.69M;
            decimal number2 = -5.73M;
            decimal expected = number1 * number2;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-5
        [TestMethod]
        public void TestMultiplyTwoDecimalPositiveNumbers()
        {
            decimal number1 = 76.09M;
            decimal number2 = 3.13M;
            decimal expected = number1 * number2;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-6
        [TestMethod]
        public void TestMultiplyTwoDecimalNegativeNumbers()
        {
            decimal number1 = -47.03M;
            decimal number2 = -2.53M;
            decimal expected = number1 * number2;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-7
        [TestMethod]
        public void TestMultiplyOnePositiveOneNegativeDecimalNumbers()
        {
            decimal number1 = 65.59M;
            decimal number2 = -7.98M;
            decimal expected = number1 * number2;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-8
        [TestMethod]
        public void TestMultiplyAPostiveDecimalByOneAndCheckIfResultIsSameNumber()
        {
            decimal number1 = 35.5673M;
            decimal number2 = 1;

            decimal expected = number1;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-9
        [TestMethod]
        public void TestMultiplyTwoZeros()
        {
            decimal number1 = 0M;
            decimal number2 = 0M;

            decimal expected = 0M;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-10
        [TestMethod]
        public void TestMultiplyANegativeDecimalByOneAndCheckIfResultIsSameNumber()
        {
            decimal number1 = -37.7847M;
            decimal number2 = 1;

            //expected should be the number1 
            decimal expected = number1;

            decimal actual = calculator.Multiply(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //           -------DIVISION TESTS-----------

        //Test-1
        [TestMethod]
        public void TestDivideTwoNumbers()
        {
            decimal number1 = 14M;
            decimal number2 = -22M;
            decimal expected = number1 / number2;

            decimal actual = calculator.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-2
        [TestMethod]
        public void TestDivideANumberByZero()
        {
            decimal number1 = 76M;
            decimal number2 = 0;

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(number1, number2));
        }

        //Test-3        
        [TestMethod]
        public void TestDivideANumberByOne()
        {
            decimal number1 = 54.0M;
            decimal number2 = 1M;
            
            decimal expected = number1;

            decimal actual = calculator.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-4
        [TestMethod]
        public void TestDivideTwoNegativeNumbers()
        {
            decimal number1 = -34M;
            decimal number2 = -72M;
            decimal expected = number1 / number2;

            decimal actual = calculator.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-5
        [TestMethod]
        public void TestDivideTwoDecimalNumbers()
        {
            decimal number1 = 87.24M;
            decimal number2 = 95.12M;
            decimal expected = number1 / number2;

            decimal actual = calculator.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-6
        [TestMethod]
        public void TestDivideTwoNegativeDecimalNumbers()
        {
            decimal number1 = -74.44M;
            decimal number2 = -92.11M;
            decimal expected = number1 / number2;

            decimal actual = calculator.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-7
        [TestMethod]
        public void TestDivideOnePostiveOneNegativeDecimalNumbers()
        {
            decimal number1 = 84.24M;
            decimal number2 = -62.12M;
            decimal expected = number1 / number2;

            decimal actual = calculator.Divide(number1, number2);

            Assert.AreEqual(expected, actual);
        }

        //Test-8
        [TestMethod]
        public void TestDivideADecimalByOne()
        {
            decimal number1 = 64.124M;
            decimal number2 = 1M;

            decimal expected = number1;

            decimal actual = calculator.Divide(number1, number2);

            //expected answer should be number1
            Assert.AreEqual(expected, actual);
        }

        //Test-9
        [TestMethod]
        public void TestDivideANegativeDecimalByOne()
        {
            decimal number1 = -43.92M;
            decimal number2 = 1M;
            
            decimal expected = number1;

            decimal actual = calculator.Divide(number1, number2);
            //the expected answer should be number1
            Assert.AreEqual(expected, actual);
        }

        //Test-10
        [TestMethod]
        public void TestDivideTwoZeros()
        {
            decimal number1 = 0;
            decimal number2 = 0;

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(number1, number2));
        }


        //           -------DIVISION TESTS-----------

        //Test-1
        [TestMethod]
        public void TestDividingTwoNumbers()
        {
            decimal leftNumber = 24M;
            decimal rightNumber = -12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-2
        [TestMethod]
        public void TestDividingANumberByZero()
        {
            decimal leftNumber = 24M;
            decimal rightNumber = 0;

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(leftNumber, rightNumber));
        }

        //Test-3        
        [TestMethod]
        public void TestDividingANumberByOne()
        {
            decimal leftNumber = 24.0M;
            decimal rightNumber = 1M;
            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-4
        [TestMethod]
        public void TestDividingTwoNegativeNumbers()
        {
            decimal leftNumber = -24M;
            decimal rightNumber = -12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-5
        [TestMethod]
        public void TestDividingTwoDecimalNumbers()
        {
            decimal leftNumber = 24.24M;
            decimal rightNumber = 12.12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-6
        [TestMethod]
        public void TestDividingTwoNegativeDecimalNumbers()
        {
            decimal leftNumber = -44.24M;
            decimal rightNumber = -22.12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-7
        [TestMethod]
        public void TestDividingOnePostiveOneNegativeDecimalNumbers()
        {
            decimal leftNumber = 24.24M;
            decimal rightNumber = -22.12M;
            decimal expected = leftNumber / rightNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-8
        [TestMethod]
        public void TestDividingADecimalByOne()
        {
            decimal leftNumber = 24.1342M;
            decimal rightNumber = 1M;
            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-9
        [TestMethod]
        public void TestDividingANegativeDecimalByOne()
        {
            decimal leftNumber = -63.42M;
            decimal rightNumber = 1M;
            //expected should be the leftNumber number itself
            decimal expected = leftNumber;

            decimal actual = calculator.Divide(leftNumber, rightNumber);

            Assert.AreEqual(expected, actual);
        }

        //Test-10
        [TestMethod]
        public void TestDividingTwoZeros()
        {
            decimal leftNumber = 0;
            decimal rightNumber = 0;

            Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(leftNumber, rightNumber));
        }

    }
}

    

