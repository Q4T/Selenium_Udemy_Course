using OpenQA.Selenium;
using System;

namespace SampleApp2
{
    internal class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; private set; }
        public IWebElement SearchBox => Driver.FindElement(By.Id("search_query_top"));
        public IWebElement SubmitSearchButton => Driver.FindElement(By.XPath("//button[@name='submit_search']"));

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        // why does he create a method on the homepage that calls the searchPage method?
        // And why does it have to return a new searchPage driver?

        internal SearchPage Search(string itemToSearchFor)
        {
            SearchBox.SendKeys(itemToSearchFor);
            SubmitSearchButton.Submit();
            return new SearchPage(Driver);  // And why does it have to return a new searchPage driver?
        }

    }
}