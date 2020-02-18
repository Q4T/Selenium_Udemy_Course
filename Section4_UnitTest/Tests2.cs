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
    /* ********************
     * look up uncle Bob  dev. 
     * 
     * TestInitialize   very important and used a lot in Selenium,
     * 
     * *******************/



    public class Tests2
    {
        private int a;    // declared at class level
        [TestInitialize]  // initialise before each and every test
        public void RunbeforeEverytest()  // initialise before each and every test
        {
            a = 1;    // set var here once
        }

        [TestMethod]
        public void test1()
        {
           // a = 1;
            var b = 1;
            Assert.AreEqual(2, a + b);

        }
        [TestMethod]
        public void test2()
        {
           // a = 1;
            var y = 2;
            Assert.AreEqual(3, a + y);
          //  Assert.Fail();     // forces a failure
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void test3()
        {
            int x = 10;
            int b = 10;
            Assert.AreEqual(21, x + b);
        }
    }
}
