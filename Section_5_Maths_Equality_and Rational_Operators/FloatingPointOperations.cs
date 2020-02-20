using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5_Maths_Equality_and_Rational_Operators
{
    /*
     * Lesson 55 Math with floating point numbers
     */
    [TestClass]
    public class FloatingPointOperations
    {
        static double number1;
        static double number2;

        [ClassInitialize()]
        public static void IntegerInitialise(TestContext testContext)
        {
            number1 = 10.5;
            number2 = 5.0;
        }

        [TestMethod]
        public void TestAddition()
        {
            double sum = number1 + number2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            double sub = number1 - number2;
            Console.WriteLine(sub);
            Assert.AreEqual(sub, 5.5);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            double product = number1 * number2;
            Console.WriteLine(product);
            Assert.AreEqual(product, 52.5);
        }

        [TestMethod]
        public void TestDivision()  // this truncates the result, It doesn't round
        {
            double quotiant = number1 / number2;
            Console.WriteLine(quotiant);
            Assert.AreEqual(quotiant, 2.1);
        }

        [TestMethod]
        public void TestModulus()
        {
            double remainder = number1 % number2;
            Console.WriteLine(remainder);
            Assert.AreEqual(remainder, 0.5); // note that th4e division operator returned 2.1 (truncation not rounding) but the real modulus is 0.5 so number1 / number2 is actually 2.5
        }
    }
}
