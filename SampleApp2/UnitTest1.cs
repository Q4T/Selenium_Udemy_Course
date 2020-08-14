using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SampleApp2
{
    [TestClass]
    public class SearchFunctionality
    {
        

        public IWebElement BlouseProductReturned => Driver.FindElement(By.XPath("//*[@class='product_img_link'][@title='Blouse']"));
        private IWebDriver Driver { get; set; }


        [TestMethod]
        [TestCategory("Search Functionality")]
        [Description("Its a test")]
        [TestProperty("Author", "Gareth Evans")]
       
        public void TestMethod1()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            SearchPage searchPage = homePage.Search("blouse");
            
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Assert.IsTrue(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='product_img_link'][@title='Blouse']"))).Displayed);




            
            
            
            
            
         //   Assert.IsTrue(BlouseProductReturned.Displayed);
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestInitialize]
        public void testSetup()
        {
            Driver = GetChromeDriver();
        }
    }
}






