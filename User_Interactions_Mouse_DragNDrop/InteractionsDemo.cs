using System;
using NUnit.Framework;  // using nUnit not MS test framework
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace User_Interactions_Mouse_DragNDrop
{

    // installed nUmit for this via NuGet packages
    // Use https://jqueryui.com/droppable/   to test drag and drop

    [TestFixture]
    public class InteractionsDemo
    {

        private Actions _actions;
        private ChromeDriver _driver;
        private WebDriverWait _wait;
   

        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _actions = new Actions(_driver);
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();

        }

        [Test]
        public void DragAndDropExample1()
        {

            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _driver.Manage().Window.Maximize();

            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

            IWebElement targetElement = _driver.FindElement(By.Id("droppable"));
            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));

            _actions.DragAndDrop(sourceElement, targetElement).Perform();

              Assert.AreEqual("Dropped!", targetElement.Text);

            // We can also build an action and perform it later like this
            //        var DragNDropAction = actions.DragAndDrop(sourceElement, targetElement).Build();
            //        DragNDropAction.Perform();
        }

        [Test]
        public void DragAndDropExample2()
        {
            _driver.Navigate().GoToUrl("https://jqueryui.com/droppable/");
            _driver.Manage().Window.Maximize();

            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

            IWebElement targetElement = _driver.FindElement(By.Id("droppable"));
            IWebElement sourceElement = _driver.FindElement(By.Id("draggable"));

            var drag = _actions
                .ClickAndHold(sourceElement)
                .MoveToElement(targetElement)
                .Release(targetElement)
                .Build();

            drag.Perform();
            Assert.AreEqual("Dropped!", targetElement.Text);

        }
        [Test]
        public void DragAndDropQuiz()
        {

            _driver.Navigate().GoToUrl("http://www.pureexample.com/jquery-ui/basic-droppable.html");
            _driver.Manage().Window.Maximize();
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.Id("ExampleFrame-94")));

            var targetElement = _driver.FindElement(By.XPath("//div[@class='squaredotted ui-droppable']"));
            var sourceElement = _driver.FindElement(By.XPath("//div[@class='square ui-draggable']"));
            var message = _driver.FindElement(By.Id("info"));   // could have added .Text to the end of this aswell and just asserted on message

            _actions.DragAndDrop(sourceElement, targetElement).Perform();
            _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("info")));
            Assert.AreEqual("dropped!", message.Text);
        }

        [Test]
        public void ResizingExample()
        {

            _driver.Navigate().GoToUrl("https://jqueryui.com/resizable/");
            _driver.Manage().Window.Maximize();
            _wait.Until(ExpectedConditions.FrameToBeAvailableAndSwitchToIt(By.ClassName("demo-frame")));

            IWebElement resizeHandle = _driver.FindElement(By.XPath("//div[@class='ui-resizable-handle ui-resizable-se ui-icon ui-icon-gripsmall-diagonal-se']"));
            _actions.ClickAndHold(resizeHandle).MoveByOffset(100, 100).Perform();
            Assert.IsTrue(_driver.FindElement(By.XPath("//div[@id='resizable' and @style]")).Displayed);
        }

        [Test]

        public void KeysExample()
        {
            _driver.Navigate().GoToUrl("http://google.com");
            _driver.Manage().Window.Maximize();

            var searchBar = _driver.FindElement(By.Name("q"));
            searchBar.Click();
            var searchBttn = _driver.FindElement(By.Name("btnK"));

            _actions.SendKeys("Hello").Perform();
            searchBttn.Click();

            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@class='LC20lb MMgsKf']")));

            var linkAdel = _driver.FindElement(By.XPath("//*[@class='LC20lb MMgsKf']"));
            Assert.IsTrue((linkAdel).Displayed);
        }




    }
}
