using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
                return Driver.Title.Contains(PageTitle);
            }
            set { }
        }

        public IWebElement firstNameField => Driver.FindElement(By.Name("firstname"));
       
        public IWebElement submitButton => Driver.FindElement(By.XPath("//*[@class='entry-content']/form/input[3]"));
       
        public IWebElement lastNameField => Driver.FindElement(By.Name("lastname"));

        internal void SelectMaleRadioButton()
        {
            var maleRadioBttn = Driver.FindElement(By.XPath("//*[@value='male']"));
            maleRadioBttn.Click();
        }

        internal void SelectFemailRadioButton()
        {
            var maleRadioBttn = Driver.FindElement(By.XPath("//*[@value='female']"));
            maleRadioBttn.Click();
        }

        private string PageTitle => "Sample Application Lifecycle – Sprint 3";

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-3/");
            //Assert.IsTrue(IsVisible, "Sample application page not visible");
            Assert.IsTrue(IsVisible, $"Sample application page not visible. Expected = {PageTitle}. " + 
            $"Actual = {Driver.Title}");
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