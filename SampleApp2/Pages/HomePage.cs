using NLog;
using OpenQA.Selenium;
using System;

namespace SampleApp2
{
    internal class HomePage : BaseAppPage
    {
        public HomePage(IWebDriver driver): base(driver)
        {
            Slider = new Slider(driver);

        }

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private IWebElement SearchBox => Driver.FindElement(By.Id("search_query_top"));
        private IWebElement SubmitSearchButton => Driver.FindElement(By.XPath("//button[@name='submit_search']"));

        public Slider Slider { get; internal set; }

        internal void GoTo()
        {
            var url = "http://automationpractice.com/";
            Driver.Navigate().GoToUrl(url);
            _logger.Info($"opened URL: {url}");
        }

        // The search is initiated from the homepage but returns a value on the searchPage and so we need a driver for the search page to check the result so we pass one to it.
        internal SearchPage Search(string itemToSearchFor)
        {
            SearchBox.SendKeys(itemToSearchFor);
            SubmitSearchButton.Submit();
            _logger.Info($"Searched for item: {itemToSearchFor}");
            return new SearchPage(Driver);  // return a new searchPage driver because it returns the result to the search page and we need to then 
            // do stuff on that searchPage.
            
        }

    }

}