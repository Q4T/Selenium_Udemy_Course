using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_8_Repitition
{
    [TestClass]
    public class CodingQuiz
    {
        [TestMethod]
        public void NestedLoopQuizTest()
        {
            int outer = 0;
            while(outer < 3)
            {
                int inner = 10;
              //  Console.WriteLine(num1);
                while (inner > 5)
                {
                  //  Console.WriteLine("Outer: "+ num1 + "             " + "Inner: "+num2);
                    Console.WriteLine($"Outer: {outer}\tInner: {inner}");
                    inner--;
                }// inner loop
                outer++;
            }// outer loop
            
        }
    }
}
