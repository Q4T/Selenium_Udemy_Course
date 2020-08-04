using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace User_Interactions_Mouse_DragNDrop
{

    // installed nUmit for this via NuGet packages
    // Use https://jqueryui.com/droppable/   to test drag and drop




    [TestFixture]
    public class InteractionsDemo
    {
       [Test]
        public void Example1()
        {
            var driver = new ChromeDriver();
            var actions = new Actions(driver);

            var dropToElement = driver.FindElement(By.Id("droppable"));
            var dragElement = driver.FindElement(By.Id("draggable"));

            driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");        

    }
}
