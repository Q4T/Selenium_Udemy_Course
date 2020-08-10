using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace TDDPractice
{
    [TestClass]
    public class ComplicatedPageTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var driver = new ChromeDriver(path);
            var complicatedPage = new ComplicatedPage(driver);
            complicatedPage.Open();
         //   complicatedPage.SearchUsingTopNav("page object");
        }
    }
}
