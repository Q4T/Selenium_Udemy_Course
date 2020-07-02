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
            string retName = compPage.PageName;
            Assert.AreEqual(retName, "Complicated Page");
        }

        [TestMethod]
        public void SectionOfRandomStuffTest()
        {
            SectionOfRandomStuff randomStuff = new SectionOfRandomStuff();
            randomStuff.FillForm();
        }

        [TestMethod]
        [ExpectedException (typeof(System.NullReferenceException))]
        public void SectionOfButtonsTest()
        {
         
            SectionOfButtons buttons = new SectionOfButtons();
            buttons.Button.Click();
            // we have to add the ExpectedException to this because we have not created an instance of the Element class
            // Other options would be to make the Element class abstract so that we don't have to create an instance or create an instance of Element


        }

    }

}
