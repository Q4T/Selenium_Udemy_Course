using OpenQA.Selenium;

namespace SampleFramework1
{
    public class ultimateQAHomePage : BaseSampleApplicationPage
    {

        // constructer inheriting driver from base class
        public ultimateQAHomePage(IWebDriver driver) : base(driver) { }

        public bool IsVisible => PageHeadingText.Displayed;

        public IWebElement PageHeadingText => Driver.FindElement(By.XPath("//h1[contains(text(),'The Complete Selenium WebDriver with Java Bootcamp')]"));
    }
}