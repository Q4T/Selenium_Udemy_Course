using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5_Maths_Equality_and_Rational_Operators
{

    /*****************************************************************
     * 
     * Lesson 54 Math with integers
     * 
     * 
     * 
     * *****************************************************************/
    [TestClass]
    public class IntegerOperators
    {
        // variables
        static int number1;
        static int number2;

        [ClassInitialize()]
        public static void IntegerInitialise(TestContext testContext)
        {
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Test_Addition()
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15);
        }

        [TestMethod]
        public void Test_Subtraction()
        {
            int difference = number1 - number2;
            Console.WriteLine(difference);
            Assert.AreEqual(difference, 5);
        }

        [TestMethod]
        public void Test_Multiplication()
        {
            int times = number1 * number2;
            Console.WriteLine(times);
            Assert.AreEqual(times, 50);
        }

        [TestMethod]
        public void Test_Division()
        {
            int divide = number1 / number2;
            Console.WriteLine(divide);
            Assert.AreEqual(divide, 2);
        }

        [TestMethod]
        public void Test_Modulus()
        {
            int remainder = number1 % number2;
            Console.WriteLine(remainder);
            Assert.AreEqual(remainder, 0);
        }

    }
}
