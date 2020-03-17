using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_8_Repitition
{

    /*
     * Lesson 91 Do while loops
     * Do while is a post test wheras a for loop is a pre test.
     * 
     * 
     * 
     */
    [TestClass]
    public class DoWhileLoop
    {
        [TestMethod]
        public void TestDoWhile()
        {
            int sum = 0;
            int num = 1;
            do
            {
                sum += num; // sum = sum + num
                num++;
                Console.WriteLine($"sum = {sum}");
            }
            while (num<=10);
            Assert.AreEqual(55, sum);

        }
    }
}
