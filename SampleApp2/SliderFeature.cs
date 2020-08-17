using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleApp2
{
    [TestClass]
    [TestCategory("Test Slider"), TestCategory("SampleApp2")]
    public class SliderFeature : BaseTest
    {
        [TestMethod]
        [Description("Adding a subsection of a page as a property to the homepage and then creating a class for it")]
        [TestCategory("Slider Feature")]
        public void TCID3()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            string firstImage = homePage.Slider.CaptureImage;
            homePage.Slider.ClickNextButton();
            string secondImage = homePage.Slider.CaptureImage;
            Assert.AreNotEqual(firstImage, secondImage);
        }
    }
}
