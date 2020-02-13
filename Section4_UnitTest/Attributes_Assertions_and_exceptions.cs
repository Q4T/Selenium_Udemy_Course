using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 Location: C:\Users\EvansG\source\repos\Udemy_Course (work)

    Lesson 45 Assertions
    Lesson 46 Exceptions

    [ExpectedException] is almost never used in functional test automation. I actually can't think of a time that I used it.
    This attribute is very common in unit testing, when you would expect some method to throw some exception.
 */

namespace Section4_UnitTest
{
    [TestClass]
    [TestCategory("LoginFeature")]

    public class Attributes_Assertions_and_exceptions
    {
        [TestMethod]
        [TestCategory("positive")]
        [Description("DemoTest")]
        public void TestMethod1()
        {
            var a = 1;
            var b = 2;
         Assert.AreEqual(3,a+b);  // better as it gives a better error msg. Shows what was expected and what was returned.
         Assert.AreNotEqual(a,4);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException ))]    // so now with this exception the test will fail if the excemtopn in NOT thrown
        public void TestMethod2()
        {
            var a = 1;
            Assert.IsTrue(a == 1);  //doesnt give a very useful error msg, just that it fails.
            Assert.AreNotEqual(1, a);   // This fails, but the test fasses becasue of the exception handler
        }
    }
}
