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

        public object Slider { get; internal set; }

        internal void GoTo()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        // The search is initiated from the homepage but returns a value on the searchPage and so we need a driver for the search page to check the result so we pass one to it.
        internal SearchPage Search(string itemToSearchFor)
        {
            SearchBox.SendKeys(itemToSearchFor);
            SubmitSearchButton.Submit();
            return new SearchPage(Driver);  // return a new searchPage driver because it returns the result to the search page and we need to then 
            // do stuff on that searchPage.
        }

    }
}