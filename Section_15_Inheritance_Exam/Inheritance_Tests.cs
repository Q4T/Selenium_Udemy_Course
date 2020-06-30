using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_15_Inheritance_Exam
{
    [TestClass]
    public class Inheritance_Tests
    {
        [TestMethod]
        public void ComplicatedPageNameTest()
        {
            ComplicatedPage compPage = new ComplicatedPage();
            string retName = compPage.pageName();
            Assert.AreEqual(retName, "Complicated Page");
        }

        [TestMethod]
        public void SectionOfRandomStuffTest()
        {

        }

        [TestMethod]
        public void SectionOfButtonsTest()
        {

        }

    }

}
