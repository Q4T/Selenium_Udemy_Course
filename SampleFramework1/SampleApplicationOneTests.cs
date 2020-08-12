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
      
        internal SampleApplicationPage SampleAppPage { get; private set; }
      
        public TestUser TheTestUser { get; private set; }

        [TestMethod]
        [Description("User can fill out form")]
        public void Test1()
        {
            SampleAppPage.GoTo(); // has an assertion in the goto method 
            TheTestUser.GenderType = Gender.Female;
            var ultimateQAHomePage = SampleAppPage.FillOutFormAndSubmit(TheTestUser);
            AssertPageVisible(ultimateQAHomePage);
        }



        [TestMethod]
        [Description("User can fill out form again")]
        public void PretendTest2()
        {
            SampleAppPage.GoTo();
            TheTestUser.GenderType = Gender.Male;
            var ultimateQAHomePage = SampleAppPage.FillOutFormAndSubmit(TheTestUser);
            AssertPageVisible(ultimateQAHomePage);
        }

        [TestMethod]
        [Description("Other Gender can fill out form again")]
        public void OtherGenderTest()
        {
            SampleAppPage.GoTo();
            TheTestUser.GenderType = Gender.Other;
            var ultimateQAHomePage = SampleAppPage.FillOutFormAndSubmit(TheTestUser);
            AssertPageVisible(ultimateQAHomePage);
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
            SampleAppPage = new SampleApplicationPage(Driver);
            TheTestUser = new TestUser();
            TheTestUser.firstName = "Wilfred";
            TheTestUser.lastName = "Wooftingtonshire the third";
        }

        private static void AssertPageVisible(ultimateQAHomePage ultimateQAHomePage)
        {
            Assert.IsTrue(ultimateQAHomePage.IsVisible, "UltimateQA page was not visible");
        }
    }
}
  