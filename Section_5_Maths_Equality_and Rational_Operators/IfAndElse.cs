using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5_Maths_Equality_and_Rational_Operators
{
    /**
     * Lesson 60 if Else Statements
     * We should never have more than 1 assertion per test method ? But the teacher keeps using them, dores it mean per logic branch?
     *
     **/

    [TestClass]
    public class IfAndElse
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
            else
            {
                Assert.Fail();
            }
           

        }

        [TestMethod]
        public void Num1_is_Not_Equal_to_Num2()
        {
            if (num1 != num2)
            {
                Assert.IsTrue(num1 != num2);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Num1GreaterThanNum2()
        {
            if (num1 > num2)
            {
                Assert.IsTrue(num1 > num2);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void Num1isLessThanOrEqualToNum2()
        {
            if (num1 <= num2)
            {
                Assert.IsTrue(num1 <= num2);
            }
            else
            {
                Assert.Fail();
            }
        }


    }
}
