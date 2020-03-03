using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6_Classes_And_Methods
{
  [TestClass]
    public class Trip_Test
    {
       
        [TestMethod]
        public void CalcMilesPerGallon_Test()
        {
            Trip roadTrip = new Trip("San Francisco",10,29M,100);
            double milesperGal =  roadTrip.CalcMilesPerGallon();
            Console.WriteLine(roadTrip.CalcMilesPerGallon());
            Assert.AreEqual(milesperGal, 0.1);
        }

        [TestMethod]
        public void CostPerMile_Test()
        {
            Trip roadTrip = new Trip("San Francisco", 100, 50M, 10);
            decimal costPerMile = roadTrip.CostPerMile();
            Console.WriteLine(roadTrip.CostPerMile());
            Assert.AreEqual(costPerMile, 0.5M);    // Add M for decimal
        }

        [TestMethod]
        public void ToString_test()
        {
            Trip myTrip = new Trip("San Diego",200,76M,140);
            Console.WriteLine(myTrip);
        }
    }
}
