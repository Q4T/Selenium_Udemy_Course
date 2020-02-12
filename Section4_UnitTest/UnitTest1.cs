using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 Location: C:\Users\EvansG\source\repos\Udemy_Course
 */

namespace Section4_UnitTest
{
    [TestClass]
    [TestCategory("LoginFeature")]

    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("positive")]
        [Description("DemoTest")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
         Assert.AreEqual(3,a+b);  // better as it gives a better error msg.
         Assert.AreNotEqual(a,4);
        }

        [TestMethod]
        public void TestMethod2()
        {
        }
    }
}
