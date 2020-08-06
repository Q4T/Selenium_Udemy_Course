using OpenQA.Selenium;
using System;

namespace TDDPractice
{
    public class ComplicatedPage
    {
        public ComplicatedPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        internal void Open()
        {
            // throw new NotImplementedException();
            Driver.Navigate().GoToUrl("https://ultimateqa.com/complicated-page");
            Driver.Manage().Window.Maximize();
        }
/*
        internal void SearchUsingTopNav(string testToSearch)     // this should probably go into a topNav page but doing an example
        {
            var topNavSearchIcon = Driver.FindElement(By.Id("et_search_icon"));
           
            topNavSearchIcon.Click();
            var searchBar = Driver.FindElement(By.ClassName("search-field jetpack-instant-search__box-input"));
            searchBar.SendKeys(testToSearch);
            */
        }
    }
}