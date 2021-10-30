using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
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

    }
}

    

