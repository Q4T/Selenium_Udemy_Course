using OpenQA.Selenium;

namespace SampleApp2
{
    internal class SearchPage
    {
        private IWebDriver Driver { get; set; }

        public SearchPage(IWebDriver driver)
        {
            Driver = driver;
        }


    }
}