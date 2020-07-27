using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ElementInteractions
{
    [TestClass]
    public class Navigation_Test
    {
        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestMethod]
        public void TestMethod1()    
        {

            var driver = GetChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ultimateqa.com/");
            Assert.AreEqual("Home - Ultimate QA", driver.Title);

            // go here: https://ultimateqa.com/automation and assert title
            driver.Navigate().GoToUrl("https://ultimateqa.com/automation");
            Assert.AreEqual("Automation Practice - Ultimate QA", driver.Title);
            // click link for href - / complicatedPage
            driver.FindElement(By.XPath("//a[@href= '../complicated-page']")).Click();

            // Assert page title "Complicated Page - Ultimate QA"
            Assert.AreEqual("Complicated Page - Ultimate QA", driver.Title);

            // Go Back
            driver.Navigate().Back();

            //   Assert page title equals  - "Automation Practice - Ultimate QA"
            Assert.AreEqual("Automation Practice - Ultimate QA", driver.Title);
        }
    }
}
