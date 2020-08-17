using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace SampleApp2
{
    internal class ContactUsPage :BaseAppPage
    {
        public IWebDriver Driver { get; private set; }

        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            Driver = driver;
        }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=contact");
          //  Assert.AreEqual(Driver.Title, "Contact us - My Store");
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