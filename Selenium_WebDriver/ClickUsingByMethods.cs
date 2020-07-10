using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Selenium_WebDriver
{
    [TestClass]
    public class ClickUsingByMethods
    {
        [TestMethod]
        public void TestMethod1()
        {
            var driver = GetChromeDriver();
            driver.Navigate().GoToUrl("http://www.ultimateqa.com");
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }
    }
}
