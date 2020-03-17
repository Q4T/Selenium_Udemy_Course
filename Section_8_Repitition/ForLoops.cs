using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_8_Repitition
{

    // Lesson 90 For Loops
    // x += y same as  x = x + y  

    [TestClass]
    public class ForLoops
    {
        [TestMethod]
        public void TestMethod1()
        {
            int inner = 0;
            // for (init;test;update)
            for (int outer = 0; outer < 3; outer++)
            {
                // inner loop 
                for(inner=10; inner > 5; inner--)
                {
                    Console.WriteLine($"Outer: {outer}\tInner: {inner}");
                }

            }
        }
        [TestMethod]
        public void StrangeForLoops()
        {
            // initialise 2 variables
            for(int counter = 0,val1 = 10;counter < val1; counter++)   // not recomended
            {
            }
            // can use floats as well
            for(double d=15.0;d<20.0; d += 0.5) 
            {

            }

        }
    }
}
