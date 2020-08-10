using OpenQA.Selenium;
using System;

namespace SampleFramework1
{
    internal class SampleApplicationPage : BaseSampleApplicationPage
    {
        // constructer inheriting driver from base class
        public SampleApplicationPage(IWebDriver driver) : base(driver) { }

        public bool IsVisible
        { 
            get
            {
                return Driver.Title.Contains("Sample Application Lifecycle - Sprint 2 - Ultimate QA");
            }
            set { }
        }

        public IWebElement firstNameField => Driver.FindElement(By.Name("firstname"));
        public IWebElement submitButton => Driver.FindElement(By.XPath("//*[@class='entry-content']/form/input[3]"));

        public IWebElement lastNameField => Driver.FindElement(By.Name("lastname"));

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-2/"); 
        }

        //internal object FillOutFormAndSubmit(string v)    this is generated automatically when we CTRL dot on 
        //                                                  sampleApplicationPage in the SampleApplicationOne class
        //                                                  We need to set the return TYPE to ultimateQAHomePage which is a new page we want to create 

     //   public ultimateQAHomePage FillOutFormAndSubmit(string firstName, string lastName)
        public ultimateQAHomePage FillOutFormAndSubmit(TestUser user)
        {
            firstNameField.SendKeys(user.firstName);
            lastNameField.SendKeys(user.lastName);
            submitButton.Submit();
            return new ultimateQAHomePage(Driver);
        }


    } 
}