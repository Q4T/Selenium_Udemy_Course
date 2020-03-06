using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_8_Repitition
{
    /*
     Lesson 85 while loops
     lesson 86 incrementing and decrementing operators
     a++ Does the operation then increments by 1
     ++a increments by 1 first, then does the operation
     a--
     --a as above
         
     */
    [TestClass]
    public class WhileLoops
    {
        [TestMethod]
        public void Test_While_Loop()
        {
            int num = 1;
            while (num < 11)
            {
                Console.WriteLine(num);
                num++;
            }
        }

        [TestMethod]
        public void Test_Operators()
        {
            int num = 1;

            Console.WriteLine("Post increment num++ value is {0} ", num++ );  // will be 1  
            Console.WriteLine("Pre increment ++num value is {0} ", ++num);  // we printed 1 then added 1 then ++num added another q so - 3
            Console.WriteLine("Post increment num-- value is {0} ", num--); //takes the num as is (3) prints then takes one off to give 2
            Console.WriteLine("Pre increment --num value is {0} ", --num);   // takes odd 1 to make 1, then prints it
        }

        [TestMethod]
        public void Nested_Loops()
        {
            int num1 = 0;
            int num2 = 0;
            while (num1 <= 5)
            {
                while (num2 < num1)
                {
                    Console.WriteLine(num2);
                    num2++;
                }// inneer loop
                num1++;
            }//outer loop
                
        }
    }
}
