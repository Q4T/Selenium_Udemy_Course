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

        public IWebElement MaleRadioButton => Driver.FindElement(By.XPath("//*[@value='male']"));

        public IWebElement FemaleRadioButton => Driver.FindElement(By.XPath("//*[@value='female']"));

        public IWebElement OtherRadioButton => Driver.FindElement(By.XPath("//*[@value='other']"));

        private string PageTitle => "Sample Application Lifecycle - Sprint 3 - Ultimate QA";

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-3/");
            //Assert.IsTrue(IsVisible, "Sample application page not visible");
            Assert.IsTrue(IsVisible, $"Sample application page not visible. Expected = {PageTitle}. " + 
            $"Actual = {Driver.Title}");
        }

        public ultimateQAHomePage FillOutFormAndSubmit(TestUser user)
        {
            SelectGender(user);
            firstNameField.SendKeys(user.firstName);
            lastNameField.SendKeys(user.lastName);
            submitButton.Submit();
            return new ultimateQAHomePage(Driver);
        }

        private void SelectGender(TestUser user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    MaleRadioButton.Click();
                    break;
                case Gender.Female:
                    FemaleRadioButton.Click();
                    break;
                case Gender.Other:
                    OtherRadioButton.Click();
                    break;
                default:
                    break;
            }
        }
    } 
}