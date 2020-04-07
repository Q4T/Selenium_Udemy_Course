using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_12_End_Of_Section_Exam
{
    [TestClass]
    [TestCategory("Interface Exam")]
    public class Exam
    {
        [TestMethod]
        public void Test_Page1()
        {
            IPageObject pageObject1 = new PageObjectOne();
            Assert.AreEqual(pageObject1.PageName, "Page Name 1");
        }

        [TestMethod]
        public void Test_Page2()
        {
            IPageObject pageObject2 = new PageObjectTwo();
            Assert.AreEqual(pageObject2.PageName, "Page Name 2");
        }
    }
}
