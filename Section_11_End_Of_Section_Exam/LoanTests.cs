using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_11_End_Of_Section_Exam
{
    [TestClass]
    public class LoanTests
    {
        [TestMethod]
        public void AutoLoanTest()
        {
            AutoLoan auto = new AutoLoan("001", "Willy", "Wonka", 7.5M, 12000M, 4, "2020", "BMW", "330D", "Black");
            Console.WriteLine(auto);

            Assert.AreEqual("£2,925", auto.CalculateInterest().ToString("c"));
        }

        [TestMethod]
        public void HomeLoanTest()
        {
            HomeLoan home = new HomeLoan("001", "Little", "Lucy", 3.5M, 210000M, 30, "Gedling Towers, Gedlington", "2007", 2000);
            Console.WriteLine(home);
         //   Assert.AreEqual("£31,100", home.CalculateInterest().ToString("c"));
        }
    }
}
