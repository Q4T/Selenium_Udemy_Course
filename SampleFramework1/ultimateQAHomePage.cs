using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SampleFramework1
{
    public class ultimateQAHomePage : BaseSampleApplicationPage
    {

        // constructer inheriting driver from base class
        public ultimateQAHomePage(IWebDriver driver) : base(driver) { }

        public bool IsVisible
        { 
            get
            {
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                Assert.IsTrue(wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[contains(text(),'The Complete Selenium WebDriver with Java Bootcamp')]"))).Displayed);

                try
                {
                    return PageHeadingText.Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }

        public IWebElement PageHeadingText => Driver.FindElement(By.XPath("//h1[contains(text(),'The Complete Selenium WebDriver with Java Bootcamp')]"));

//        public void waitForUltimnateQAPageToLoad()
//        {
//            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
//            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[contains(text(),'The Complete Selenium WebDriver with Java Bootcamp')]")));
//            //    wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Automation Exercises")));
//        }
    }
}