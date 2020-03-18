using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_9_Methods
{
    [TestClass]
    public class CodingQuiz_MathFunctions
    {
        [TestMethod]
        public void TestSquareRoot()
        {
            Assert.AreEqual(6.7, CodingQuiz_MathFunctions.SquareRoot(45),2);  // the 1 after (100) signifies 1 number only 2 signifies 2 i.e 6.7
        }

        [TestMethod]
        public void TestSumInt()
        {
            int x = CodingQuiz_MathFunctions.Sum(2,2);
            Assert.AreEqual(x, 4);
        }

        [TestMethod]
        public void TestSumDouble()
        {
            double x = CodingQuiz_MathFunctions.Sum(10.5,10.5);
            Assert.AreEqual(x, 21);
        }

        [TestMethod]
        public void TestSumDecimal()
        {
            decimal x = CodingQuiz_MathFunctions.Sum(10.5M, 10.5M);
            Assert.AreEqual(x, 21);
        }

        public static double SquareRoot(double value)
        {
            return Math.Sqrt(value);
        }

        public static int Sum (int num1, int num2)
        {
            return num1 + num2;
        }
        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public static decimal Sum(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
