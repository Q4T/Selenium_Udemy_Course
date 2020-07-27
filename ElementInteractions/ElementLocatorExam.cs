using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
//using System;
using System.IO;
using System.Reflection;

namespace ElementInteractions
{
    [TestClass]
    public class ElementLocatorExam
    {

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestMethod]
        public void ElementLocatorsTest()
        {
            // create a driver
            var driver = GetChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");

            //click any radio button, hint:  FindElement().Click();
            driver.FindElement(By.XPath("//input[@type='radio'][@value='male']")).Click();

            //select one checkbox
            // <input type="checkbox" name="vehicle" value="Bike">
            driver.FindElement(By.XPath("//*[@type='checkbox'][@value='Bike']")).Click();

            //select Audi from the dropdown
            driver.FindElement(By.TagName("select")).Click();
            driver.FindElement(By.XPath("//*[@value='audi']")).Click();

            //open Tab2 and assert that it is opened. Hint, use .Text property when you find the element
            driver.FindElement(By.XPath("//*[contains(text(),'Tab 2')]")).Click();

            Assert.AreEqual("Tab 2 content", driver.FindElement(By.XPath("//*[contains(text(),'Tab 2 content')]")).Text);
     
        }






    }

}
