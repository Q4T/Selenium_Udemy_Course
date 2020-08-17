using OpenQA.Selenium;
using System;

namespace SampleApp2
{
    public class Slider : BaseAppPage
    {
        public string CaptureImage => Driver.FindElement(By.Id("homeslider")).GetAttribute("style");

        public Slider(IWebDriver driver) : base(driver)
        {
            
        }

        internal void ClickNextButton()
        {
            Driver.FindElement(By.ClassName("bx-next")).Click();
        }
    }
}