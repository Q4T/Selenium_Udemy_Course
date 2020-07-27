using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ElementInteractions
{
    [TestClass]
    public class ElementIdentification
    {

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestMethod]
        public void Manipulation()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");
            // find the name field
            var nameField = driver.FindElement(By.XPath("//input[@id= 'et_pb_contact_name_0']"));
            //clear the field
            nameField.Clear();

            //type into the field
            nameField.SendKeys("Woof Woof");

            // find the name field
            var txtBox = driver.FindElement(By.XPath("//textarea[@id= 'et_pb_contact_message_0']"));
            //clear the field
            txtBox.Clear();
            //type into the field
            txtBox.SendKeys("Arse");
            // submit
       //     var submit = driver.FindElement(By.XPath("//div[@id='et_pb_contact_form_0']/div/form/div/button"));    // my long winded OLD way
      //      var submit1 = driver.FindElement(By.XPath("//*[@class='et_pb_contact_submit et_pb_button']"));     // thre are 2 but it returns the first one in finds
     //       submit1.Submit();


            // could also have used find elemenets to return a collection
            var submit2 = driver.FindElements(By.XPath("//*[@class='et_pb_contact_submit et_pb_button']"));
            submit2[0].Submit();

        }
    }
}
