using OpenQA.Selenium;

namespace SampleApp2
{
    public class BaseAppPage
    {
        public IWebDriver Driver;

        public BaseAppPage(IWebDriver driver)
        {
           Driver = driver;
        }
    }
}