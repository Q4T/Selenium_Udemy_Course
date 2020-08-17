using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using OpenQA.Selenium;
using System;

namespace SampleApp2
{
    internal class ContactUsPage :BaseAppPage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public ContactUsPage(IWebDriver driver) : base(driver)
        {
        }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
        }

        public bool IsLoaded
        {
            get
            {
                try
                {
                    return Driver.FindElement(By.XPath("//*[contains(text(),'Customer service - Contact us')]")).Displayed;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }
        }
    }
}