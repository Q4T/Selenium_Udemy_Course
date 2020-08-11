using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SampleFramework1
{
    [TestClass]
    [TestCategory("TestApplicationOne")]
    public class SampleApplicationOneTests
    {
        private IWebDriver Driver { get; set; }     // CTRL click on driver on this line to let the IDE change it to Driver wioth a capital D as it is a property not a field. 
        public TestUser TheTestUser { get; private set; }

        [TestMethod]
        [Description("User can fill out form")]
        public void Test1()
        {
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo(); // has an assertion in the goto method 
            TheTestUser.GenderType = Gender.Female;
            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);            
            Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA page was not visible");
        }
       
        [TestMethod]
        [Description("User can fill out form again")]
        public void PretendTest2()
        {
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo();
            TheTestUser.GenderType = Gender.Male;
            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
            Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA page was not visible");
        }

        [TestMethod]
        [Description("Other Gender can fill out form again")]
        public void OtherGenderTest()
        {
            
            var sampleApplicationPage = new SampleApplicationPage(Driver);
            sampleApplicationPage.GoTo();
            TheTestUser.GenderType = Gender.Other;
            var ultimateQAHomePage = sampleApplicationPage.FillOutFormAndSubmit(TheTestUser);
            Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA page was not visible");
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestCleanup]
        public void CleanUpAfterTest()
        {
            Driver.Close();
            Driver.Quit();
        }

        [TestInitialize]
        public void SetUpDriverForEachTest()
        {
            Driver = GetChromeDriver();
            TheTestUser = new TestUser();
            TheTestUser.firstName = "Wilfred";
            TheTestUser.lastName = "Wooftingtonshire the third";
        }
    }
}
  