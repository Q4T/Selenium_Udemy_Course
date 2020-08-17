using System;
using AutomationResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace SampleApp2
{
    [TestClass]
    [TestCategory("Contact Us Feature"),TestCategory("SampleApp2")]
    public class ContactUsFeature : BaseTest
    {
        [TestMethod]
        [TestProperty("Author", "Gareth Evans")]
        [Description("TCID2")]
        public void TCID2()
        {
            ContactUsPage contactUsPage = new ContactUsPage(Driver);
            contactUsPage.GoTo();
            Assert.IsTrue(contactUsPage.IsLoaded);
        } 
    }
}
