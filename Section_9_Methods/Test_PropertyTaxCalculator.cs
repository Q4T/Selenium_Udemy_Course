using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_9_Methods
{
    [TestClass]
    public class Test_PropertyTaxCalculator
    { 
        [TestMethod]
        public void Test_PostPercentValue()
        {
            PropertyTaxCalculator propTaxCalc = new PropertyTaxCalculator("2 Woofington Towers",300000);
            Assert.AreEqual(308100, propTaxCalc.PostPercentValue());
        }

        [TestMethod]
        public void Test_PostExemptionValue()
        {
            PropertyTaxCalculator propTaxCalc = new PropertyTaxCalculator("2 Woofington Towers", 300000);
            Assert.AreEqual(283100, propTaxCalc.PostExemptionValue()); 
        }

        [TestMethod]
        public void Test_CalcMillageRate()
        {
            PropertyTaxCalculator propTaxCalc = new PropertyTaxCalculator("2 Woofington Towers", 300000);       
            Assert.AreEqual(2839.49300000M, propTaxCalc.CalcMillageRate());
        }

        [TestMethod]
        public void Test_ToString()
        {
            PropertyTaxCalculator propTaxCalc = new PropertyTaxCalculator("2 Woofington Towers", 300000);
            Console.Write(propTaxCalc);
        }
       
        [TestMethod]
        public void HomeOwnerOne()
        {
            PropertyTaxCalculator propTaxCalc = new PropertyTaxCalculator("2 Woofington Towers", 600000);
            Console.Write(propTaxCalc);
        }

        [TestMethod]
        public void HomeOwnerTwo()
        {
            PropertyTaxCalculator propTaxCalc = new PropertyTaxCalculator("3 Woofington Towers", 500000);
            Console.Write(propTaxCalc);
        }

        [TestMethod]
        public void HomeOwnerThree()
        {
            PropertyTaxCalculator propTaxCalc = new PropertyTaxCalculator("2 Gedling Towers", 600000);
            Console.Write(propTaxCalc);
        }

    }
}
