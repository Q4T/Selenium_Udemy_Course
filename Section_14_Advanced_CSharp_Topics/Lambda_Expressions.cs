using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_14_Advanced_CSharp_Topics
{
    // Lesson 158 Lambda Expressions
    // In Csharp a lambda expression is a function that uses short and clear syntax to describe a pattern of behaviour 

    [TestClass]
    public class Lambda_Expressions
    {


        delegate int del(int i);  // create a delegate
        [TestMethod]
        public void TestLambda()
        {
            del myDelegate = x => x * x;   // Lambda expression: input params goon left side of expression 
            int j = myDelegate(5);
            Assert.AreEqual(j,25); 
        }

        [TestMethod]
        public void TestListLambda()
        {
            List<int> elements = new List<int>() { 10, 20, 35, 40 };
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);
        }

        delegate void TestDelegate(string s);
        [TestMethod]
        public void TestStatementLamda()
        {
            TestDelegate del = n =>   // n is assigned the variable passed in when calling the delegate
            {
                string s = n + " World";    // we can have mutiple statements in a statement Lambda but keep to max of 3
                Console.WriteLine(s);    
            };

            del("Hello");  // this calls the delegate
        }
    }

}
