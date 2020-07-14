using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace ElementInteractions
{
    [TestClass]
    public class ElementLocatorExam
    {

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestMethod]
        public void ElementLocatorsTest()
        {
            // create a driver
            var driver = GetChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://ultimateqa.com/simple-html-elements-for-automation/");

            //click any radio button, hint:  FindElement().Click();
            driver.FindElement(By.XPath("//input[@type='radio'][@value='male']")).Click();

            //select one checkbox

            //select Audi from the dropdown


            //open Tab2 and assert that it is opened. Hint, use .Text property when you find the element

            //in the HTML Table with id, highlight one of the salary cells

            //Highlight the center section called "Highlight me", but you can only
            //highlight the highest level div for that element. The top parent div.
            //Hint, this is the class - 
            //et_pb_column et_pb_column_1_3  et_pb_column_10 et_pb_css_mix_blend_mode_passthrough




        }






    }

}
