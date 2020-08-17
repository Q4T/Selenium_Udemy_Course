using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleApp2
{
    [TestClass]
    [TestCategory("Test Slider"), TestCategory("SampleApp2")]
    public class SliderFeature : BaseTest
    {
        [TestMethod]
        public void TCID3()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.GoTo();
            homePage.Slider
        }
    }
}
