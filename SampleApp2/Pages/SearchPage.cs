using NLog;
using OpenQA.Selenium;
using System;

namespace SampleApp2
{
    internal class SearchPage
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        private IWebDriver Driver { get; set; }

        public SearchPage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal bool Contains(Item itemToCheckFor)
        {
            switch (itemToCheckFor)
            {
                case Item.Blouse:
                    return Driver.FindElement(By.XPath("//*[@class='product_img_link'][@title='Blouse']")).Displayed;
                default:
                    throw new ArgumentOutOfRangeException("Item does not exist");
            }
                
       

        }
    }
}