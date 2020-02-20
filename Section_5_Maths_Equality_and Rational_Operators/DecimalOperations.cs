using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5_Maths_Equality_and_Rational_Operators
{
    /*****************************************
     * 
     * Lesson 56 math with decimals
     *  Floats are 32 bit 7 digits 
     *  Double are 64 bit 15 or 16 digits precesion
     *  Decimals are HUGE 128 bit upto 29 significent digits - Decimals used for currency or financial applications due to greater accuracy, but they are slow.
     * 
     *  We need to add M after a decimal value to diferentiate from double or float.
     * *************************************/
    [TestClass]
    public class DecimalOperations
    {
        static decimal num1;  // upto 29 
        static decimal num2;

        [ClassInitialize()]
        public static void IntegerInitialise(TestContext testContext)
        {
            num1 = 10.5M;
            num2 = 5.0M;
        }

        public void TestAddition()
        {
            decimal sum = num1 + num2;
            Console.WriteLine(sum);
            Assert.AreEqual(sum, 15.5M);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            decimal sub = num1 - num2;
            Console.WriteLine(sub);
            Assert.AreEqual(sub, 5.5M);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            decimal product = num1 * num2;
            Console.WriteLine(product);
            Assert.AreEqual(product, 52.5M);
        }

        [TestMethod]
        public void TestDivision()  // this truncates the result, It doesn't round
        {
            decimal quotiant = num1 / num2;
            Console.WriteLine(quotiant);
            Assert.AreEqual(quotiant, 2.1M);
        }

        [TestMethod]
        public void TestModulus()
        {
            decimal remainder = num1 % num2;
            Console.WriteLine(remainder);
            Assert.AreEqual(remainder, 0.5M); // note that th4e division operator returned 2.1 (truncation not rounding) but the real modulus is 0.5 so number1 / number2 is actually 2.5
        }
    }
}
