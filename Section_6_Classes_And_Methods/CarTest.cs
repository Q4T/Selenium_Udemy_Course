using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_6_Classes_And_Methods
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arange
            Car myCar = new Car("red",4,true);
            myCar.FamilyCar();
            
            // act

            // assert
            StringAssert.Equals(myCar.Colour, "red");
        }
    }
}
