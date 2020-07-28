using System;
using System.Collections;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ElementInteractions
{
    [TestClass]
    public class ElementIdentificationQuiz
    {

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        [TestMethod]
        public void TestMethod1()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/filling-out-forms/");

            // enter name
            var nameField = driver.FindElement(By.XPath("//input[@id='et_pb_contact_name_1']"));       
  //          nameField.Clear();
            nameField.SendKeys("work");

            // enter text
            var textBox = driver.FindElement(By.XPath("//textarea[@id='et_pb_contact_message_1']"));
   ///         textBox.Clear();
            textBox.SendKeys("you know");

            // catch values in capture as ints
            string numbers = driver.FindElement(By.XPath("//span[@class='et_pb_contact_captcha_question']")).Text;

            string[] listNumbers = numbers.Split('+');

            // convert from string to int
           int num1 = int.Parse(listNumbers[0]);
           int num2 = int.Parse(listNumbers[1]);

            // add the ints
            int sum = num1 + num2; 
            Console.WriteLine(sum);

            // enter the sum
            //input[@class='input et_pb_contact_captcha']
            var captchaInputTextBox = driver.FindElement(By.XPath("//input[@class='input et_pb_contact_captcha']"));
            string stringSum = sum.ToString();
            captchaInputTextBox.SendKeys(stringSum);

            // submit
            var subBttn2 = driver.FindElements(By.XPath("//button[@name='et_builder_submit_button']"));
            subBttn2[1].Submit();

            //test success
            var sucmsg = driver.FindElement(By.XPath("//div[@class='et-pb-contact-message']/p"));    // the test fails here due to a bug in the app where it ask to referesh the page and try again.
           
            // alternative version - more complicated but potentially useful
            var successmsg = driver.FindElements(By.ClassName("et-pb-contact-message"))[1].FindElements(By.TagName("p"));
           // var a = sucmsg.Text;
            Assert.AreEqual("success", sucmsg.Text);
        }

        [TestMethod]

        public void DriverInterogation()
        {

            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/automation/");

            var currentWindowHandle = driver.CurrentWindowHandle;
            var allhandles = driver.WindowHandles;  // a collection of all tabs indexed.
            var title = driver.Title;
            var url = driver.Url;

            Console.WriteLine(currentWindowHandle);
            Console.WriteLine(allhandles);
            Console.WriteLine(title);
            Console.WriteLine(url);
   
        }
        [TestMethod]
        public void ElementInterogation()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://ultimateqa.com/automation/");

            var myElement = driver.FindElement(By.XPath("//*[@href='../complicated-page']"));
            var cssExample = myElement.GetCssValue("box-sizing");
            Console.WriteLine(cssExample);
            var getAttribExample = myElement.GetAttribute("text");
            Console.WriteLine(getAttribExample);
        }


    }
}
