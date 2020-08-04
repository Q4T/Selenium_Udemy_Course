using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

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
        //    var successMessage = By.XPath("//*[@class='entry-title-woof']");   // test the failure mesg.
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
                wait.IgnoreExceptionTypes(typeof(InvalidCastException));    //  we can set to capture exceptions.
            //  wait.Message = "Gareth's message failure :-)"

                wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("idExample"))).Click();   // inculdes explicit ExpectedConditions before making the using statement static
           //     wait.Until(ElementToBeClickable(By.Id("idExample"))).Click();    // by using using static OpenQA.Selenium.Support.UI.ExpectedConditions;  we can remove the ExpectedConditions bit from code
                Assert.IsTrue(wait.Until(ExpectedConditions.ElementIsVisible(successMessage)).Displayed);
            }
            catch  (InvalidCastException) { }

            driver.Close();
            driver.Quit();
        }



        [TestMethod]
        public void HowToCorrectlySyncronise()
        {

          //go to ultimate.com
            ChromeDriver driver = new ChromeDriver();
            
            driver.Navigate().GoToUrl("https://ultimateqa.com");
            driver.Manage().Window.Maximize();

            var landingPng = By.XPath("//*[@src='https://ultimateqa.com/wp-content/uploads/2019/08/tb.png']");
            var autoLink = By.XPath("//a[@href='https://ultimateqa.com/automation/']");
            var QALogo = By.XPath("//link[href='https://ultimateqa.com/wp-content/uploads/2016/04/QALOGO.png']");
            var BigPage = By.XPath("//a[@href='../complicated-page']");


          // sync to slow element
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(landingPng));

            // click on automation exercise link
            wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Automation Exercises")));   // we can wait or click by.Linktext - there is alos a partial link text !
            driver.FindElement(autoLink).Click();

            // sync 
            //     wait.Until(ExpectedConditions.ElementIsVisible(QALogo));

            //              click on big page with many element
            driver.FindElement(BigPage).Click();

 //               sync
 //               Assert page loaded


        


        }
    }
}
