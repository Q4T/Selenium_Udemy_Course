using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace ElementInteractions
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [Obsolete]
        public void ClickUsingAllByMethods()
        {
            By linkText = By.LinkText("Click this link");
            By clickableLink = By.Name("clickableLink");

            // create a driver
            var driver = GetChromeDriver();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

            //            IWebElement linkSuccess = driver.FindElement(By.ClassName("entry-title"));
            //            IWebElement ButtonSuccess = driver.FindElement(By.ClassName("entry-title"));

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");

            // click button
            driver.FindElement(By.ClassName("buttonClass")).Click();

            // define success class
            IWebElement SuccessMsg = driver.FindElement(By.ClassName("entry-title"));

            // wait for success mesg
            wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Button success"));
            driver.Navigate().Back();

            // click This button using id
            wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("idExample"))).Click();

            // wait for success link
            driver.FindElement(By.XPath("//h1[.='Button success']"));      // add a wait condition to this.
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath("//h1[.='Button success']")))).Click();
   //         wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath("//h1[.='Button success']"))));

            //         //  wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Button success"));    // not finding the text Button success
            driver.Navigate().Back();

            // Click Link Text "click this link"
           wait.Until(ExpectedConditions.ElementToBeClickable(linkText)).Click();


            // wait for link success
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath("//h1[.='Link success']"))));
       //     wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Link success"));
            driver.Navigate().Back();

            // click "Click this link" 
            wait.Until(ExpectedConditions.ElementToBeClickable(clickableLink)).Click();


            //        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            //        js.ExecuteScript("window.scrollTo(0, 0)");


            // wait for link success
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath("//h1[.='Link success']"))));
          //  wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Link success"));
            driver.Navigate().Back();

            // Click This link
            wait.Until(ExpectedConditions.ElementToBeClickable(By.PartialLinkText("this link"))).Click();

            // wait for success
      //      wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Link success"));
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath("//h1[.='Link success']"))));
            driver.Navigate().Back();

            // click "click this link
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#simpleElementsLink"))).Click();

            // wait for success
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(By.XPath("//h1[.='Link success']"))));
      //      wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Link success"));
            driver.Navigate().Back();

            // click a button
            wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".buttonClass"))).Click();

            // wait for success
            wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Button success"));
            driver.Navigate().Back();

            // click "click this button using id"
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='idExample']"))).Click();

            // wait for success
            wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Button success"));
            driver.Navigate().Back();

            // scroll to element
            var element1 = driver.FindElement(By.XPath("//*[@class='buttonClass']"));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element1);
            actions.Perform();

            // click button using class name
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@class='buttonClass']"))).Click();

            // wait for success
            wait.Until(ExpectedConditions.TextToBePresentInElement(SuccessMsg, "Button success"));

            driver.Close();
        }


        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }


    }
}
