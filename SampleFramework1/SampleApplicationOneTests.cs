using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleFramework1
{
    [TestClass]
    [TestCategory("TestApplicationOne")]
    public class SampleApplicationOneTests
    {
        //        private IWebElement driver;   we need to make this a property rather than a field
        private IWebDriver Driver { get; set; }     // CTRL click on driver on this line to let the IDE change it to Driver wioth a capital D as it is a property not a field. 
        public TestUser TheTestUser { get; private set; }

        [TestMethod]
        public void Test1()
        {
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo();
            Assert.IsTrue(sampleApplicationPage.IsVisible, "Sample application page not visible");

            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
            Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA page was not visible");
        }
       
        [TestMethod]
        public void PretendTest2()
        {
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo();
            Assert.IsTrue(sampleApplicationPage.IsVisible, "Sample application page not visible");

            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
            Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA page was not visible");
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestCleanup]
        private void CleanUpAfterTest()
        {
            Driver.Close();
            Driver.Quit();
        }

        [TestInitialize]
        private void SetUpDriverForEachTest()
        {
            Driver = GetChromeDriver();
            TheTestUser = new TestUser();
            TheTestUser.firstName = "Wilfred";
            TheTestUser.lastName = "Wooftingtonshire the third";
        }
    }
}
  