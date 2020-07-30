using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace ExplicitWaits
{
    [TestClass]
    public class UnitTest1
    {

     /*   private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }  
        
     */

        [TestMethod]
        public void ExplicitWaitTest()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            var successMessage = By.XPath("//*[@class='entry-title']");

            var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("idExample"))).Click();
        //  Assert.IsTrue(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='entry-title']"))).Displayed);
            Assert.IsTrue(wait.Until(ExpectedConditions.ElementIsVisible(successMessage)).Displayed);
        //  Assert.IsTrue(wait.Until(ExpectedConditions.TextToBePresentInElementValue(successMessage, "Button success")));
        //  wait.Until(ExpectedConditions.TextToBePresentInElementValue(successMessage, "Button success"));
        }
    }
}
