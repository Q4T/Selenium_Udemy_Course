using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_5_Maths_Equality_and_Rational_Operators
{
    [TestClass]
    public class SectionQuiz
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            // farenheit var
            double far = 32;
            double celc;
            // (32°F − 32) × 5/9 = 0°C
            celc = (far - 32) * 5 / 9;
            Console.WriteLine($"The temperature in F {far} is {celc} in C") ;
            Assert.AreEqual(celc, 0, 0.001);
        }

        [TestMethod]
        public void Convert_C_To_F()
        {
            // (0°C × 9/5) + 32 = 32°F
            double celc = 0;
            double far;
            far = (celc * 9/5) + 32;
            Console.WriteLine($"The temp in celcius {celc} is {far} in F");
            Assert.AreEqual(far, 32, 0.001);
        }
    }
}
