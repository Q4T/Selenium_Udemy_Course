using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;  // have to add this to use collections

namespace Section_10_ArraysAndLists
{
    /*
     * Lesson 120 List Collections
     * Generally could not to mix data types in an arrayList as it makes looping through awkward
     * 
     */
    [TestClass]
    public class ListCollections
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList myArray = new ArrayList();
            myArray.Add("Today");
            myArray.Add(2);
            myArray.Add(22);
            myArray.Add(24M);
            myArray.Add(2);
            Console.WriteLine(myArray.Count);
            myArray.RemoveAt(2);
            Console.WriteLine(myArray.Count);
        }
        [TestMethod]
        public void TestFillList()
        {
            ArrayList scores = new ArrayList();
            FillList(scores); // polulate the arraList
            int sum = TotalScores(scores);
        }

        public void FillList(ArrayList scores)
        {
            for(int i = 0; i < 10; i++)
            {
                scores.Add(i);
            }
        }

        public int TotalScores(ArrayList scores)
        {
            int sum = 0;
            foreach(int score in scores)
            {
                sum += score;
            }
            return sum;
        }

        [TestMethod]
        public void ArrayListPractice()
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Adding some numbers");
            list.Add(3);
            list.Add(55);
            list.Add(32);
            list.Add(7);
            list.Add(77);
            Console.WriteLine("List capacity: {0} ", list.Capacity);
            Console.WriteLine("List count: {0} ", list.Count);
            Console.Write("Content: ");

            foreach(int i in list)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sort Content");
            list.Sort();
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
