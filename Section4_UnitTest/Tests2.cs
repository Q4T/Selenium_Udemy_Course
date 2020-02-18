using System;
using System.Collections.Generic;
using System.Diagnostics;
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
     * Lesson 50 TestInitialize
     * Lesson 52 TestContext
     * 
     * Attributes covered here:
     * 
     * [ClassInitialize]   // has to be static
     * [TestInitialize]
     * [TestCleanup]
     * [ClassCleanup]       // has to be static
     * 
     * TestContext  // 
     * 
     * TestInitialize   very important and used a lot in Selenium, We can initialise the Web Driver in here.
     * 
     * All Test methods HAVE to be public
     * All TEst methods have to be VOID i.e. not return anything.
     * 
     * *******************/


    public class Tests2
    {

        private int a;    // declared at class level

        public TestContext Test2Context { get; set;}     // ********  Lesson 52 TestContext
        private static TestContext _testContext;
      
        [ClassInitialize]
        public static void StartOfClass(TestContext testContext)
        {
            // initialise stuff at class level
            _testContext = testContext;
        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            // clean up at the end of the class after all test done 

        }


        [TestInitialize]  // initialise before each and every test
        public void RunbeforeEverytest()  // initialise before each and every test
        {
            a = 1;    // set var here once
        }


        [TestCleanup]
        public void RunAfterEachTest()
        {
            // destroy objects etc. 
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
