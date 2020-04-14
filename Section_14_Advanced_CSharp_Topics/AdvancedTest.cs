using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_14_Advanced_CSharp_Topics
{
    [TestClass]
    public class AdvancedTest
    {
        [TestMethod]
        public void ImplicitCasting()
        {
            Mammal mammal = new Cat();  // An object can be typed by the type it inherits from
            Animal animal = new Cat(); // We can also set the type of a cat to animal as a cat is an animal

        }
        [TestMethod]
        public void ExplicitCasting()
        {
            double dPi = 3.1415926;
            int iValue = (int)dPi;  // explicitley convert to an int
            Console.WriteLine(iValue);
        }
        [TestMethod]
        public void BoxingCasting()
        {
            // this wraps a variable up into an system Object and dtores in on the managed heap
            // Boxing is an implicit process Boxing = moving from a value type to an object type (putting it in an object box)
            // UnBoxing is Animal Explicit process. UnBioxing is moving from an ojbect type to a value type.
            // Boxing and unBoxing is computationally exspensive

            double dPI = 3.1415926;
            object oPi = (object)dPI;  // Boxing

            double dPi = (double)oPi; // unboxing



        }
    }
}
