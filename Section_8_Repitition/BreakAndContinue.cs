using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_8_Repitition
{
    [TestClass]
    public class BreakAndContinue
    {
        [TestMethod]
        public void Break_Keyword()
        {
            int total = 0;
            for(int nValue = 0; nValue < 10; nValue++)
            {
                if (nValue == 5)
                {
                    break;
                }
                total += nValue;  
            }
            Assert.AreEqual(total, 10);
        }

        [TestMethod]
        public void Continue_Keyword()
        {
            int iTotal = 0;
            for (int iValue = 0; iValue < 10; iValue++)
            {
                if (iValue == 5)
                {
                    continue;  // continues without completeing the rest of this itteration. So when iValue == 5 iTotal += iValue; doe NOT get executed.
                }
                iTotal += iValue;
            }
            Assert.AreEqual(iTotal, 40);
        }


    }
}
