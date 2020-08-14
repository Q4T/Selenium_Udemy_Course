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

       

        public IWebElement FirstNameFieldEmergencyContact => Driver.FindElement(By.Id("f2"));
       
        public IWebElement LastNameFieldEmergencyContact => Driver.FindElement(By.Id("12"));

        public IWebElement SubmitButtonEmergencyContact => Driver.FindElement(By.Id("submit2"));

        public IWebElement FirstNameField => Driver.FindElement(By.Name("firstname"));

        public IWebElement LastNameField => Driver.FindElement(By.Name("lastname"));

        public IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@class='entry-content']/form/input[3]"));

        public IWebElement MaleRadioButton => Driver.FindElement(By.XPath("//*[@value='male']"));

        public IWebElement FemaleRadioButton => Driver.FindElement(By.XPath("//*[@value='female']"));

        public IWebElement FemaleEmergencyContactRadioButton => Driver.FindElement(By.XPath("//*[@id='radio2-f']"));

        public IWebElement OtherRadioButton => Driver.FindElement(By.XPath("//*[@value='other']"));

        private string PageTitle => "Sample Application Lifecycle - Sprint 4 - Ultimate QA";

        internal void FillOutEmergencyContactForm(TestUser emergencyContactUser)
        {
            SelectGenderEmergencyContact(emergencyContactUser);
            FirstNameFieldEmergencyContact.SendKeys(emergencyContactUser.firstName);
            LastNameFieldEmergencyContact.SendKeys(emergencyContactUser.lastName);
        //    SubmitButtonEmergencyContact.Submit(); 
        }

        private void SelectGenderEmergencyContact(TestUser user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
            //        MaleEmergencyContactRadioButton.Click();
                    break;
                case Gender.Female:
                    FemaleEmergencyContactRadioButton.Click();
                    break;
                case Gender.Other:
           //         OtherEmergencyContactRadioButton.Click();
                    break;
                default:
                    break;
            }
        }

        internal void GoTo()
        {  
            Driver.Navigate().GoToUrl("https://ultimateqa.com/sample-application-lifecycle-sprint-4/");
            //Assert.IsTrue(IsVisible, "Sample application page not visible");
            Assert.IsTrue(IsVisible, $"Sample application page not visible. Expected = {PageTitle}. " + 
            $"Actual = {Driver.Title}");
        }

        public ultimateQAHomePage FillOutPrimaryUserFormAndSubmit(TestUser user)
        {
            SelectGender(user);
            FirstNameField.SendKeys(user.firstName);
            LastNameField.SendKeys(user.lastName);
            SubmitButton.Submit();
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