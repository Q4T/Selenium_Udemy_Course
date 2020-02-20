using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5_Maths_Equality_and_Rational_Operators
{
    /**
     * Lesson 59 If Statements
     *
     *
     **/

    [TestClass]
    public class EqualityAndRelationships
    {
        static int num1;
        static int num2;


        [ClassInitialize()]
        public static void IntegerInitialise(TestContext testContext)
        {
            num1 = 10;
            num2 = 5;
        }

        [TestMethod]
        public void Num1_is_Equal_to_Num2()
        {
            if (num1 == num2)
            {
                Assert.IsTrue(num1 == num2);
            }
            Assert.Fail();        
            
        }

        [TestMethod]
        public void Num1_is_Not_Equal_to_Num2()
        {
        }
    }
}
