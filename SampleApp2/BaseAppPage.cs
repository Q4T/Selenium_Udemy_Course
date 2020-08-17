using OpenQA.Selenium;

namespace SampleApp2
{
    public class BaseAppPage
    {
        private IWebDriver driver;

        public BaseAppPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}