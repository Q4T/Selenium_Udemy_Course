using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section4_UnitTest
{
    [TestClass]
    [TestCategory("Quiz")]
    public class Tests2
    {
        [TestMethod]
        public void test1()
        {
            var a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);

        }
        [TestMethod]
        public void test2()
        {
            var x = 1;
            var y = 2;
            Assert.AreEqual(3, x + y);
            Assert.Fail();     // forces a failure
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void test3()
        {
            int a = 10;
            int b = 10;
            Assert.AreEqual(21, a + b);
        }
    }
}
