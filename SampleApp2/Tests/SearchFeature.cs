using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SampleApp2
{
    [TestClass]
    public class SearchFeature : BaseTest
    {
      //  public IWebElement BlouseProductReturned => Driver.FindElement(By.XPath("//*[@class='product_img_link'][@title='Blouse']"));

        [TestMethod]
        [TestCategory("Search Feature"), TestCategory("SampleApp2")]
        [Description("Its a test")]
        [TestProperty("Author", "Gareth Evans")]
       
        public void TCID1()
        {
            string itemToSearch = "Blouse";

            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            SearchPage searchPage = homePage.Search(itemToSearch);  //we assign a var of type SearchPage to the homePage.Search() method because we search 
            Assert.IsTrue(searchPage.Contains(Item.Blouse),    // from the homepage but get a value returned on the search page and we will need a searchPage driver to interact withb that page.
                $"When searching for: {itemToSearch} ," + 
                $"The search term was not found");                        
        }

    }
}






