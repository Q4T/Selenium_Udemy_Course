using OpenQA.Selenium;

namespace SampleFramework1
{
    public class BaseSampleApplicationPage
    {
        protected IWebDriver Driver { get; set; }  // can be a field but you get to the ther references to see where it is used if its a property

        public BaseSampleApplicationPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
