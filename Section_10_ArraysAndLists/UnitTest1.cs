using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_10_ArraysAndLists
{
    /*
     * Lesson 112 the for each loop
     * Lesson 113 passing arrays to methods
     * Lesson 114 Passing an array element to a method
     * Arrays are reference variables and so point to the memory location
     * Lesson 115 the Array Class 
     * https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netframework-4.8
     * 
     */
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Array_Test()
        {
            int[] scores = new int[10];
        }

        [TestMethod]
        public void ForEachLoop()
        {
            int[] scores =  {3,6,1,77,4,8,9};
            // for each loop is often used for collections as it already knows the number in the collection
            foreach(int counter in scores)
            {
                Console.WriteLine(counter);
            }

        }
        [TestMethod]
        public void Pass_Array()
        {
            int[] scores = { 3, 6, 1, 77, 4, 8, 9 };
            int sum = TotalScores(scores);
            Assert.AreEqual(108, sum);
        }
        [TestMethod]
        public int TotalScores(int[] scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            return sum;
        }
        [TestMethod]
        public void PassArrayElement()
        {
            int[] scores = { 14, 3, 11, 13, 4, 19 };
            foreach(int score in scores)
            {
                Console.WriteLine(CheckScore(score));

            }

        }
        [TestMethod]
        public string CheckScore(int score)
        {
            if (score >= 10)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }
        [TestMethod]
        public void Array_Class_Methods()
        {
            double[] waterDepth= {12.2, 3.5, 5.6};
            Array.Sort(waterDepth);
            foreach(double wVal in waterDepth)
            {
                Console.Write(wVal + "\t");
            }
            Array.Reverse(waterDepth);
            foreach (double wVal in waterDepth)
            {
                Console.Write(wVal + "\t");
            }
        }
    }
}
