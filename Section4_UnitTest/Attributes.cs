using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section4_UnitTest
{

    /* *******************************************************************************************
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
     * TestContext  // Trace.Write(_testContext.TestName); - These comments only appear in the debug output window.
     * The comments made by the Trace.Write method are known 
     * 
     * TestInitialize   very important and used a lot in Selenium, We can initialise the Web Driver in here.
     * 
     * All Test methods HAVE to be public
     * All Test methods have to be VOID i.e. not return anything.
     * [ClassInitialize] has to be static void and take a TestContext variable
     * [ClassCleanup]  has to be static void
     * 
     * 
     * 
     * ************************************************************************************************/

    [TestClass]
    [TestCategory("Attributes_TestInitialize")]


    public class Attributes
    {
        private int a;    // declared at class level
        private static TestContext _testContext;

        public TestContext TestContext { get; set;}     // ********  Lesson 52 TestContext

        [ClassInitialize]
        public static void RunsBeforeAllTestMethods(TestContext testContext)   // passes in a TestContext variable.
        {
         // initialise stuff at class level
            _testContext = testContext;
            Trace.WriteLine("TestContext has been initialised");
        }

        [ClassCleanup]
        public static void ClassCleanUp()
        {
            // clean up at the end of the class after all test done 
        }

        [TestInitialize]  // initialise before each and every test
        public void RunBeforeEverytest()  // initialise before each and every test
        {
            a = 1;
        }

        [TestCleanup]
        public void RunAfterEachTest()
        {
        // nothing here
        }

        [TestMethod]
        public void TestCase01()
        {
            Trace.WriteLine(TestContext.TestName);
            var b = 1;
            Assert.AreEqual(2, a + b);
        }
        [TestMethod]
        public void TestCase02()
        {
            Trace.WriteLine(TestContext.TestName);
            var y = 2;
            Assert.AreEqual(3, a + y);
          //  Assert.Fail();     // forces a failure
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void TestCase03()
        {
            Trace.WriteLine(TestContext.TestName);
            int x = 10;
            int b = 10;
            Assert.AreEqual(21, x + b);
        }
    }
}
