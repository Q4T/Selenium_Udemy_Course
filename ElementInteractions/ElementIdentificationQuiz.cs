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
            nameField.Clear();
            nameField.SendKeys("Woofy");

            // enter text
            var textBox = driver.FindElement(By.XPath("//textarea[@id='et_pb_contact_message_1']"));
            textBox.Clear();
            textBox.SendKeys("arse");

            // catch values in capture as ints
            string numbers = driver.FindElement(By.XPath("//span[@class='et_pb_contact_captcha_question']")).Text;

            string[] listNumbers = numbers.Split('+');

            // add the ints
            var sum = listNumbers[0] + listNumbers[1];    // need to convert them to ints
            // char num1 = listNumbers[0];
            Console.WriteLine(sum);

            // enter the sum

            // submit
        }
    }
}
