using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_8_Repitition
{
    /* Lesson 92 Switch Statements
     * Evaluates to true or false
     * Default is optional
     * 
     */
    [TestClass]
    public class SwitchStatement
    {
        [TestMethod]
        public void SwitchStatementTest()
        {
            int day = 4;
            string testDay;
//            string testDay = "";  teacher did it this way

            switch (day)
            {
                case 1:
                    testDay = "Monday";
                    break;
                case 2:
                    testDay = "Tue";
                    break;
                case 3:
                    testDay = "Wed";
                    break;
                case 4:
                    testDay = "Thur";
                    break;
                case 5:
                    testDay = "Fri";
                    break;
                default:
                    testDay = "Not a week day";
                    break;
            }
            Assert.AreEqual(testDay,"Thur");
        }
    }
}
